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
    public partial class frmStudentExam : Form
    {
        public static int examID;
        public static int qtnrID;
        public static int duration;

        public static int score;

        public static String[] studAnswers;
        public static String[] answerKey;
        public static int[] itemID;
        public static String[] itemCategory;

        public static String[] questions;
        public static String[] correctAns;
        public static String[] yourAnswer;
        public static String[] explanations;

        private static int num = 0;

        public frmStudentExam()
        {
            InitializeComponent();
        }

        private void frmStudentExam_Load(object sender, EventArgs e)
        {
            new dbModule().populateExamModule(this.flowLayoutPanel1, qtnrID);

            this.flowLayoutPanel1.Enabled = false;
            this.btnStart.Enabled = true;

            int min = duration / 60;
            int sec = duration % 60;

            if (min.ToString().Length == 1)
            {
                this.lblMin.Text = "0" + Convert.ToString(min);
            }
            else
            {
                this.lblMin.Text = Convert.ToString(min);
            }

            if (sec.ToString().Length == 1)
            {
                this.lblSec.Text = "0" + Convert.ToString(sec);
            }
            else
            {
                this.lblSec.Text = Convert.ToString(sec);
            }

            this.lblMaxItems.Text = answerKey.Count().ToString();

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < answerKey.Count(); i++)
            {
                if (studAnswers[i] == answerKey[i])
                {
                    score++;
                }
            }

            MessageBox.Show(score.ToString());
            score = 0;
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Enabled = true;
            score = 0;
            int min = duration / 60;
            int sec = duration % 60;
            examTimer.Enabled = true;
            examTimer.Start();

            this.btnStart.Enabled = false;
        }

        private void examTimer_Tick(object sender, EventArgs e)
        {
            if (this.lblMin.Text == "00" && this.lblSec.Text == "00")
            {
                examTimer.Stop();
                getScore();
                //new dbModule().recordExamResult(examID, frmLogin.activeUserID, score, answerKey.Count());

                frmShowExamResult.examID = examID;
                frmShowExamResult.currentScore = Convert.ToDecimal(score);
                frmShowExamResult.currentTotal = Convert.ToDecimal(answerKey.Count());
                new frmShowExamResult().ShowDialog();

                num = 0;

                this.Close();
            }
            else
            {
                num++;

                int min = (duration - num) / 60;
                int sec = (duration - num) % 60;
                if (min.ToString().Length == 1)
                {
                    this.lblMin.Text = "0" + Convert.ToString(min);
                }
                else
                {
                    this.lblMin.Text = Convert.ToString(min);
                }

                if (sec.ToString().Length == 1)
                {
                    this.lblSec.Text = "0" + Convert.ToString(sec);
                }
                else
                {
                    this.lblSec.Text = Convert.ToString(sec);
                }

                if (min == 0 && sec <= 10)
                {
                    this.lblMin.ForeColor = Color.Red;
                    this.label2.ForeColor = Color.Red;
                    this.lblSec.ForeColor = Color.Red;
                }
                else
                {
                    this.lblMin.ForeColor = Color.Black;
                    this.label2.ForeColor = Color.Black;
                    this.lblSec.ForeColor = Color.Black;
                }
            }
        }

        private void getScore()
        {
            for (int i = 0; i < answerKey.Count(); i++)
            {
                if (studAnswers[i] == answerKey[i])
                {
                    score++;
                    setDifficultyIndex(itemCategory[i], true);
                    //new dbModule().storeAnsweredItemLog(frmLogin.activeUserID, examID, itemID[i], 1);
                }
                else
                {
                    setDifficultyIndex(itemCategory[i], false);
                    //new dbModule().storeAnsweredItemLog(frmLogin.activeUserID, examID, itemID[i], 0);
                }
            }
        }

        private void setDifficultyIndex(String category, Boolean corw)
        {
            if (corw == true)
            {
                if (category == "English")
                {
                    frmShowExamResult.englishC++;
                }
                else if (category == "Filipino")
                {
                    frmShowExamResult.filipinoC++;
                }
                else if (category == "ICT")
                {
                    frmShowExamResult.ictC++;
                }
                else if (category == "Math")
                {
                    frmShowExamResult.mathC++;
                }
                else if (category == "Science")
                {
                    frmShowExamResult.sciC++;
                }
                else if (category == "Social Science")
                {
                    frmShowExamResult.ssciC++;
                }
            }
            else if (corw == false)
            {
                if (category == "English")
                {
                    frmShowExamResult.englishW++;
                }
                else if (category == "Filipino")
                {
                    frmShowExamResult.filipinoW++;
                }
                else if (category == "ICT")
                {
                    frmShowExamResult.ictW++;
                }
                else if (category == "Math")
                {
                    frmShowExamResult.mathW++;
                }
                else if (category == "Science")
                {
                    frmShowExamResult.sciW++;
                }
                else if (category == "Social Science")
                {
                    frmShowExamResult.ssciW++;
                }
            }
        }

        private string getTotalAnsweredItems()
        {
            int totalAnsweredItems = 0;

            for (int i = 0; i < answerKey.Count(); i++)
            {
                if (studAnswers[i] != null)
                {
                    totalAnsweredItems++;
                }
            }
            return totalAnsweredItems.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblAnsweredItems.Text = getTotalAnsweredItems();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (this.lblAnsweredItems.Text == this.lblMaxItems.Text)
            {
                num = duration - 1;
            }
            else
            {
                MessageBox.Show("There are items left unanswered.");
            }
            
        }
    }
}
