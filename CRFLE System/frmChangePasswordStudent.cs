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
    public partial class frmChangePasswordStudent : Form
    {
        public frmChangePasswordStudent()
        {
            InitializeComponent();
        }

        private void frmChangePasswordStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtpassword1.Text != "" && this.txtpassword2.Text != "")
            {
                if (frmLogin.activeVerificationPassword == this.txtpassword2.Text)
                {
                    hidepanels();
                    this.panelSuccess.Show();
                    this.txtpassword2.Text = "";

                    //delay to hide 'successfully saved' prompt
                    wait();

                    //execute after delay
                    //new dbModule().deleteFromDB(query);
                    //new dbModule().refreshDataGrid(dg, refreshquery);
                    this.Close();
                }
                else
                {
                    hidepanels();
                    this.lblFail.Text = "Verification failed.";
                    this.panelFail.Show();

                    //delay to hide 'successfully saved' prompt
                    wait();

                    //execute after delay
                    hidepanels();
                    this.txtpassword2.Text = "";
                }
            }
            else
            {
                hidepanels();
                this.lblFail.Text = "Please fill all fields.";
                this.panelFail.Show();
                wait();
                hidepanels();
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
