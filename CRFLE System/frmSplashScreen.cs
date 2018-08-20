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
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void splash()
        {
            this.lblProcess.Text = "Initializing Login...";
            frmLogin login = new frmLogin();
            this.lblProcess.Text = "Initializing Teacher modules...";
            new frmTeacherMain();
            this.lblProcess.Text = "Initializing Student modules...";
            new frmStudentMain();
            this.lblProcess.Text = "Initializing Database module...";
            new dbModule();


        }

        private void frmSplashScreen_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
