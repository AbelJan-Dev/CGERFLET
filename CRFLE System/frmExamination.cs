using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Alerter;

namespace CRFLE_System
{
    public partial class frmExamination : Form
    {
        public frmExamination()
        {
            InitializeComponent();
        }

        private void frmExamination_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsExamination.vwExaminations' table. You can move, or remove it, as needed.
            this.vwExaminationsTableAdapter.Fill(this.dsExamination.vwExaminations);
        }

        private void btnNewSched_Click(object sender, EventArgs e)
        {
            frmExamSchedule.dg = this.dgExaminationSchedule;
            frmExamSchedule.refreshquery = "SELECT * FROM vwExaminations ORDER BY Date, StartTime";
            new frmExamSchedule().ShowDialog();
        }

        private void dgExaminationSchedule_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = this.dgExaminationSchedule.CurrentCell.RowIndex;

            this.Calendar.EditValue = (Convert.ToDateTime(this.dgExaminationSchedule.Rows[rowindex].Cells[1].Value));
            
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
    }
}
