using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRFLE_System
{
    public partial class ucQuestionnaireItem : UserControl
    {
        public static string letter;
        public static string answer;

        public ucQuestionnaireItem()
        {
            InitializeComponent();
        }

        private void radioA_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioA.Checked == true)
            {
                this.radioB.Checked = false;
                this.radioC.Checked = false;
                this.radioD.Checked = false;

                letter = "A";
                answer = this.choice1.RtfText.ToString();

                frmStudentMain.studAnswers[Convert.ToInt32(this.lblNo.Text.TrimEnd('.')) - 1] = letter;
                frmStudentMain.yourAnswer[Convert.ToInt32(this.lblNo.Text.TrimEnd('.')) - 1] = answer;
                //frmStudentExam.correctAns[Convert.ToInt32(this.lblNo.Text.TrimEnd('.')) - 1] = correctAnswer;
            }
        }

        private void radioB_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioB.Checked == true)
            {
                this.radioA.Checked = false;
                this.radioC.Checked = false;
                this.radioD.Checked = false;

                letter = "B";
                answer = this.choice2.RtfText.ToString();

                frmStudentMain.studAnswers[Convert.ToInt32(this.lblNo.Text.TrimEnd('.')) - 1] = letter;
                frmStudentMain.yourAnswer[Convert.ToInt32(this.lblNo.Text.TrimEnd('.')) - 1] = answer;
                //frmStudentExam.correctAns[Convert.ToInt32(this.lblNo.Text.TrimEnd('.')) - 1] = correctAnswer;
            }
        }

        private void radioC_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioC.Checked == true)
            {
                this.radioB.Checked = false;
                this.radioA.Checked = false;
                this.radioD.Checked = false;

                letter = "C";
                answer = this.choice3.RtfText.ToString();

                frmStudentMain.studAnswers[Convert.ToInt32(this.lblNo.Text.TrimEnd('.')) - 1] = letter;
                frmStudentMain.yourAnswer[Convert.ToInt32(this.lblNo.Text.TrimEnd('.')) - 1] = answer;
                //frmStudentExam.correctAns[Convert.ToInt32(this.lblNo.Text.TrimEnd('.')) - 1] = correctAnswer;
            }
        }

        private void radioD_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioD.Checked == true)
            {
                this.radioB.Checked = false;
                this.radioC.Checked = false;
                this.radioA.Checked = false;

                letter = "D";
                answer = this.choice4.RtfText.ToString();

                frmStudentMain.studAnswers[Convert.ToInt32(this.lblNo.Text.TrimEnd('.')) - 1] = letter;
                frmStudentMain.yourAnswer[Convert.ToInt32(this.lblNo.Text.TrimEnd('.')) - 1] = answer;
                //frmStudentExam.correctAns[Convert.ToInt32(this.lblNo.Text.TrimEnd('.')) - 1] = correctAnswer;
            }
        }

    }
}
