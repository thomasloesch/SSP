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
        private string usrName;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string _usrName)
        {
            InitializeComponent();
            usrName = _usrName;
        }

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbSSPDataSet.bookedTbl' table. You can move, or remove it, as needed.
            this.bookedTblTableAdapter.Fill(this.dbSSPDataSet.bookedTbl);
            // TODO: This line of code loads data into the 'dbSSPDataSet.roomTbl' table. You can move, or remove it, as needed.
            this.roomTblTableAdapter.Fill(this.dbSSPDataSet.roomTbl);

            // Set combo boxes to "None"
            cmboBxBedType.SelectedIndex = 0;
            cmboBxRmType.SelectedIndex = 0;
            cmboBxNumBeds.SelectedIndex = 0;

            // Set lblUser with current log-in user name
            lblUser.Text = "Logged in as:\n" + usrName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Set new query for database
            string sqlQuery = "SELECT RoomNum, RoomType, Beds, BedType, Price FROM roomTbl";

            // Add 'WHERE ...' section of query based on current values of comboBoxes
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
                    sqlQuery += " Beds='" + cmboBxNumBeds.Text + "'";
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

            try
            {
                // Update the dataAdapter
                roomTblTableAdapter.Adapter.SelectCommand.CommandText = sqlQuery;
                this.roomTblTableAdapter.Fill(this.dbSSPDataSet.roomTbl);

                // If dataSet is empty
                if (this.dbSSPDataSet.roomTbl.Count == 0)
                {
                    // Display message
                    lblRooms.Text = "There are no rooms that match your preferences.";
                    lblRooms.Visible = true;
                }
                else // Otherwise hide message
                {
                    lblRooms.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error attempting to connect to the database.\n" + ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radBtnSingle_CheckedChanged(object sender, EventArgs e)
        {
            // When user selects radio button, enable second DateTime control
            // and make sure they have the same value. 
            dateTimeTo.Enabled = false;
            dateTimeTo.Value = dateTimeFrom.Value;
        }

        private void radBtnMultiple_CheckedChanged(object sender, EventArgs e)
        {
            // When user selects radio button, enable second DateTime control
            // and make sure they have the same value.
            dateTimeTo.Enabled = true;
            dateTimeTo.Value = dateTimeFrom.Value;
        }

        private void dataGridViewSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get room number of selected row
            DataGridViewRow currRow = dataGridViewSSP.Rows[e.RowIndex];
            string selectedRoomId = currRow.Cells[0].Value.ToString();

            // Set new query for database
            string sqlQuery = "SELECT * FROM bookedTbl WHERE RoomId='" + selectedRoomId + "';";

            try
            {
                // Update the dataAdapter
                bookedTblTableAdapter.Adapter.SelectCommand.CommandText = sqlQuery;
                this.bookedTblTableAdapter.Fill(this.dbSSPDataSet.bookedTbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error attempting to connect to the database.\n" + ex.Message);
            }

            // Display message if no bookings
            if (this.dbSSPDataSet.bookedTbl.Count == 0)
            {
                lblBooked.Text = "This room currently has no bookings.";
                lblBooked.Visible = true;
            }
            else // Otherwise hide message
            {
                lblBooked.Visible = false;
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            // Check for invalid states
            if (dateTimeFrom.Value.Date > dateTimeTo.Value.Date)
            {
                MessageBox.Show("You can't book a date range which defys the laws of nature!\nPlease change your selection.");
                return;
            }
            if (dateTimeFrom.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("You can't book a date that has already happened!\nPlease change your selection.");
                return;
            }
            if (dataGridViewSSP.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a single row.");
                return;
            }
            

            // Save values from dateTime form objects in references
            DateTime selectedTo, selectedFrom;
            selectedTo = dateTimeTo.Value;
            selectedFrom = dateTimeFrom.Value;

            // Get the room number of the selected row from the dataset
            string selectedRowRoomNum = dataGridViewSSP.SelectedRows[0].Cells[0].Value.ToString();

            try
            {
                // Establish connection to the database
                string connectionString = @"Data Source=tloesch.database.windows.net;Initial Catalog=dbSSP;Integrated Security=False;User ID=tloesch;Password=Ssp12345;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = "SELECT * FROM dbo.bookedTbl WHERE RoomId='" + selectedRowRoomNum + "';";
                SqlCommand sqlCmd = new SqlCommand(query, conn);
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                // Check all the results for an intersection
                while (sqlReader.Read())
                {
                    // Initializations
                    DateTime to, from;
                    int toIndex = sqlReader.GetOrdinal("ToDate");
                    int fromIndex = sqlReader.GetOrdinal("FromDate");
                    to = sqlReader.GetDateTime(toIndex);
                    from = sqlReader.GetDateTime(fromIndex);



                    // Case1: The selected range occurs before the booked date range
                    // Case2: The selected range occurs after the booked date range
                    // CLARIFICATION: The booking goes until midnight of the to date.
                    //                Therefore you cannot book a from date on a to date.
                    bool case1, case2;
                    case1 = selectedTo < from;
                    case2 = selectedFrom > to;

                    if (!(case1 || case2))
                    {
                        // Handle conflict
                        MessageBox.Show("That room is booked at that time.\nPlease select a different room or time.");
                        sqlReader.Close();
                        conn.Close();
                        return;
                    }
                }
                sqlReader.Close();

                query = "INSERT INTO dbo.bookedTbl(RoomId, FromDate, ToDate) VALUES(@rId, @fromDate, @toDate);";
                sqlCmd.CommandText = query;
                sqlCmd.Parameters.AddWithValue("@rId", selectedRowRoomNum);
                sqlCmd.Parameters.AddWithValue("@fromDate", selectedFrom);
                sqlCmd.Parameters.AddWithValue("@toDate", selectedTo);
                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Your room has been booked.\nThank you for staying with us!");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error attempting to connect to the database.\n" + ex.Message);
            }
        }

        private void dateTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            // When only booking for one day, make sure both DateTime boxes are the same date
            if (radBtnSingle.Checked)
                dateTimeTo.Value = dateTimeFrom.Value;
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show a new SignInForm and get new validated user
            SignInForm frmLogin = new SignInForm();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                usrName = frmLogin.usrValidated;
                lblUser.Text = "Logged in as:\n" + usrName;
                frmLogin.Dispose();
            }
            else // Otherwise close the application
            {
                Application.Exit();
            }
        }
    }
}
