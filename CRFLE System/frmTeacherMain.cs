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
using System.Threading;
using CRFLE_System.Properties;

namespace CRFLE_System
{
    public partial class frmTeacherMain : DevExpress.XtraEditors.XtraForm
    {
        public static String stringrtf;
        public static int clickedQtnr;

        public static String question;
        public static String explanation;
        public static String[] choices = new String[4];
        
        public frmTeacherMain()
        {
            InitializeComponent();
        }
        
        private void acdnQtnBank_Click(object sender, EventArgs e)
        {
            resetBtnColors();

            this.acdnQtnBank.Appearance.Normal.BackColor = Color.White;
            this.acdnQtnBank.Appearance.Normal.ForeColor = Color.Navy;

            cleanMainPanel();
            
            hidePanels();

            String query;

            if (this.chkFilter.Checked == true)
            {
                query = Convert.ToString("SELECT * FROM vwQuestionForDataGrid WHERE Category = '" + this.cmbCategory.Text + "'");
            }
            else
            {
                query = "SELECT * FROM vwQuestionForDataGrid";
            }

            this.panelQuestionBank.Show();
            new dbModule().refreshDataGrid(this.dgQuestionBank, query);

        }   

        private void acdnQtnr_Click(object sender, EventArgs e)
        {
            resetBtnColors();

            this.acdnQtnr.Appearance.Normal.BackColor = Color.White;
            this.acdnQtnr.Appearance.Normal.ForeColor = Color.Navy;

            hidePanels();
            this.panelQuestionnaires.Show();
        }

        private void tblCategoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void acdnExamination_Click(object sender, EventArgs e)
        {
            resetBtnColors();
            closeGroups();
            this.acdnExamination.Appearance.Normal.BackColor = Color.White;
            this.acdnExamination.Appearance.Normal.ForeColor = Color.Navy;

            hidePanels();
            this.panelExamination.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTeacherMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            new frmLogin().Show();
        }

        private void acdnDashboard_Click(object sender, EventArgs e)
        {
            resetBtnColors();
            closeGroups();
            this.acdnDashboard.Appearance.Normal.BackColor = Color.White;
            this.acdnDashboard.Appearance.Normal.ForeColor = Color.Navy;

            hidePanels();
            this.panelDashboard.Show();
            this.dashboardViewer1.ReloadData();

        }

        private void resetBtnColors()
        {
            //reset color of buttons
            this.acdnDashboard.Appearance.Normal.BackColor = Color.Navy;
            this.acdnDashboard.Appearance.Normal.ForeColor = Color.Gold;
            
            this.acdnClassRecord.Appearance.Normal.BackColor = Color.Navy;
            this.acdnClassRecord.Appearance.Normal.ForeColor = Color.Gold;

            this.acdnExamination.Appearance.Normal.BackColor = Color.Navy;
            this.acdnExamination.Appearance.Normal.ForeColor = Color.Gold;

            this.acdnAbout.Appearance.Normal.BackColor = Color.Navy;
            this.acdnAbout.Appearance.Normal.ForeColor = Color.Gold;

            //reset the color of sub items
            this.acdnQtnr.Appearance.Normal.BackColor = Color.FromArgb(98, 0, 234);
            this.acdnQtnr.Appearance.Normal.ForeColor = Color.White;

            this.acdnQtnBank.Appearance.Normal.BackColor = Color.FromArgb(98, 0, 234);
            this.acdnQtnBank.Appearance.Normal.ForeColor = Color.White;

            this.acdnMngAccounts.Appearance.Normal.BackColor = Color.FromArgb(98, 0, 234);
            this.acdnMngAccounts.Appearance.Normal.ForeColor = Color.White;

            

            //this.acdnMngCategory.Appearance.Normal.BackColor = Color.FromArgb(98, 0, 234);
            //this.acdnMngCategory.Appearance.Normal.ForeColor = Color.White;
        }

        private void closeGroups()
        {
            this.acdnReviewer.Expanded = false;
            this.acdnManage.Expanded = false;
        }
        private void acdnStudent_Click(object sender, EventArgs e)
        {
            
        }

        private void acdnTeacher_Click(object sender, EventArgs e)
        {
            
            
        }

