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
    public partial class frmQuestionBank : Form
    {
        public static String question;
        public static String explanation;
        public static String[] choices = new String[4];

        public frmQuestionBank()
        {
            InitializeComponent();
        }

        private void frmQuestionBank_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQuestionBank.vwQuestionForDataGrid' table. You can move, or remove it, as needed.
            this.vwQuestionForDataGridTableAdapter.Fill(this.dsQuestionBank.vwQuestionForDataGrid);
            // TODO: This line of code loads data into the 'dsCategory.tblCategory' table. You can move, or remove it, as needed.
            this.tblCategoryTableAdapter.Fill(this.dsCategory.tblCategory);

            int rowindex = this.dgQuestionBank.CurrentCell.RowIndex;
            new dbModule().fillQBFields(Convert.ToInt32(this.dgQuestionBank.Rows[rowindex].Cells[4].Value));

            this.rtQuestion.RtfText = question;
            this.txtchoice1.Text = choices.ElementAt(0);
            this.txtchoice2.Text = choices.ElementAt(1);
            this.txtchoice3.Text = choices.ElementAt(2);
            this.txtchoice4.Text = choices.ElementAt(3);
            
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            String query;

            if (this.chkFilter.Checked == true)
            {
                query = Convert.ToString("SELECT * FROM vwQuestionForDataGrid WHERE Category = '" + this.cmbCategory.Text + "'");
            }
            else
            {
                query = "SELECT * FROM vwQuestionForDataGrid";
            }

            frmAddItem.dg = this.dgQuestionBank;
            frmAddItem.query = query;

            new frmAddItem().ShowDialog();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            String query;

            if (this.chkFilter.Checked == true)
            {
                query = Convert.ToString("SELECT * FROM vwQuestionForDataGrid WHERE Category = '" + this.cmbCategory.Text + "'");
            }
            else
            {
                query = "SELECT * FROM vwQuestionForDataGrid";
            }

            new dbModule().refreshDataGrid(this.dgQuestionBank, query);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.chkFilter.Checked == true)
            {
                new dbModule().refreshDataGrid(this.dgQuestionBank, Convert.ToString("SELECT * FROM vwQuestionForDataGrid where Category = '" + this.cmbCategory.Text + "' AND (Question LIKE '%" + this.txtSearch.Text + "%' or Answer LIKE '%" + this.txtSearch.Text + "%')"));
            }
            else
            {
                new dbModule().refreshDataGrid(this.dgQuestionBank, Convert.ToString("SELECT * FROM vwQuestionForDataGrid where Question like '%" + this.txtSearch.Text + "%' or Answer like '%" + this.txtSearch.Text + "%'"));
            }
            this.txtSearch.Text = "";
        }

        private void chkFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkFilter.Checked == true)
            {
                this.cmbCategory.Enabled = true;
                new dbModule().refreshDataGrid(this.dgQuestionBank, Convert.ToString("SELECT * FROM vwQuestionForDataGrid WHERE Category = '" + this.cmbCategory.Text + "'"));
            }
            else
            {
                this.cmbCategory.Enabled = false;
                new dbModule().refreshDataGrid(this.dgQuestionBank, "SELECT * FROM vwQuestionForDataGrid");
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            new dbModule().refreshDataGrid(this.dgQuestionBank, Convert.ToString("SELECT * FROM vwQuestionForDataGrid WHERE Category = '" + this.cmbCategory.Text + "'"));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowindex = this.dgQuestionBank.CurrentCell.RowIndex;

            frmUpdateItem.id = Convert.ToInt32(this.dgQuestionBank.Rows[rowindex].Cells[4].Value);
            frmUpdateItem.question = question;
            frmUpdateItem.explanation = explanation;
            frmUpdateItem.choice1 = choices.ElementAt(0);
            frmUpdateItem.choice2 = choices.ElementAt(1);
            frmUpdateItem.choice3 = choices.ElementAt(2);
            frmUpdateItem.choice4 = choices.ElementAt(3);
            frmUpdateItem.answer = Convert.ToString(this.dgQuestionBank.Rows[rowindex].Cells[2].Value);

            String query;

            if (this.chkFilter.Checked == true)
            {
                query = Convert.ToString("SELECT * FROM vwQuestionForDataGrid WHERE Category = '" + this.cmbCategory.Text + "'");
            }
            else
            {
                query = "SELECT * FROM vwQuestionForDataGrid";
            }

            frmUpdateItem.dg = this.dgQuestionBank;
            frmUpdateItem.query = query;
            new frmUpdateItem().ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowindex = this.dgQuestionBank.CurrentCell.RowIndex;

            frmDialog.message = "Do you wish to delete this item from database?";
            frmDialog.query = "DELETE FROM tblItems WHERE ID = '" + Convert.ToString(this.dgQuestionBank.Rows[rowindex].Cells[4].Value) + "'";
            frmDialog.dg = this.dgQuestionBank;

            if (this.chkFilter.Checked == true)
            {
                frmDialog.refreshquery = "SELECT * FROM vwQuestionForDataGrid WHERE Category = '" + this.cmbCategory.Text + "'";
            }
            else
            {
                frmDialog.refreshquery = "SELECT * FROM vwQuestionForDataGrid";
            }

            new frmDialog().ShowDialog();
        }

        private void dgQuestionBank_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgQuestionBank_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = this.dgQuestionBank.CurrentCell.RowIndex;
            new dbModule().fillQBFields(Convert.ToInt32(this.dgQuestionBank.Rows[rowindex].Cells[4].Value));

            this.rtQuestion.RtfText = question;
            this.txtchoice1.Text = choices.ElementAt(0);
            this.txtchoice2.Text = choices.ElementAt(1);
            this.txtchoice3.Text = choices.ElementAt(2);
            this.txtchoice4.Text = choices.ElementAt(3);
        }

    }
}
