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