        private void frmTeacherMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQuestionnaires.tblQuestionnaires' table. You can move, or remove it, as needed.
            this.tblQuestionnairesTableAdapter.Fill(this.dsQuestionnaires.tblQuestionnaires);
            // TODO: This line of code loads data into the 'dbCRFLEDataSet1.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.dbCRFLEDataSet1.tblUsers);
            // TODO: This line of code loads data into the 'dsCategory.tblCategory' table. You can move, or remove it, as needed.
            this.tblCategoryTableAdapter.Fill(this.dsCategory.tblCategory);
            this.vwExaminationsTableAdapter.Fill(this.dsExamination.vwExaminations);
            this.vwActiveStudentsRecordTableAdapter.Fill(this.dsClassRecordData.vwActiveStudentsRecord);
            this.vwActiveStudentsTableAdapter.Fill(this.dsClassRecordStudents.vwActiveStudents);

            closeGroups();
            hidePanels();
            dockPanels();

            this.acdnDashboard.Appearance.Normal.BackColor = Color.White;
            this.acdnDashboard.Appearance.Normal.ForeColor = Color.Navy;
            this.dashboardViewer1.DashboardSource = "..\\Dashboard Designs\\Sample Dashboard.xml";
            this.panelDashboard.Show();
        }

        private void acdnAbout_Click(object sender, EventArgs e)
        {
            resetBtnColors();
            //this.acdnAbout.Appearance.Normal.BackColor = Color.White;
            //this.acdnAbout.Appearance.Normal.ForeColor = Color.Navy;
        }

        private void cleanMainPanel()
        {
            //this.panelMainContainer.Controls.Clear();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmAddUser().ShowDialog();
        }

        private void hidePanels()
        {
            this.panelQuestionBank.Hide();
            this.panelAccountTeachers.Hide();
            this.panelQuestionnaires.Hide();
            this.panelDashboard.Hide();
            this.panelExamination.Hide();
            this.panelClassRecord.Hide();
        }

        private void dockPanels()
        {
            this.panelAccountTeachers.Dock = DockStyle.Fill;
            this.panelQuestionnaires.Dock = DockStyle.Fill;
            this.panelQuestionBank.Dock = DockStyle.Fill;
            this.panelDashboard.Dock = DockStyle.Fill;
            this.panelExamination.Dock = DockStyle.Fill;
            this.panelClassRecord.Dock = DockStyle.Fill;
        }

        private void btnAddQuestion_Click_1(object sender, EventArgs e)
        {
            
        }

        private void acdnMngAccounts_Click(object sender, EventArgs e)
        {
            resetBtnColors();

            this.acdnMngAccounts.Appearance.Normal.BackColor = Color.White;
            this.acdnMngAccounts.Appearance.Normal.ForeColor = Color.Navy;

            cleanMainPanel();
            this.panelAccountTeachers.BringToFront();

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

            this.panelAccountTeachers.Show();

            //new frmAccounts().Show();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            new frmAddItem().ShowDialog();
        }

        private void btnViewInfo_Click(object sender, EventArgs e)
        {
            new frmAboutQtnr().ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateQuestionnaire.dg = this.dgQuestionnaires;
            frmCreateQuestionnaire.refreshquery = "SELECT ID, Title FROM tblQuestionnaires";
            new frmCreateQuestionnaire().ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.dgQuestionnaireItems.Rows.Clear();
            int rowindex = this.dgQuestionnaires.CurrentCell.RowIndex;

            new dbModule().printQuestionnaire(Convert.ToInt32(this.dgQuestionnaires.Rows[rowindex].Cells[0].Value));

            using (frmPrint print = new frmPrint())
            {
                print.printQuestionnaire();
                print.ShowDialog();
            }

            new dbModule().questionnaireItemDG(this.dgQuestionnaireItems, "SELECT ROW_NUMBER() OVER(ORDER BY QtnrID) as Number, Question FROM vwQuestionnaireItems WHERE QtnrID = '" + Convert.ToString(this.dgQuestionnaires.Rows[rowindex].Cells[0].Value) + "'");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowindex = this.dgQuestionnaires.CurrentCell.RowIndex;

            frmDialog.message = "Do you wish to delete this questionnaire from database?";
            frmDialog.query = "DELETE FROM tblQuestionnaires WHERE ID = '" + Convert.ToString(this.dgQuestionnaires.Rows[rowindex].Cells[0].Value) + "'";
            frmDialog.dg = this.dgQuestionnaires;
            frmDialog.refreshquery = "SELECT ID, Title FROM tblQuestionnaires";
            new frmDialog().ShowDialog();
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

        private void btnAddQuestion_Click_2(object sender, EventArgs e)
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

        private void btnUpdateItem_Click(object sender, EventArgs e)
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

        private void btnDeleteItem_Click(object sender, EventArgs e)
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

        private void dgQuestionBank_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = this.dgQuestionBank.CurrentCell.RowIndex;
            new dbModule().fillQBFields(Convert.ToInt32(this.dgQuestionBank.Rows[rowindex].Cells[4].Value));

            this.rtQuestion.RtfText = question;
            this.txtchoice1.Text = choices.ElementAt(0);
            this.txtchoice2.Text = choices.ElementAt(1);
            this.txtchoice3.Text = choices.ElementAt(2);
            this.txtchoice4.Text = choices.ElementAt(3);
        }

