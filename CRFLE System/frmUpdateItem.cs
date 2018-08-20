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
    public partial class frmUpdateItem : DevExpress.XtraEditors.XtraForm
    {
        public static DataGridView dg;
        public static string query;

        public static int id;
        public static string question;
        public static string explanation;
        public static string answer;
        public static string choice1;
        public static string choice2;
        public static string choice3;
        public static string choice4;

        private static int val1;
        private static int val2;
        private static int val3;
        private static int val4;

        public frmUpdateItem()
        {
            InitializeComponent();
        }

        private void frmUpdateItem_Load(object sender, EventArgs e)
        {
            this.rtQuestion.RtfText = question;
            this.rtExplanation.RtfText = explanation;
            this.txtChoice1.Text = choice1;
            this.txtChoice2.Text = choice2;
            this.txtChoice3.Text = choice3;
            this.txtChoice4.Text = choice4;

            if (this.txtChoice1.Text == answer)
            {
                this.flag1.Checked = true;
            }
            else if (this.txtChoice2.Text == answer)
            {
                this.flag2.Checked = true;
            }
            else if (this.txtChoice3.Text == answer)
            {
                this.flag3.Checked = true;
            }
            else if (this.txtChoice4.Text == answer)
            {
                this.flag4.Checked = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            checkflags();

            if (this.rtQuestion.Text == "" || this.txtChoice1.Text == "" || this.txtChoice2.Text == "" || this.txtChoice3.Text == "" || this.txtChoice4.Text == "")
            {
                hidepanels();
                this.panelErrorQuestion.Show();
            }
            else
            {
                hidepanels();
                new dbModule().updateItem(id, this.rtQuestion.Text, this.rtQuestion.RtfText, this.rtExplanation.Text, this.rtExplanation.RtfText, this.txtChoice1.Text, this.txtChoice2.Text, this.txtChoice3.Text, this.txtChoice4.Text, val1, val2, val3, val4);
                new dbModule().refreshDataGrid(dg, query);
                this.panelUpdated.Show();

                //delay to hide 'successfully saved' prompt
                var t = Task.Run(async delegate
                {
                    await Task.Delay(TimeSpan.FromSeconds(1.5));
                });
                t.Wait();

                //execute after delay
                this.Close();
            }
            
        }

        private void hidepanels()
        {
            this.panelErrorQuestion.Hide();
            this.panelUpdated.Hide();
        }

        private void checkflags()
        {
            if (this.flag1.Checked == true)
            {
                val1 = 1;
                val2 = 0;
                val3 = 0;
                val4 = 0;
            }
            else if (this.flag2.Checked == true)
            {
                val1 = 0;
                val2 = 1;
                val3 = 0;
                val4 = 0;
            }
            else if (this.flag3.Checked == true)
            {
                val1 = 0;
                val2 = 0;
                val3 = 1;
                val4 = 0;
            }
            else if (this.flag4.Checked == true)
            {
                val1 = 0;
                val2 = 0;
                val3 = 0;
                val4 = 1;
            }
        }
    }
}