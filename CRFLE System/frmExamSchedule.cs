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
    public partial class frmExamSchedule : Form
    {
        public static DataGridView dg;
        public static String refreshquery;

        public static string checkconflict;

        public frmExamSchedule()
        {
            InitializeComponent();
        }

        private void frmExamSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQuestionnaires.tblQuestionnaires' table. You can move, or remove it, as needed.
            this.tblQuestionnairesTableAdapter.Fill(this.dsQuestionnaires.tblQuestionnaires);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //MessageBox.Show(CRFLE_System.Properties.Settings.Default.dbCRFLEConnectionString);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;

            int duration = Convert.ToInt32(this.durationExam.TimeSpan.TotalSeconds);
            int qtnrID = Convert.ToInt32(this.cmbQuestionnaire.SelectedValue);

            if (this.dateExam.Text == "" || this.timeExam.Text == "" || this.durationExam.Text == "")
            {
                hidepanels();
                this.lblError.Text = "Oops! Please supply all required data.";
                this.panelError.Show();

                wait();
                hidepanels();
            }
            else if(this.dateExam.Time.Date + this.timeExam.Time.TimeOfDay < datetime)
            {
                hidepanels();
                this.lblError.Text = "Date and time set already passed.";
                this.panelError.Show();

                wait();
                hidepanels();
            }
            else
            {
                new dbModule().checkConflictSchedule(Convert.ToDateTime(getExamSchedule()));
                if (checkconflict == "false")
                {
                    hidepanels();
                    this.panelSuccess.Show();
                    new dbModule().setExamSchedule(getExamSchedule(), duration, qtnrID);
                    new dbModule().refreshDataGrid(dg, refreshquery);

                    wait();
                    hidepanels();
                    this.Close();
                }
                else
                {
                    hidepanels();
                    this.lblError.Text = "Conflict with another schedule.";
                    this.panelError.Show();

                    wait();
                    hidepanels();
                }
            }
            
        }

        private string getExamSchedule()
        {
            String sched = Convert.ToString(this.dateExam.Time.Year) + "/" + Convert.ToString(this.dateExam.Time.Month) + "/" + Convert.ToString(this.dateExam.Time.Day) + " " + this.timeExam.Text;
            
            return sched;            
        }

        private void hidepanels()
        {
            this.panelError.Hide();
            this.panelSuccess.Hide();
        }

        private void wait()
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
            });
            t.Wait();
        }
    }
}
