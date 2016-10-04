using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelReservationApp
{
    public partial class RegisterForm : Form
    {
        private const int SALT_SIZE = 32;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Check to see if user entered data
            if (txtBxName.Text.Length < 4)
            {
                MessageBox.Show("Please use a longer username.");
                return;
            }
            if(txtBxPass.Text.Length < 8)
            {
                MessageBox.Show("Please use a longer password.");
                return;
            }

            // Establish connection to the database
            string dbConnection = @"Data Source=tloesch.database.windows.net;Initial Catalog=dbSSP;Integrated Security=False;User ID=tloesch;Password=Ssp12345;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(dbConnection);
            conn.Open();

            // Check to see if name is already in DB
            string sqlQuery = "SELECT Id FROM dbo.userTbl WHERE UserName = '" + txtBxName.Text + "';";
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dbReader = sqlCmd.ExecuteReader();

            if (dbReader.Read())
                lblMessage.Text = "That name is already in use.";
            else
            {
                dbReader.Close();

                // Insert username into userTbl
                sqlQuery = "INSERT INTO dbo.userTbl(UserName) VALUES(@userName);";
                sqlCmd = new SqlCommand(sqlQuery, conn);
                sqlCmd.Parameters.Add("@userName", SqlDbType.VarChar, 50);
                sqlCmd.Parameters["@userName"].Value = txtBxName.Text;
                sqlCmd.ExecuteNonQuery();

                // Get Id of new user
                sqlQuery = "SELECT Id FROM dbo.userTbl WHERE UserName = '" + txtBxName.Text + "';";
                sqlCmd = new SqlCommand(sqlQuery, conn);
                dbReader = sqlCmd.ExecuteReader();
                dbReader.Read();
                int user_Id = dbReader.GetInt32(0);
                dbReader.Close();

                try
                {                
                    // Hash password
                    byte[] salt = SignInForm.CreateSalt(SALT_SIZE);
                    byte[] hash = SignInForm.GenerateSaltedHash(Encoding.UTF8.GetBytes(txtBxPass.Text), salt);

                    //  Insert hashed password (and salt) into passTbl
                    sqlQuery = "INSERT INTO dbo.passTbl(Usr_Id, Hash, Salt) VALUES(" + user_Id + ", '" + Convert.ToBase64String(hash) + "', '" + Convert.ToBase64String(salt) + "');";
                    sqlCmd = new SqlCommand(sqlQuery, conn);
                    sqlCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Ensure dataReader is closed
                    if(!dbReader.IsClosed)
                        dbReader.Close();

                    // Make sure UserName is removed from db if there
                    // is an exception when attempting to set password
                    sqlQuery = "DELETE FROM dbo.userTbl WHERE (UserName='" + txtBxName.Text + "');";
                    sqlCmd = new SqlCommand(sqlQuery, conn);
                    sqlCmd.ExecuteNonQuery();

                    // Close connections
                    conn.Close();

                    throw ex;
                }
            }

            // Close connection
            dbReader.Close();
            conn.Close();
        }
    }
}
