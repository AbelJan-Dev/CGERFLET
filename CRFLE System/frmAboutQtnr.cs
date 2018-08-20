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
    public partial class frmAboutQtnr : DevExpress.XtraEditors.XtraForm
    {
        public static string title;
        public static string desc;
        public static string date;
        public static string fullname;
        public static string count;
        public static string usage;

        public frmAboutQtnr()
        {
            InitializeComponent();
        }

        private void frmAboutQtnr_Load(object sender, EventArgs e)
        {
            new dbModule().getQtnrInfo(frmTeacherMain.clickedQtnr);

            this.lblTitle.Text = title;
            this.lblDescription.Text = desc;
            this.lblDate.Text = date;
            this.lblCreator.Text = fullname;
            this.lblCount.Text = count;
            this.lblUsage.Text = usage;

            //MessageBox.Show(Convert.ToString(frmQuestionnaire.clickedQtnr));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}