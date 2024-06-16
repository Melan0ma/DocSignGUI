using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocSignGUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string argVal = "";
            if (argVal.Length >= 1)
                argVal = Environment.GetCommandLineArgs()[1];
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin loginFrm = new FrmLogin();
            loginFrm.FormClosed += new FormClosedEventHandler(FormClosed);

            if (argVal != "be6da1a26f940a49acb1a75dfc42d7ed911ab87f55f7dfacc6ea7185f6a55887")
            {
                using (Mutex appMutex = new Mutex(true, "{E524D93B-84BA-4A19-A9B7-F88253CD1309}"))
                {
                    if (appMutex.WaitOne(TimeSpan.Zero, true))
                    {
                        loginFrm.Show();
                        Application.Run();
                    }
                    else
                    {
                        MessageBox.Show(null, "Another instance of this application is already running... You are only allowed to run only one instance of this application at a time.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } 
            else
            {
                loginFrm.Show();
                Application.Run();
            }
            
        }

        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= new FormClosedEventHandler(FormClosed);
            if (Application.OpenForms.Count > 0)
            {
                Application.OpenForms[0].FormClosed += new FormClosedEventHandler(FormClosed);
                return;
            }
            Application.Exit();
        }
    }
}
