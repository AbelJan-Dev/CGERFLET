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
    public partial class frmShowExamResult : Form
    {
        public static int examID;
        public static int timeFinished;
        public static bool hasPreviousExams;
        public static FlowLayoutPanel flp;

        public static Decimal currentScore;
        public static Decimal currentTotal;
        public static Decimal previousScore;
        public static Decimal previousTotal;

        public static Decimal englishC;
        public static Decimal englishW;
        public static Decimal filipinoC;
        public static Decimal filipinoW;
        public static Decimal ictC;
        public static Decimal ictW;
        public static Decimal mathC;
        public static Decimal mathW;
        public static Decimal ssciC;
        public static Decimal ssciW;
        public static Decimal sciC;
        public static Decimal sciW;

        public frmShowExamResult()
        {
            InitializeComponent();
        }

        private void frmShowExamResult_Load(object sender, EventArgs e)
        {
            new dbModule().checkIfFirstExam(frmLogin.activeUserID);

            if (hasPreviousExams == true)
            {
                new dbModule().getLastRecordedExams(frmLogin.activeUserID);

                showPreviousandCurrentLabels();

                decimal pctgCur = decimal.Round((currentScore / currentTotal) * 100, 2);
                decimal pctgPrev = decimal.Round((previousScore / previousTotal) * 100, 2);

                if (pctgCur > pctgPrev)
                {
                    this.lblPctgCurrent.ForeColor = Color.DarkGreen;
                    this.lblPctgPrevious.ForeColor = Color.Red;
                }
                else if (pctgCur == pctgPrev)
                {
                    this.lblPctgCurrent.ForeColor = Color.Navy;
                    this.lblPctgPrevious.ForeColor = Color.Navy;
                }
                else if (pctgCur < pctgPrev)
                {
                    this.lblPctgCurrent.ForeColor = Color.Red;
                    this.lblPctgPrevious.ForeColor = Color.DarkGreen;
                }

                this.lblScorePrevious.Text = previousScore.ToString() + "/" + previousTotal.ToString();
                this.lblPctgPrevious.Text = pctgPrev.ToString() + "%";
                this.lblScoreCurrent.Text = currentScore.ToString() + "/" + currentTotal.ToString();
                this.lblPctgCurrent.Text = pctgCur.ToString() + "%";
            }
            else if(hasPreviousExams == false)
            {
                showCurrentLabelsOnly();

                decimal pctgCur = decimal.Round((currentScore / currentTotal) * 100, 2);

                this.lblScore.Text = currentScore.ToString() + "/" + currentTotal.ToString();
                this.lblPctg.Text = pctgCur.ToString() + "%";
            }
            
            this.lblTimeFinished.Text = getTimeFinished(timeFinished);

            showDifficultyIndex();
        }

        private void showPreviousandCurrentLabels()
        {
            this.label1.Visible = true;
            this.label4.Visible = true;
            this.lblScorePrevious.Visible = true;
            this.lblPctgPrevious.Visible = true;
            this.lblScoreCurrent.Visible = true;
            this.lblPctgCurrent.Visible = true;

            this.lblCurrent2.Visible = false;
            this.lblScore.Visible = false;
            this.lblPctg.Visible = false;
        }

        private void showCurrentLabelsOnly()
        {
            this.label1.Visible = false;
            this.label4.Visible = false;
            this.lblScorePrevious.Visible = false;
            this.lblPctgPrevious.Visible = false;
            this.lblScoreCurrent.Visible = false;
            this.lblPctgCurrent.Visible = false;

            this.lblCurrent2.Visible = true;
            this.lblScore.Visible = true;
            this.lblPctg.Visible = true;
        }

        private string getTimeFinished(int timeFinished)
        {

            int min = timeFinished / 60;
            int sec = timeFinished % 60;

            String text = "You finished the exam in " + min.ToString() + "m &" + sec.ToString() + "s.";
            return text;
        }

        private void showDifficultyIndex()
        {
            if (englishC == 0 && englishW == 0)
            {
                this.lblEnglish.Hide();
                this.rightEng.Hide();
                this.pctEng.Hide();
            }
            else
            {
                decimal total = englishC + englishW;
                decimal pct = decimal.Round((englishW / total) * 100, 2);
                this.rightEng.Text = Convert.ToString(englishC + "/" + total);
                this.pctEng.Text = pct.ToString() + "%";
            }

            if (filipinoC == 0 && filipinoW == 0)
            {
                this.lblFilipino.Hide();
                this.rightFil.Hide();
                this.pctFil.Hide();
            }
            else
            {
                decimal total = filipinoC + filipinoW;
                decimal pct = decimal.Round((filipinoW / total) * 100, 2);
                this.rightFil.Text = Convert.ToString(filipinoC + "/" + total);
                this.pctFil.Text = pct.ToString() + "%";
            }

            if (ictC == 0 && ictW == 0)
            {
                this.lblICT.Hide();
                this.rightICT.Hide();
                this.pctICT.Hide();
            }
            else
            {
                decimal total = ictC + ictW;
                decimal pct = decimal.Round((ictW / total) * 100, 2);
                this.rightICT.Text = Convert.ToString(ictC + "/" + total);
                this.pctICT.Text = pct.ToString() + "%";
            }

            if (mathC == 0 && mathW == 0)
            {
                this.lblMath.Hide();
                this.rightMath.Hide();
                this.pctMath.Hide();
            }
            else
            {
                decimal total = mathC + mathW;
                decimal pct = decimal.Round((mathW / total) * 100, 2);
                this.rightMath.Text = Convert.ToString(mathC + "/" + total);
                this.pctMath.Text = pct.ToString() + "%";
            }

            if (sciC == 0 && sciW == 0)
            {
                this.lblScience.Hide();
                this.rightSci.Hide();
                this.pctSci.Hide();
            }
            else
            {
                decimal total = sciC + sciW;
                decimal pct = decimal.Round((sciW / total) * 100, 2);
                this.rightSci.Text = Convert.ToString(sciC + "/" + total);
                this.pctSci.Text = pct.ToString() + "%";
            }

            if (ssciC == 0 && ssciW == 0)
            {
                this.lblSocialScience.Hide();
                this.rightSsci.Hide();
                this.pctSsci.Hide();
            }
            else
            {
                decimal total = ssciC + ssciW;
                decimal pct = decimal.Round((ssciW / total) * 100, 2);
                this.rightSsci.Text = Convert.ToString(ssciC + "/" + total);
                this.pctSsci.Text = pct.ToString() + "%";
            }
        }

        private void btnViewAnswers_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmShowAnswers().ShowDialog();
        }

        private void frmShowExamResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            flp.Controls.Clear();
        }
    }
}
