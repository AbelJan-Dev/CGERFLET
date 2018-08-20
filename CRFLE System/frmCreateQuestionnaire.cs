using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRFLE_System
{
    public partial class frmCreateQuestionnaire : Form
    {
        //set numericupdown maxvalue
        public static int ee;
        public static int en;
        public static int eh;
        public static int fe;
        public static int fn;
        public static int fh;
        public static int me;
        public static int mn;
        public static int mh;
        public static int se;
        public static int sn;
        public static int sh;
        public static int sse;
        public static int ssn;
        public static int ssh;
        public static int ice;
        public static int icn;
        public static int ich;
        
        public static int setcount;
        public static int totalVal;

        public static DataGridView dg;
        public static String refreshquery;

        public frmCreateQuestionnaire()
        {
            InitializeComponent();
        }

        private void chkEng_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkEng.Checked == true)
            {
                this.nmEngEasy.Enabled = true;
                this.nmEngNormal.Enabled = true;
                this.nmEngHard.Enabled = true;
                getNMCount();
            }
            else
            {
                this.nmEngEasy.Enabled = false;
                this.nmEngNormal.Enabled = false;
                this.nmEngHard.Enabled = false;
                getNMCount();
            }
        }

        private void chkFil_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkFil.Checked == true)
            {
                this.nmFilEasy.Enabled = true;
                this.nmFilNormal.Enabled = true;
                this.nmFilHard.Enabled = true;
                getNMCount();
            }
            else
            {
                this.nmFilEasy.Enabled = false;
                this.nmFilNormal.Enabled = false;
                this.nmFilHard.Enabled = false;
                getNMCount();
            }
        }

        private void chkMath_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkMath.Checked == true)
            {
                this.nmMathEasy.Enabled = true;
                this.nmMathNormal.Enabled = true;
                this.nmMathHard.Enabled = true;
                getNMCount();
            }
            else
            {
                this.nmMathEasy.Enabled = false;
                this.nmMathNormal.Enabled = false;
                this.nmMathHard.Enabled = false;
                getNMCount();
            }
        }

        private void chkSci_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkSci.Checked == true)
            {
                this.nmSciEasy.Enabled = true;
                this.nmSciNormal.Enabled = true;
                this.nmSciHard.Enabled = true;
                getNMCount();
            }
            else
            {
                this.nmSciEasy.Enabled = false;
                this.nmSciNormal.Enabled = false;
                this.nmSciHard.Enabled = false;
                getNMCount();
            }
        }

        private void nmEngEasy_ValueChanged(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void getNMCount()
        {
            int subValEng = 0;
            int subValFil = 0;
            int subValMath = 0;
            int subValSci = 0;
            int subvalSocSci = 0;
            int subValICT = 0;

            if (this.chkEng.Checked == true)
            {
                subValEng = Convert.ToInt32(this.nmEngEasy.Value + this.nmEngNormal.Value + this.nmEngHard.Value);
            }

            if (this.chkFil.Checked == true)
            {
                subValFil = Convert.ToInt32(this.nmFilEasy.Value + this.nmFilNormal.Value + this.nmFilHard.Value);
            }

            if (this.chkMath.Checked == true)
            {
                subValMath = Convert.ToInt32(this.nmMathEasy.Value + this.nmMathNormal.Value + this.nmMathHard.Value);
            }

            if (this.chkSci.Checked == true)
            {
                subValSci = Convert.ToInt32(this.nmSciEasy.Value + this.nmSciNormal.Value + this.nmSciHard.Value);
            }

            if (this.chkSocSci.Checked == true)
            {
                subvalSocSci = Convert.ToInt32(this.nmSocSciEasy.Value + this.nmSocSciNormal.Value + this.nmSocSciHard.Value);
            }

            if (this.chkICT.Checked == true)
            {
                subValICT = Convert.ToInt32(this.nmICTEasy.Value + this.nmICTNormal.Value + this.nmICTHard.Value);
            }

            totalVal = subValEng + subValFil + subValMath + subValSci + subvalSocSci + subValICT;

            this.txtTotal.Text = Convert.ToString(totalVal);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            String title = this.txtTitle.Text.Trim();
            String description = this.txtDescription.Text.Trim();
            int totalitems = Convert.ToInt32(this.txtTotal.Text);
            int ee = Convert.ToInt32(this.nmEngEasy.Value);
            int en = Convert.ToInt32(this.nmEngNormal.Value);
            int eh = Convert.ToInt32(this.nmEngHard.Value);
            int fe = Convert.ToInt32(this.nmFilEasy.Value);
            int fn = Convert.ToInt32(this.nmFilNormal.Value);
            int fh = Convert.ToInt32(this.nmFilHard.Value);
            int me = Convert.ToInt32(this.nmMathEasy.Value);
            int mn = Convert.ToInt32(this.nmMathNormal.Value);
            int mh = Convert.ToInt32(this.nmMathHard.Value);
            int se = Convert.ToInt32(this.nmSciEasy.Value);
            int sn = Convert.ToInt32(this.nmSciNormal.Value);
            int sh = Convert.ToInt32(this.nmSciHard.Value);
            int sse = Convert.ToInt32(this.nmSocSciEasy.Value);
            int ssn = Convert.ToInt32(this.nmSocSciNormal.Value);
            int ssh = Convert.ToInt32(this.nmSocSciHard.Value);
            int ice = Convert.ToInt32(this.nmICTEasy.Value);
            int icn = Convert.ToInt32(this.nmICTNormal.Value);
            int ich = Convert.ToInt32(this.nmICTHard.Value);

            if (this.txtTitle.Text == "" || this.txtDescription.Text == "")
            {
                hidePanels();
                this.panelDetails.Show();
            }
            else if (this.txtTotal.Text == "" || this.txtTotal.Text == "0")
            {
                hidePanels();
                this.panelCount.Show();
            }
            else
            {
                hidePanels();
                this.panelSaved.Show();

                new dbModule().createQuestionnaire(title, description, frmLogin.activeUserID, totalitems, ee, en, eh, fe, fn, fh, me, mn, mh, se, sn, sh, sse, ssn, ssh, ice, icn, ich);
                new dbModule().refreshDataGrid(dg, refreshquery);
                //delay to hide 'successfully saved' prompt
                var t = Task.Run(async delegate
                {
                    await Task.Delay(TimeSpan.FromSeconds(1.5));
                });
                t.Wait();
                //execute after delay
                hidePanels();
                clearFields();
                resetValues();
            }
        }

        private void clearFields()
        {
            this.txtTitle.Text = "";
            this.txtDescription.Text = "";
        }

        private void hidePanels()
        {
            this.panelDetails.Hide();
            this.panelCount.Hide();
            this.panelSaved.Hide();
        }

        private void frmCreateQuestionnaire_Load(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void nmEngNormal_ValueChanged(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void nmEngHard_ValueChanged(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void nmFilEasy_ValueChanged(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void nmFilNormal_ValueChanged(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void nmFilHard_ValueChanged(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void nmMathEasy_ValueChanged(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void nmMathNormal_ValueChanged(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void nmMathHard_ValueChanged(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void nmSciEasy_ValueChanged(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void nmSciNormal_ValueChanged(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void nmSciHard_ValueChanged(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void nmMaxItems_ValueChanged(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetValues();
        }

        private void resetValues()
        {
            this.nmEngEasy.Value = 0;
            this.nmEngNormal.Value = 0;
            this.nmEngHard.Value = 0;
            this.nmFilEasy.Value = 0;
            this.nmFilNormal.Value = 0;
            this.nmFilHard.Value = 0;
            this.nmMathEasy.Value = 0;
            this.nmMathNormal.Value = 0;
            this.nmMathHard.Value = 0;
            this.nmSciEasy.Value = 0;
            this.nmSciNormal.Value = 0;
            this.nmSciHard.Value = 0;
            this.nmSocSciEasy.Value = 0;
            this.nmSocSciNormal.Value = 0;
            this.nmSocSciHard.Value = 0;
            this.nmICTEasy.Value = 0;
            this.nmICTNormal.Value = 0;
            this.nmICTHard.Value = 0;
        }

        private void frmCreateQuestionnaire_Load_1(object sender, EventArgs e)
        {
            new dbModule().getCatDiffCount();

            this.nmEngEasy.Maximum = ee;
            this.nmEngNormal.Maximum = en;
            this.nmEngHard.Maximum = eh;
            this.nmFilEasy.Maximum = fe;
            this.nmFilNormal.Maximum = fn;
            this.nmFilHard.Maximum = fh;
            this.nmMathEasy.Maximum = me;
            this.nmMathNormal.Maximum = mn;
            this.nmMathHard.Maximum = mh;
            this.nmSciEasy.Maximum = se;
            this.nmSciNormal.Maximum = sn;
            this.nmSciHard.Maximum = sh;
            this.nmSocSciEasy.Maximum = sse;
            this.nmSocSciNormal.Maximum = ssn;
            this.nmSocSciHard.Maximum = ssh;
            this.nmICTEasy.Maximum = ice;
            this.nmICTNormal.Maximum = icn;
            this.nmICTHard.Maximum = ich;
        }

        private void chkSocSci_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkSocSci.Checked == true)
            {
                this.nmSocSciEasy.Enabled = true;
                this.nmSocSciNormal.Enabled = true;
                this.nmSocSciHard.Enabled = true;
                getNMCount();
            }
            else
            {
                this.nmSocSciEasy.Enabled = false;
                this.nmSocSciNormal.Enabled = false;
                this.nmSocSciHard.Enabled = false;
                getNMCount();
            }
        }

        private void chkICT_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkICT.Checked == true)
            {
                this.nmICTEasy.Enabled = true;
                this.nmICTNormal.Enabled = true;
                this.nmICTHard.Enabled = true;
                getNMCount();
            }
            else
            {
                this.nmICTEasy.Enabled = false;
                this.nmICTNormal.Enabled = false;
                this.nmICTHard.Enabled = false;
                getNMCount();
            }
        }

        private void nmICTEasy_ValueChanged(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void nmICTNormal_ValueChanged(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void nmICTHard_ValueChanged(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void nmSocSciEasy_ValueChanged(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void nmSocSciNormal_ValueChanged(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void nmSocSciHard_ValueChanged(object sender, EventArgs e)
        {
            getNMCount();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTotal.Text != "0")
            {
                hidePanels();
            }
        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            this.txtTitle.Text = textInfo.ToLower(this.txtTitle.Text);
            this.txtTitle.Text = textInfo.ToTitleCase(this.txtTitle.Text);
        }

    }
}
