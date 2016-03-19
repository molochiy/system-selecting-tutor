using SST.DesktopUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SST.DesktopUI
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

            LoginForm frmLogin = new LoginForm();            

            while(!frmLogin.IsEntered)
            {
                if (frmLogin.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }

            Application.Run(new MainForm());
        }
    }
}
