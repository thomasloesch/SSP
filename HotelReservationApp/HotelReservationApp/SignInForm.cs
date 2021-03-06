﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationApp
{
    public partial class SignInForm : Form
    {
        public string usrValidated;

        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check to see if user entered proper data
            if (txtBxName.Text.Length < 4 || txtBxPass.Text.Length < 8)
            {
                MessageBox.Show("The information you input is incorrect.");
                return;
            }

            try
            {
                // Establish connection with the database
                string dbConnection = @"Data Source=tloesch.database.windows.net;Initial Catalog=dbSSP;Integrated Security=False;User ID=tloesch;Password=Ssp12345;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection conn = new SqlConnection(dbConnection);
                conn.Open();


                //Check to see if name is in DB
                string sqlQuery = "SELECT Id FROM dbo.userTbl WHERE UserName = '" + txtBxName.Text + "';";
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader dbReader = sqlCmd.ExecuteReader();

                // If the user exists, check password
                if (dbReader.Read())
                {
                    int userId = dbReader.GetInt32(0);
                    dbReader.Close();
                     
                    // Get stored hash and salt
                    sqlQuery = "SELECT Hash, Salt FROM dbo.passTbl WHERE Usr_Id = " + userId + ";";
                    sqlCmd.CommandText = sqlQuery;
                    dbReader = sqlCmd.ExecuteReader();

                    dbReader.Read();
                    byte[] storedHash = Convert.FromBase64String(dbReader.GetString(0));
                    byte[] salt = Convert.FromBase64String(dbReader.GetString(1));
                    dbReader.Close();

                    // Hash input password
                    byte[] inputHash = GenerateSaltedHash(Encoding.UTF8.GetBytes(txtBxPass.Text), salt);

                    // If the stored hash and hashed input match, proceed to MainForm
                    if (CompareByteArrays(inputHash, storedHash))
                    {
                        MessageBox.Show("Welcome, " + txtBxName.Text + "!");
                        usrValidated = txtBxName.Text;
                        this.DialogResult = DialogResult.OK;
                    }
                    else // Otherwise, display an error message
                    {
                        MessageBox.Show("Your password is incorrect, please try again.");
                    }
                }
                else // If the user does not exist, display an error message
                {
                    dbReader.Close();
                    MessageBox.Show("That user doesn't exist. Please register first.");
                }

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was an error attempting to connect to the database.\n" + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.Show();
        }

        // Credit to http://stackoverflow.com/questions/2138429/hash-and-salt-passwords-in-c-sharp
        public static byte[] CreateSalt(int size)
        {
            //Generate a cryptographic random number.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);

            // Return a Base64 string representation of the random number.
            return buff;
        }

        // Credit to http://stackoverflow.com/questions/2138429/hash-and-salt-passwords-in-c-sharp
        public static byte[] GenerateSaltedHash(byte[] plainText, byte[] salt)
        {
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] plainTextWithSaltBytes =
              new byte[plainText.Length + salt.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainText[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[plainText.Length + i] = salt[i];
            }

            return algorithm.ComputeHash(plainTextWithSaltBytes);
        }

        // Credit to http://stackoverflow.com/questions/2138429/hash-and-salt-passwords-in-c-sharp
        public static bool CompareByteArrays(byte[] array1, byte[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }

        
    }
}
