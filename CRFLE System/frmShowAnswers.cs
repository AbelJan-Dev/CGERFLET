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
    public partial class frmShowAnswers : Form
    {
        private static int num = 0;

        public frmShowAnswers()
        {
            InitializeComponent();
        }

        private void frmShowAnswers_Load(object sender, EventArgs e)
        {
            this.btnPrevious.Enabled = false;

            this.lblNo.Text = Convert.ToString(num + 1) + ".";
            this.lblQtn.RtfText = frmStudentMain.questions[0];
            this.lblYourAnswer.RtfText = frmStudentMain.yourAnswer[0];
            this.lblCorrectAnswer.Text = frmStudentMain.correctAns[0];
            this.lblYourLetter.Text = frmStudentMain.studAnswers[0] + ".";
            this.lblCorrectLetter.Text = frmStudentMain.answerKey[0] + ".";
            this.lblExplanation.Text = frmStudentMain.explanations[0];

            if (this.lblExplanation.Text == "")
            {
                this.lblExplanation.Text = "No explanation available.";
            }

            if (this.lblYourLetter.Text == this.lblCorrectLetter.Text)
            {
                this.lblCorrectWrong.Text = "Correct!";
                this.lblCorrectWrong.ForeColor = Color.DarkGreen;
            }
            else
            {
                this.lblCorrectWrong.Text = "Wrong!";
                this.lblCorrectWrong.ForeColor = Color.Red;
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            num--;
            this.btnNext.Enabled = true;

            if (num <= 0)
            {
                num = 0;
                this.btnPrevious.Enabled = false;
            }

            this.lblNo.Text = Convert.ToString(num + 1) + ".";
            this.lblQtn.RtfText = frmStudentMain.questions[num];
            this.lblYourAnswer.RtfText = frmStudentMain.yourAnswer[num];
            this.lblCorrectAnswer.Text = frmStudentMain.correctAns[num];
            this.lblYourLetter.Text = frmStudentMain.studAnswers[num] + ".";
            this.lblCorrectLetter.Text = frmStudentMain.answerKey[num] + ".";
            this.lblExplanation.Text = frmStudentMain.explanations[num];

            if (this.lblExplanation.Text == "")
            {
                this.lblExplanation.Text = "No explanation available.";
            }

            if (this.lblYourLetter.Text == this.lblCorrectLetter.Text)
            {
                this.lblCorrectWrong.Text = "Correct!";
                this.lblCorrectWrong.ForeColor = Color.DarkGreen;
            }
            else
            {
                this.lblCorrectWrong.Text = "Wrong!";
                this.lblCorrectWrong.ForeColor = Color.Red;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            num++;
            this.btnPrevious.Enabled = true;

            if (num >= frmStudentMain.questions.Count() - 1)
            {
                num = frmStudentMain.questions.Count() - 1;
                this.btnNext.Enabled = false;
            }

            this.lblNo.Text = Convert.ToString(num + 1) + ".";
            this.lblQtn.RtfText = frmStudentMain.questions[num];
            this.lblYourAnswer.RtfText = frmStudentMain.yourAnswer[num];
            this.lblCorrectAnswer.Text = frmStudentMain.correctAns[num];
            this.lblYourLetter.Text = frmStudentMain.studAnswers[num] + ".";
            this.lblCorrectLetter.Text = frmStudentMain.answerKey[num] + ".";
            this.lblExplanation.Text = frmStudentMain.explanations[num];

            if (this.lblExplanation.Text == "")
            {
                this.lblExplanation.Text = "No explanation available.";
            }

            if (this.lblYourLetter.Text == this.lblCorrectLetter.Text)
            {
                this.lblCorrectWrong.Text = "Correct!";
                this.lblCorrectWrong.ForeColor = Color.DarkGreen;
            }
            else
            {
                this.lblCorrectWrong.Text = "Wrong!";
                this.lblCorrectWrong.ForeColor = Color.Red;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
