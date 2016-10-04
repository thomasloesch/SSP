using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show log-in as dialog, if user logs in successfully, show MainForm
            SignInForm frmLogin = new SignInForm();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm(frmLogin.usrValidated));
                frmLogin.Dispose();
            }
            else // Otherwise exit
            {
                Application.Exit();
            }
        }
    }
}
