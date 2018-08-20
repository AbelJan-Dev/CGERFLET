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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public static String loginVar = null;
        public static String activeUserID;
        public static String activeFullname;
        public static String activeVerificationPassword;

        public frmLogin()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String uname = this.txtusername.Text;
            String upass = this.txtpassword.Text;

            if ((this.txtusername.Text == "") && (this.txtpassword.Text == ""))
            {
                hidePanels();
                panelErrorCredentials.Show();
                this.labelusernameorpassword.Text = "Please enter your username and password.";
            }
            else if ((this.txtusername.Text == ""))
            {
                hidePanels();
                panelErrorCredentials.Show();
                this.labelusernameorpassword.Text = "Please enter your username.";
            }
            else if ((this.txtpassword.Text == ""))
            {
                hidePanels();
                panelErrorCredentials.Show();
                this.labelusernameorpassword.Text = "Please enter your password.";
            }
            else
            {
                new dbModule().checkLogin(uname, upass);

                if (loginVar == "username")
                {
                    hidePanels();
                    panelErrorUsername.Show();
                }
                else if (loginVar == "password")
                {
                    hidePanels();
                    panelErrorPassword.Show();
                }
                else if (loginVar == "verify")
                {
                    hidePanels();
                    panelErrorVerify.Show();
                }
                else if (loginVar == "teacher")
                {
                    hidePanels();
                    new dbModule().getActiveUser(this.txtusername.Text, this.txtpassword.Text);
                    frmLogin.activeVerificationPassword = this.txtpassword.Text;
                    this.Hide();
                    new frmTeacherMain().Show();
                }
                else if (loginVar == "student")
                {
                    hidePanels();
                    new dbModule().getActiveUser(this.txtusername.Text, this.txtpassword.Text);
                    frmLogin.activeVerificationPassword = this.txtpassword.Text;
                    this.Hide();
                    new frmStudentMain().Show();
                }
            }
        }

        private void hidePanels()
        {
            panelErrorUsername.Hide();
            panelErrorPassword.Hide();
            panelErrorCredentials.Hide();
            panelErrorVerify.Hide();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            if (this.txtusername.Text != "" && this.txtpassword.Text != "")
            {
                hidePanels();
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (this.txtusername.Text != "" && this.txtpassword.Text != "")
            {
                hidePanels();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit?","System",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void lnkNoAccount_Click(object sender, EventArgs e)
        {
            frmAddUser.usertype = 1;
            frmAddUser.verified = 0;

            this.Hide();
            new frmAddUser().Show();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkShowPassword.Checked == true)
            {
                this.txtpassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtpassword.Properties.UseSystemPasswordChar = true;
            }
        }

        private void panelErrorVerify_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            //this.btnLogin.BackColor = Color.White;
            //this.btnLogin.ForeColor = Color.Navy;
        }
    }
}