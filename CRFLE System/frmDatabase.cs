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
    public partial class frmDatabase : Form
    {
        public frmDatabase()
        {
            InitializeComponent();
        }

        private void frmDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDatabases.vwDatabases' table. You can move, or remove it, as needed.
            this.vwDatabasesTableAdapter.Fill(this.dsDatabases.vwDatabases);
            // TODO: This line of code loads data into the 'dsServers.vwServers' table. You can move, or remove it, as needed.
            this.vwServersTableAdapter.Fill(this.dsServers.vwServers);

            String path = "F:/CGERFLET System";
            saveFileDialog1.Filter = "Text files (*.bak)|*.bak";
            saveFileDialog1.InitialDirectory = path;
            openFileDialog1.Filter = "Text files (*.bak)|*.bak";
            openFileDialog1.InitialDirectory = path;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (this.radioBackup.Checked == true)
            {
                saveFileDialog1.FileName = this.cmbDatabase.Text + " " + DateTime.Now.ToString().Replace('/', '-').Replace(':', '.');
                saveFileDialog1.ShowDialog();
            }
            else if (this.radioRestore.Checked == true)
            {
                openFileDialog1.ShowDialog();
            }
            
        }

        private void radioBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioBackup.Checked == true)
            {
                this.panelBackup.Enabled = true;
                this.btnBackupRestore.Text = "BACKUP";
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.txtBRLoc.Text = this.saveFileDialog1.FileName.ToString();
        }

        private void txtBackupLoc_EditValueChanged(object sender, EventArgs e)
        {
            if (this.txtBRLoc.Text == "" || this.txtBRLoc.Text == null)
            {
                this.btnBackupRestore.Enabled = false;
            }
            else
            {
                this.btnBackupRestore.Enabled = true;
            }
        }

        private void radioRestore_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioRestore.Checked == true)
            {
                this.panelBackup.Enabled = true;
                this.btnBackupRestore.Text = "RESTORE";
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.txtBRLoc.Text = this.openFileDialog1.FileName.ToString();
        }
        
        private void btnBackupRestore_Click(object sender, EventArgs e)
        {
            if (this.radioBackup.Checked == true)
            {
                frmDatabaseDialog.message = "Do you wish to create a backup of the database?";
                frmDatabaseDialog.successmessage = "Backup Successfull!";
                frmDatabaseDialog.query1 = "BACKUP DATABASE " + this.cmbDatabase.Text + " TO DISK = '" + this.txtBRLoc.Text + "'";
                frmDatabaseDialog.BRbool = true;
                new frmDatabaseDialog().ShowDialog();
                this.txtBRLoc.Text = "";
            }
            else if (this.radioRestore.Checked == true)
            {
                frmDatabaseDialog.message = "Do you wish to restore the database backup?";
                frmDatabaseDialog.successmessage = "Restore Successfull!";
                frmDatabaseDialog.query2 = "ALTER DATABASE " + this.cmbDatabase.Text + " SET Single_User WITH Rollback Immediate";
                frmDatabaseDialog.query3 = "RESTORE DATABASE " + this.cmbDatabase.Text + " FROM DISK = N'" + this.txtBRLoc.Text + "' WITH FILE = 1, NOUNLOAD, STATS = 10";
                frmDatabaseDialog.query4 = "ALTER DATABASE " + this.cmbDatabase.Text + " SET Multi_User";
                frmDatabaseDialog.BRbool = false;
                new frmDatabaseDialog().ShowDialog();
                this.txtBRLoc.Text = "";
            }
        }

        private void changeButtonText(string btnText)
        {
            this.btnBackupRestore.Text = btnText;
        }

        private void radioRestore_CheckedChanged_1(object sender, EventArgs e)
        {
            changeButtonText("RESTORE");
        }

        private void radioBackup_CheckedChanged_1(object sender, EventArgs e)
        {
            changeButtonText("BACKUP");
        }
    }
}