        private void dgQuestionnaires_SelectionChanged_1(object sender, EventArgs e)
        {
            this.dgQuestionnaireItems.Rows.Clear();
            int rowindex = this.dgQuestionnaires.CurrentCell.RowIndex;
            new dbModule().questionnaireItemDG(this.dgQuestionnaireItems, "SELECT ROW_NUMBER() OVER(ORDER BY QtnrID) as Number, Question FROM vwQuestionnaireItems WHERE QtnrID = '" + Convert.ToString(this.dgQuestionnaires.Rows[rowindex].Cells[0].Value) + "'");

            clickedQtnr = Convert.ToInt32(this.dgQuestionnaires.Rows[rowindex].Cells[0].Value);
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmAddUser.usertype = 2;
            frmAddUser.verified = 1;

            new frmAddUser().Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            new dbModule().refreshDataGrid(this.dgAccounts, "SELECT * FROM vwAccountInfo");

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

        private void btnNewSched_Click(object sender, EventArgs e)
        {
            frmExamSchedule.dg = this.dgExaminationSchedule;
            frmExamSchedule.refreshquery = "SELECT * FROM vwExaminations ORDER BY Date, StartTime";
            new frmExamSchedule().ShowDialog();
        }

        private void dgExaminationSchedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = this.dgExaminationSchedule.CurrentCell.RowIndex;

            frmAboutExam.date = this.dgExaminationSchedule.Rows[rowindex].Cells[1].EditedFormattedValue.ToString();
            frmAboutExam.stime = this.dgExaminationSchedule.Rows[rowindex].Cells[2].EditedFormattedValue.ToString();
            frmAboutExam.etime = this.dgExaminationSchedule.Rows[rowindex].Cells[4].EditedFormattedValue.ToString();
            frmAboutExam.duration = this.dgExaminationSchedule.Rows[rowindex].Cells[3].EditedFormattedValue.ToString();
            frmAboutExam.status = this.dgExaminationSchedule.Rows[rowindex].Cells[5].EditedFormattedValue.ToString();
            frmAboutExam.qtnr = this.dgExaminationSchedule.Rows[rowindex].Cells[6].EditedFormattedValue.ToString();

            new frmAboutExam().ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int rowindex = this.dgExaminationSchedule.CurrentCell.RowIndex;

            frmDialog.message = "Do you wish to cancel this examination schedule?";
            frmDialog.query = "DELETE FROM tblExamSessions WHERE ID = '" + this.dgExaminationSchedule.Rows[rowindex].Cells[0].EditedFormattedValue + "'";
            frmDialog.dg = this.dgExaminationSchedule;
            frmDialog.refreshquery = "SELECT * FROM vwExaminations ORDER BY Date, StartTime";

            new frmDialog().ShowDialog();
        }

        private void dgCRStudents_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = this.dgCRStudents.CurrentCell.RowIndex;

            String query = "SELECT * FROM vwActiveStudentsRecord WHERE UserID = '" + this.dgCRStudents.Rows[rowindex].Cells[0].Value + "'";
            DataGridView dg = this.dgCRStudentData;

            new dbModule().refreshDataGrid(dg, query);
        }

        private void btnCRRefresh_Click(object sender, EventArgs e)
        {
            int rowindex = this.dgCRStudents.CurrentCell.RowIndex;

            String query = "SELECT * FROM vwActiveStudents";
            DataGridView dg = this.dgCRStudents;

            new dbModule().refreshDataGrid(dg, query);
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            hidePanels();
            this.panelClassRecord.Show();
        }

        private void acdnDatabase_Click(object sender, EventArgs e)
        {
            resetBtnColors();
            new frmDatabase().ShowDialog();
        }

        private void acdnClassRecord_Click(object sender, EventArgs e)
        {
            resetBtnColors();
            hidePanels();
            this.acdnClassRecord.Appearance.Normal.BackColor = Color.White;
            this.acdnClassRecord.Appearance.Normal.ForeColor = Color.Navy;
            this.panelClassRecord.Show();
        }

        private void acdnReviewer_Click(object sender, EventArgs e)
        {
            resetBtnColors();
        }

        private void acdnManage_Click(object sender, EventArgs e)
        {
            resetBtnColors();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            resetBtnColors();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            resetBtnColors();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            resetBtnColors();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

    }
}