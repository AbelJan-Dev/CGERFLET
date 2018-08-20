using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace CRFLE_System
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

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            //Application.Run(new frmLogin());
            //bool isset = dbModule.isSetConnectionStringValues();

            //if (isset == false)
            //{
            //    Application.Run(new SpecifyConnection());
            //}
            //else
            //{
                if (new dbModule().CheckServerConnection() == null)
                {
                    Application.Run(new SpecifyConnection());
                }
                else
                {
                    Application.Run(new frmLogin());
                }
            //}
            
        }
    }
}
