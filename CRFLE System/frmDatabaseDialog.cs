using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRFLE_System
{
    public partial class frmDatabaseDialog : Form
    {
        public static String successmessage;
        public static String message;
        public static String query1;
        public static String query2;
        public static String query3;
        public static String query4;
        public static Boolean BRbool;

        public frmDatabaseDialog()
        {
            InitializeComponent();
        }

        private void frmDatabaseDialog_Load(object sender, EventArgs e)
        {
            this.lblMessage.Text = message;
            this.lblSuccessMessage.Text = successmessage;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (frmLogin.activeVerificationPassword == this.txtpassword.Text)
            {
                if (BRbool == true)
                {
                    hidepanels();
                    this.panelSuccess.Show();
                    this.txtpassword.Text = "";

                    //delay to hide 'successfully saved' prompt
                    wait();
                    //execute after delay
                    new dbModule().backUpDB(query1);
                    this.Close();
                }
                else
                {
                    hidepanels();
                    this.panelSuccess.Show();
                    this.txtpassword.Text = "";

                    //delay to hide 'successfully saved' prompt
                    wait();
                    //execute after delay
                    new dbModule().restoreDB(query2, query3, query4);
                    this.Close();
                }
            }
            else
            {
                hidepanels();
                this.panelFail.Show();

                //delay to hide 'successfully saved' prompt
                var t = Task.Run(async delegate
                {
                    await Task.Delay(TimeSpan.FromSeconds(1));
                });
                t.Wait();
                //execute after delay
                hidepanels();
                this.txtpassword.Text = "";
            }
        }

        private void hidepanels()
        {
            this.panelSuccess.Hide();
            this.panelFail.Hide();
        }

        private void wait()
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
            });
            t.Wait();
        }
    }
}
