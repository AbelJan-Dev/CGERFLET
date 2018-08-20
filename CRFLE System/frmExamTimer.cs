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
    public partial class frmExamTimer : Form
    {
        private static int num = 0;
        private static int max = 120;

        public frmExamTimer()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int min = max / 60;
            int sec = max % 60;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.label1.Text == "0" && this.label3.Text == "0")
            {
                timer1.Stop();
                MessageBox.Show("Time's up!");
            }
            else
            {
                num++;

                int min = (max - num) / 60;
                int sec = (max - num) % 60;
                this.label1.Text = Convert.ToString(min);
                this.label3.Text = Convert.ToString(sec);
            }
        }

        private void frmStudentExam_Load(object sender, EventArgs e)
        {
            int min = max / 60;
            int sec = max % 60;
            this.label1.Text = Convert.ToString(min);
            this.label3.Text = Convert.ToString(sec);
        }
    }
}
