using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CRFLE_System
{
    public partial class frmDialog : DevExpress.XtraEditors.XtraForm
    {
        public static String successmessage;
        public static String message;
        public static String query;
        public static DataGridView dg;
        public static String refreshquery;

        public frmDialog()
        {
            InitializeComponent();
        }

        private void frmVerificationDialog_Load(object sender, EventArgs e)
        {
            this.lblMessage.Text = message;
            this.lblSuccessMessage.Text = successmessage;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (frmLogin.activeVerificationPassword == this.txtpassword.Text)
            {
                hidepanels();
                this.panelSuccess.Show();
                this.txtpassword.Text = "";

                //delay to hide 'successfully saved' prompt
                var t = Task.Run(async delegate
                {
                    await Task.Delay(TimeSpan.FromSeconds(1));
                });
                t.Wait();
                //execute after delay
                new dbModule().deleteFromDB(query);
                new dbModule().refreshDataGrid(dg, refreshquery);
                this.Close();
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
    }
}