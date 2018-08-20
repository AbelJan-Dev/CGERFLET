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
    public partial class frmAboutExam : Form
    {
        public static string date;
        public static string stime;
        public static string etime;
        public static string duration;
        public static string status;
        public static string qtnr;

        public frmAboutExam()
        {
            InitializeComponent();
        }

        private void frmAboutExam_Load(object sender, EventArgs e)
        {
            this.lblDate.Text = date;
            this.lblStartTime.Text = stime;
            this.lblEndTime.Text = etime;
            this.lblDuration.Text = duration;
            this.lblStatus.Text = status;
            this.lblQtnr.Text = qtnr;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
