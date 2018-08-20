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
    public partial class frmClassRecord : Form
    {
        public frmClassRecord()
        {
            InitializeComponent();
        }

        private void frmClassRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsClassRecordData.vwActiveStudentsRecord' table. You can move, or remove it, as needed.
            this.vwActiveStudentsRecordTableAdapter.Fill(this.dsClassRecordData.vwActiveStudentsRecord);
            // TODO: This line of code loads data into the 'dsClassRecordStudents.vwActiveStudents' table. You can move, or remove it, as needed.
            this.vwActiveStudentsTableAdapter.Fill(this.dsClassRecordStudents.vwActiveStudents);

        }

        private void dgCRStudents_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = this.dgCRStudents.CurrentCell.RowIndex;

            String query = "SELECT * FROM vwActiveStudentsRecord WHERE UserID = '" + this.dgCRStudents.Rows[rowindex].Cells[0].Value + "'";
            DataGridView dg = this.dgCRStudentData;

            new dbModule().refreshDataGrid(dg, query);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int rowindex = this.dgCRStudents.CurrentCell.RowIndex;

            String query = "SELECT * FROM vwActiveStudents";
            DataGridView dg = this.dgCRStudents;

            new dbModule().refreshDataGrid(dg, query);
        }
    }
}
