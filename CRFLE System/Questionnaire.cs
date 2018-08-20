using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CRFLE_System
{
    public partial class Questionnaire : DevExpress.XtraReports.UI.XtraReport
    {
        public Questionnaire()
        {
            InitializeComponent();
        }

        public void initData(int qtnrID, string qtnrTitle)
        {
            pQtnrID.Value = qtnrID;
            pQtnrTitle.Value = qtnrTitle;
        }
    }
}
