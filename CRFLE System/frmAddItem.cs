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
    public partial class frmAddItem : Form
    {
        public static DataGridView dg;
        public static string query;

        private int category;
        private String questionText;
        private String questionRTF;
        private String explanationText;
        private String explanationRTF;
        private String choice1;
        private String choice2;
        private String choice3;
        private String choice4;
        private int choiceflag1;
        private int choiceflag2;
        private int choiceflag3;
        private int choiceflag4;
        private String difficulty;

        public frmAddItem()
        {
            InitializeComponent();
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            this.tblCategoryTableAdapter.Fill(this.dsCategory.tblCategory);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            category = Convert.ToInt32(this.cmbCategory.SelectedValue);
            questionText = this.rtQuestion.Text.Trim();
            questionRTF = this.rtQuestion.RtfText.Trim();
            explanationText = this.rtExplanation.Text.Trim();
            explanationRTF = this.rtExplanation.RtfText.Trim();
            choice1 = this.txtChoice1.Text.Trim();
            choice2 = this.txtChoice2.Text.Trim();
            choice3 = this.txtChoice3.Text.Trim();
            choice4 = this.txtChoice4.Text.Trim();
            difficulty = this.cmbDifficulty.Text;

            getChoiceFlags();

            if (this.rtQuestion.Text == "" || this.txtChoice1.Text == "" || this.txtChoice2.Text == "" || this.txtChoice3.Text == "" || this.txtChoice4.Text == "" || this.cmbDifficulty.Text == "")
            {
                this.panelSaved.Hide();
                this.panelErrorQuestion.Show();
            }
            else
            {
                new dbModule().addItem(category, questionText, questionRTF, explanationText, explanationRTF, choice1, choice2, choice3, choice4, choiceflag1, choiceflag2, choiceflag3, choiceflag4, difficulty);
                new dbModule().refreshDataGrid(dg, query);
                this.panelErrorQuestion.Hide();
                this.panelSaved.Show();

                //delay to hide 'successfully saved' prompt
                var t = Task.Run(async delegate
                {
                    await Task.Delay(TimeSpan.FromSeconds(1.5));
                });
                t.Wait();
                //execute after delay
                clearItemFields();
                this.panelSaved.Hide();
            }
        }

        private void hidepanel()
        {
            this.panelSaved.Hide();
        }
        private void getChoiceFlags()
        {
            if (this.flag1.Checked == true)
            {
                choiceflag1 = 1;
                choiceflag2 = 0;
                choiceflag3 = 0;
                choiceflag4 = 0;
            }
            else if (this.flag2.Checked == true)
            {
                choiceflag1 = 0;
                choiceflag2 = 1;
                choiceflag3 = 0;
                choiceflag4 = 0;
            }
            else if (this.flag3.Checked == true)
            {
                choiceflag1 = 0;
                choiceflag2 = 0;
                choiceflag3 = 1;
                choiceflag4 = 0;
            }
            else if (this.flag4.Checked == true)
            {
                choiceflag1 = 0;
                choiceflag2 = 0;
                choiceflag3 = 0;
                choiceflag4 = 1;
            }
        }

        public void clearItemFields()
        {
            this.rtQuestion.Text = "";
            this.rtExplanation.Text = "";
            this.txtChoice1.Text = "";
            this.txtChoice2.Text = "";
            this.txtChoice3.Text = "";
            this.txtChoice4.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
            if (this.rtQuestion.Text != "" && this.txtChoice1.Text != "" && this.txtChoice2.Text != "" && this.txtChoice3.Text != "" && this.txtChoice4.Text != "")
            {
                this.panelErrorQuestion.Hide();
            }
        }

        private void txtExplanation_TextChanged(object sender, EventArgs e)
        {
            if (this.rtQuestion.Text != "" && this.txtChoice1.Text != "" && this.txtChoice2.Text != "" && this.txtChoice3.Text != "" && this.txtChoice4.Text != "")
            {
                this.panelErrorQuestion.Hide();
            }
        }

        private void txtChoice1_TextChanged(object sender, EventArgs e)
        {
            if (this.rtQuestion.Text != "" && this.txtChoice1.Text != "" && this.txtChoice2.Text != "" && this.txtChoice3.Text != "" && this.txtChoice4.Text != "")
            {
                this.panelErrorQuestion.Hide();
            }
        }

        private void txtChoice2_TextChanged(object sender, EventArgs e)
        {
            if (this.rtQuestion.Text != "" && this.txtChoice1.Text != "" && this.txtChoice2.Text != "" && this.txtChoice3.Text != "" && this.txtChoice4.Text != "")
            {
                this.panelErrorQuestion.Hide();
            }
        }

        private void txtChoice3_TextChanged(object sender, EventArgs e)
        {
            if (this.rtQuestion.Text != "" && this.txtChoice1.Text != "" && this.txtChoice2.Text != "" && this.txtChoice3.Text != "" && this.txtChoice4.Text != "")
            {
                this.panelErrorQuestion.Hide();
            }
        }

        private void txtChoice4_TextChanged(object sender, EventArgs e)
        {
            if (this.rtQuestion.Text != "" && this.txtChoice1.Text != "" && this.txtChoice2.Text != "" && this.txtChoice3.Text != "" && this.txtChoice4.Text != "")
            {
                this.panelErrorQuestion.Hide();
            }
        }

        private void txtChoice5_TextChanged(object sender, EventArgs e)
        {
            if (this.rtQuestion.Text != "" && this.txtChoice1.Text != "" && this.txtChoice2.Text != "" && this.txtChoice3.Text != "" && this.txtChoice4.Text != "")
            {
                this.panelErrorQuestion.Hide();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.flag1.Checked = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.flag2.Checked = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.flag3.Checked = true;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.flag4.Checked = true;
        }
    }
}