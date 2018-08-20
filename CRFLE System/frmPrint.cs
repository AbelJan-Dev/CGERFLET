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
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        public static int qtnrID;
        public static string qtnrTitle;

        public frmPrint()
        {
            InitializeComponent();
        }

        public void printQuestionnaire()
        {
            Questionnaire qtn = new Questionnaire();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in qtn.Parameters)
                p.Visible = false;
            qtn.initData(qtnrID, qtnrTitle);
            documentViewer1.DocumentSource = qtn;
            qtn.CreateDocument();
        }
    }
}