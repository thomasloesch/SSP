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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseSSPDataSet.roomTbl' table. You can move, or remove it, as needed.
            this.roomTblTableAdapter.Fill(this.databaseSSPDataSet.roomTbl);

            // Set combo boxes to "None"
            cmboBxBedType.SelectedIndex = 0;
            cmboBxRmType.SelectedIndex = 0;
            cmboBxNumBeds.SelectedIndex = 0;
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Set new query for database
            string sqlQuery = "SELECT RoomNum, RoomType, Beds, BedType, Price FROM roomTbl";

            // Get current status of combo boxes
            if (cmboBxBedType.Text != "None" || cmboBxNumBeds.Text != "None" || cmboBxRmType.Text != "None")
            {
                sqlQuery += " WHERE";
                if (cmboBxBedType.Text != "None")
                {
                    sqlQuery += " BedType='" + cmboBxBedType.Text + "'";
                    if (cmboBxNumBeds.Text != "None")
                    {
                        sqlQuery += " AND Beds='" + cmboBxNumBeds.Text + "'";
                        if (cmboBxRmType.Text != "None")
                        {
                            sqlQuery += " AND RoomType='" + cmboBxRmType.Text + "'";
                        }
                    }
                    else if (cmboBxRmType.Text != "None")
                    {
                        sqlQuery += " AND RoomType='" + cmboBxRmType.Text + "'";
                    }
                }
                else if (cmboBxNumBeds.Text != "None")
                {
                    sqlQuery += " .Beds='" + cmboBxNumBeds.Text + "'";
                    if (cmboBxRmType.Text != "None")
                    {
                        sqlQuery += " AND RoomType='" + cmboBxRmType.Text + "'";
                    }
                }
                else if (cmboBxRmType.Text != "None")
                {
                    sqlQuery += " RoomType='" + cmboBxRmType.Text + "'";
                }
                sqlQuery += ";";
            }

            // Update the dataAdapter
            roomTblTableAdapter.Adapter.SelectCommand.CommandText = sqlQuery;
            this.roomTblTableAdapter.Fill(this.databaseSSPDataSet.roomTbl);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Check for invalid states
            if (dateTimeFrom.Value.Date < DateTime.Now.Date) {
                MessageBox.Show("You can't book a date that has already happened!\nPlease change your selection.");
                return;
            }
            if (dataGridViewSSP.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select one row.");
                return;
            }

            // Get the room number of the selected row from the dataset
            string selectedRowRoomNum = dataGridViewSSP.SelectedRows[0].Cells[0].Value.ToString();

            // Establish connection to the database
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\WORKSPACE\SSP\HOTELRESERVATIONAPP\HOTELRESERVATIONAPP\BIN\DEBUG\DATABASESSP.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            string query = "SELECT Id FROM dbo.roomTbl WHERE RoomNum='" + selectedRowRoomNum + "';";
            SqlCommand sqlCmd = new SqlCommand(query, conn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();
            string selectedRoomId = sqlReader.GetString(0);
            sqlReader.Close();

            query = "SELECT * FROM dbo.bookedTbl WHERE RoomId='" + selectedRoomId + "';";
            sqlCmd.CommandText = query;
            sqlReader = sqlCmd.ExecuteReader();
            while (sqlReader.Read())
            {
                // Check if dates intersect
                DateTime to, from;
                to = sqlReader.GetDateTime(4);
                from = sqlReader.GetDateTime(5);

                // TODO: Check logic, probably incorrect (Might be able to move this check into the sql statement)
                if ((from > dateTimeFrom.Value && to < dateTimeTo.Value) || (to < dateTimeTo.Value && from > dateTimeFrom.Value))
                {
                    // Handle conflict
                    MessageBox.Show("That room is booked at that time.\nPlease select a different room or time.");
                    sqlReader.Close();
                    conn.Close();
                    return;
                }
            }
            MessageBox.Show("The room is available at that time.\nPlease press the 'Book' button to finalize you choice.");

            sqlReader.Close();
            conn.Close();
        }

        private void radBtnSingle_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeTo.Enabled = false;
            dateTimeTo.ResetText();
        }

        private void radBtnMultiple_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeTo.Enabled = true;
        }
    }
}
