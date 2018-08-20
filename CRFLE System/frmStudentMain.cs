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
    public partial class frmStudentMain : Form
    {
        public static DateTime now;
        public static bool isTakingExam;
        public static bool isFinished;

        public static DateTime nextExam;
        public static int duration;
        public static int examID;
        public static int qtnrID;

        ////// E X A M I N A T I O N //////
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
        public static int flowLayoutScroll = 0;

        public frmStudentMain()
        {
            InitializeComponent();
        }

        private void frmStudentMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            new frmLogin().Show();

        }

        private void acdnExamination_Click(object sender, EventArgs e)
        {
            new dbModule().checkForExam();
            this.scheduleChecker.Start();

            if (nextExam == Convert.ToDateTime("01/01/0001 12:00:00 AM"))
            {
                MessageBox.Show("There is no upcoming examination.");
            }
            else if (now.CompareTo(nextExam) == 1 && now.CompareTo(nextExam.AddSeconds(duration)) == -1)
            {
                if (MessageBox.Show("There is an ongoing examination. Do you wish to proceed?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.panelExamination.Show();
                    startExamination();
                }
            }
        }

        private void frmStudentMain_Load(object sender, EventArgs e)
        {
            dockPanels();
            hidePanels();

            this.acdnDashboard.Appearance.Normal.BackColor = Color.White;
            this.acdnDashboard.Appearance.Normal.ForeColor = Color.Navy;
            this.dashboardViewer1.DashboardSource = "..\\Dashboard Designs\\Dashboard Student.xml";
            this.panelDashboard.Show();

            isTakingExam = false;

            new dbModule().checkForExam();
            this.scheduleChecker.Start();
        }

        private void scheduleChecker_Tick(object sender, EventArgs e)
        {
            now = DateTime.Now.Date + DateTime.Now.TimeOfDay;

            if (nextExam != Convert.ToDateTime("01/01/0001 12:00:00 AM"))
            {
                if (now.CompareTo(nextExam.AddSeconds(-10)) == 1 && now.CompareTo(nextExam) == -1)
                {
                    this.scheduleChecker.Stop();

                    if (MessageBox.Show("An examination is about to start. Do you wish to proceed?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        hidePanels();
                        this.panelExamination.Show();
                        startExamination();
                    }
                }
                else if (now.CompareTo(nextExam) == 1 && now.CompareTo(nextExam.AddSeconds(duration)) == -1)
                {
                    this.scheduleChecker.Stop();

                    if (MessageBox.Show("There is an ongoing examination. Do you wish to proceed?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        hidePanels();
                        this.panelExamination.Show();
                        startExamination();
                    }
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startExamination()
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

        private void dockPanels()
        {
            this.panelExamination.Dock = DockStyle.Fill;
            this.panelDashboard.Dock = DockStyle.Fill;
        }

        private void hidePanels()
        {
            this.panelExamination.Hide();
            this.panelDashboard.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Enabled = true;
            isFinished = false;

            score = 0;
            int min = duration / 60;
            int sec = duration % 60;
            examTimer.Enabled = true;
            examTimer.Start();
            timer1.Enabled = true;
            timer1.Start();

            this.btnStart.Enabled = false;
            this.btnFinish.Enabled = true;
            this.btnDown.Enabled = true;
        }

        private void examTimer_Tick(object sender, EventArgs e)
        {
            if ((this.lblMin.Text == "00" && this.lblSec.Text == "00") || isFinished == true )
            {
                examTimer.Stop();
                timer1.Stop();
                getScore();
                new dbModule().recordExamResult(examID, frmLogin.activeUserID, score, answerKey.Count(), num);

                frmShowExamResult.examID = examID;
                frmShowExamResult.timeFinished = num;
                frmShowExamResult.flp = this.flowLayoutPanel1;
                frmShowExamResult.currentScore = Convert.ToDecimal(score);
                frmShowExamResult.currentTotal = Convert.ToDecimal(answerKey.Count());
                new frmShowExamResult().ShowDialog();

                num = 0;
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
                }
                else
                {
                    setDifficultyIndex(itemCategory[i], false);
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
                isFinished = true;
            }
            else
            {
                List<String> unansweredItems = new List<String>();
                
                for (int i = 0; i < studAnswers.Length; i++)
                {
                    if (studAnswers[i] == "" || studAnswers[i] == null)
                    {
                        //MessageBox.Show((i + 1).ToString());
                        unansweredItems.Add((i + 1).ToString());
                    }
                }

                frmUnansweredDialog uad = new frmUnansweredDialog(unansweredItems, this);
                uad.ShowDialog();

            }

        }

        private void acdnMyExams_Click(object sender, EventArgs e)
        {
            new frmStudentAccount().ShowDialog();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (flowLayoutScroll <= 0)
            {
                flowLayoutScroll = 0;
                this.btnUp.Enabled = false;
            }
            else
            {
                this.btnDown.Enabled = true;
                flowLayoutScroll--;
                int y = 0;
                for (int i = 0; i < flowLayoutScroll; i++)
                {
                    y += flowLayoutPanel1.Controls[i].Height + 6;
                }

                flowLayoutPanel1.AutoScrollPosition = new Point(0, y);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (flowLayoutScroll >= answerKey.Length - 1)
            {
                flowLayoutScroll = answerKey.Length - 1;
                this.btnDown.Enabled = false;
            }
            else
            {
                this.btnUp.Enabled = true;
                flowLayoutScroll++;
                int y = 0;
                for (int i = 0; i < flowLayoutScroll; i++)
                {
                    y += flowLayoutPanel1.Controls[i].Height + 6;
                }

                flowLayoutPanel1.AutoScrollPosition = new Point(0, y);
            }
        }
    }
}
