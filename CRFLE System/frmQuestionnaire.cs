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
    public partial class frmQuestionnaire : Form
    {
        public static String stringrtf;
        public static int clickedQtnr;

        public frmQuestionnaire()
        {
            InitializeComponent();
        }

        private void frmQuestionnaire_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQuestionnaireItems.vwQuestionnaireItems' table. You can move, or remove it, as needed.
            this.vwQuestionnaireItemsTableAdapter.Fill(this.dsQuestionnaireItems.vwQuestionnaireItems);
            // TODO: This line of code loads data into the 'dsQuestionnaires.tblQuestionnaires' table. You can move, or remove it, as needed.
            this.tblQuestionnairesTableAdapter.Fill(this.dsQuestionnaires.tblQuestionnaires);
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateQuestionnaire.dg = this.dgQuestionnaires;
            frmCreateQuestionnaire.refreshquery = "SELECT ID, Title FROM tblQuestionnaires";
            new frmCreateQuestionnaire().ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            new dbModule().refreshDataGrid(this.dgQuestionnaires, "SELECT ID, Title FROM tblQuestionnaires");
        }

        public void refreshGrids()
        {
            new dbModule().refreshDataGrid(this.dgQuestionnaires, "SELECT ID, Title FROM tblQuestionnaires");
        }

        private void btnViewInfo_Click(object sender, EventArgs e)
        {
            new frmAboutQtnr().ShowDialog();
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

        private void dgQuestionnaires_SelectionChanged(object sender, EventArgs e)
        {
            this.dgQuestionnaireItems.Rows.Clear();
            int rowindex = this.dgQuestionnaires.CurrentCell.RowIndex;
            new dbModule().questionnaireItemDG(this.dgQuestionnaireItems, "SELECT ROW_NUMBER() OVER(ORDER BY QtnrID) as Number, Question FROM vwQuestionnaireItems WHERE QtnrID = '" + Convert.ToString(this.dgQuestionnaires.Rows[rowindex].Cells[0].Value) + "'");

            clickedQtnr = Convert.ToInt32(this.dgQuestionnaires.Rows[rowindex].Cells[0].Value);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.dgQuestionnaireItems.Rows.Clear();
            int rowindex = this.dgQuestionnaires.CurrentCell.RowIndex;

            new dbModule().printQuestionnaire(Convert.ToInt32(this.dgQuestionnaires.Rows[rowindex].Cells[0].Value));

            using(frmPrint print = new frmPrint())
            {
                print.printQuestionnaire();
                print.ShowDialog();
            }
        }
    }
}
