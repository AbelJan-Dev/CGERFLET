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
    public partial class frmAccounts : Form
    {
        public frmAccounts()
        {
            InitializeComponent();
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsAccountInfo.vwAccountInfo' table. You can move, or remove it, as needed.
            this.vwAccountInfoTableAdapter.Fill(this.dsAccountInfo.vwAccountInfo);

            this.lblIDNo.Text = this.dgAccounts.Rows[0].Cells[0].Value.ToString();
            this.lblUserType.Text = this.dgAccounts.Rows[0].Cells[1].Value.ToString();
            this.txtfullname.Text = this.dgAccounts.Rows[0].Cells[2].Value.ToString();
            this.txtgender.Text = this.dgAccounts.Rows[0].Cells[3].Value.ToString();
            this.txtage.Text = this.dgAccounts.Rows[0].Cells[4].Value.ToString() + " years old";
            this.txtaddress1.Text = this.dgAccounts.Rows[0].Cells[5].Value.ToString();
            this.txtaddress2.Text = this.dgAccounts.Rows[0].Cells[6].Value.ToString();
            this.txtusername.Text = this.dgAccounts.Rows[0].Cells[7].Value.ToString();
        }

        private void dgAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = this.dgAccounts.CurrentCell.RowIndex;

            this.lblIDNo.Text = this.dgAccounts.Rows[rowindex].Cells[0].Value.ToString();
            this.lblUserType.Text = this.dgAccounts.Rows[rowindex].Cells[1].Value.ToString();
            this.txtfullname.Text = this.dgAccounts.Rows[rowindex].Cells[2].Value.ToString();
            this.txtgender.Text = this.dgAccounts.Rows[rowindex].Cells[3].Value.ToString();
            this.txtage.Text = this.dgAccounts.Rows[rowindex].Cells[4].Value.ToString() + " years old";
            this.txtaddress1.Text = this.dgAccounts.Rows[rowindex].Cells[5].Value.ToString();
            this.txtaddress2.Text = this.dgAccounts.Rows[rowindex].Cells[6].Value.ToString();
            this.txtusername.Text = this.dgAccounts.Rows[rowindex].Cells[7].Value.ToString();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            int rowindex = this.dgAccounts.CurrentCell.RowIndex;

            if (this.dgAccounts.Rows[rowindex].Cells[8].Value.ToString() == "Active")
            {
                frmDialog.message = "Do you want to update the status to INACTIVE?";
                frmDialog.query = "UPDATE tblUsers SET Verified = 0 WHERE ID = '" + this.dgAccounts.Rows[rowindex].Cells[0].Value.ToString() + "'";
                frmDialog.dg = this.dgAccounts;
                frmDialog.refreshquery = "SELECT * FROM vwAccountInfo";
                frmDialog.successmessage = "Successfully updated.";

                new frmDialog().Show();
            }
            else
            {
                frmDialog.message = "Do you want to update the status to ACTIVE?";
                frmDialog.query = "UPDATE tblUsers SET Verified = 1 WHERE ID = '" + this.dgAccounts.Rows[rowindex].Cells[0].Value.ToString() + "'";
                frmDialog.dg = this.dgAccounts;
                frmDialog.refreshquery = "SELECT * FROM vwAccountInfo";
                frmDialog.successmessage = "Successfully updated.";

                new frmDialog().Show();
            }


        }

        private void btnPasswordReset_Click(object sender, EventArgs e)
        {
            int rowindex = this.dgAccounts.CurrentCell.RowIndex;

            frmDialog.message = "Do you want to RESET the password?";
            frmDialog.query = "UPDATE tblUsers SET UserPass = 'password' WHERE ID = '" + this.dgAccounts.Rows[rowindex].Cells[0].Value.ToString() + "'";
            frmDialog.dg = this.dgAccounts;
            frmDialog.refreshquery = "SELECT * FROM vwAccountInfo";
            frmDialog.successmessage = "Successfully reset.";

            new frmDialog().Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            new dbModule().refreshDataGrid(this.dgAccounts, "SELECT * FROM vwAccountInfo");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUser.usertype = 2;
            frmAddUser.verified = 1;

            new frmAddUser().Show();
        }
    }
}