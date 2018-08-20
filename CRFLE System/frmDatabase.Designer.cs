namespace CRFLE_System
{
    partial class frmDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.vwDatabasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDatabases = new CRFLE_System.dsDatabases();
            this.vwServersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsServers = new CRFLE_System.dsServers();
            this.vwServersTableAdapter = new CRFLE_System.dsServersTableAdapters.vwServersTableAdapter();
            this.vwDatabasesTableAdapter = new CRFLE_System.dsDatabasesTableAdapters.vwDatabasesTableAdapter();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelBackup = new System.Windows.Forms.Panel();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.txtBRLoc = new DevExpress.XtraEditors.TextEdit();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.radioRestore = new System.Windows.Forms.RadioButton();
            this.radioBackup = new System.Windows.Forms.RadioButton();
            this.panelLightBlue = new System.Windows.Forms.Panel();
            this.panelNavy = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackupRestore = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.vwDatabasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatabases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwServersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServers)).BeginInit();
            this.panelBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBRLoc.Properties)).BeginInit();
            this.panelNavy.SuspendLayout();
            this.SuspendLayout();
            // 
            // vwDatabasesBindingSource
            // 
            this.vwDatabasesBindingSource.DataMember = "vwDatabases";
            this.vwDatabasesBindingSource.DataSource = this.dsDatabases;
            // 
            // dsDatabases
            // 
            this.dsDatabases.DataSetName = "dsDatabases";
            this.dsDatabases.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwServersBindingSource
            // 
            this.vwServersBindingSource.DataMember = "vwServers";
            this.vwServersBindingSource.DataSource = this.dsServers;
            // 
            // dsServers
            // 
            this.dsServers.DataSetName = "dsServers";
            this.dsServers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwServersTableAdapter
            // 
            this.vwServersTableAdapter.ClearBeforeFill = true;
            // 
            // vwDatabasesTableAdapter
            // 
            this.vwDatabasesTableAdapter.ClearBeforeFill = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Backup";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Restore";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panelBackup
            // 
            this.panelBackup.Controls.Add(this.cmbDatabase);
            this.panelBackup.Controls.Add(this.cmbServer);
            this.panelBackup.Controls.Add(this.txtBRLoc);
            this.panelBackup.Controls.Add(this.btnBrowse);
            this.panelBackup.Controls.Add(this.labelControl6);
            this.panelBackup.Controls.Add(this.labelControl2);
            this.panelBackup.Controls.Add(this.labelControl1);
            this.panelBackup.Location = new System.Drawing.Point(5, 142);
            this.panelBackup.Name = "panelBackup";
            this.panelBackup.Size = new System.Drawing.Size(417, 151);
            this.panelBackup.TabIndex = 86;
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.DataSource = this.vwDatabasesBindingSource;
            this.cmbDatabase.DisplayMember = "Expr1";
            this.cmbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDatabase.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(95, 60);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(304, 29);
            this.cmbDatabase.TabIndex = 84;
            this.cmbDatabase.ValueMember = "Expr2";
            // 
            // cmbServer
            // 
            this.cmbServer.DataSource = this.vwServersBindingSource;
            this.cmbServer.DisplayMember = "name";
            this.cmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbServer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(95, 13);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(304, 29);
            this.cmbServer.TabIndex = 83;
            this.cmbServer.ValueMember = "server_id";
            // 
            // txtBRLoc
            // 
            this.txtBRLoc.Enabled = false;
            this.txtBRLoc.Location = new System.Drawing.Point(95, 108);
            this.txtBRLoc.Name = "txtBRLoc";
            this.txtBRLoc.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBRLoc.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBRLoc.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBRLoc.Properties.Appearance.Options.UseBackColor = true;
            this.txtBRLoc.Properties.Appearance.Options.UseFont = true;
            this.txtBRLoc.Properties.Appearance.Options.UseForeColor = true;
            this.txtBRLoc.Properties.AutoHeight = false;
            this.txtBRLoc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtBRLoc.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtBRLoc.Properties.MaxLength = 25;
            this.txtBRLoc.Properties.NullValuePrompt = "Directory";
            this.txtBRLoc.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtBRLoc.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtBRLoc.Size = new System.Drawing.Size(268, 27);
            this.txtBRLoc.TabIndex = 82;
            this.txtBRLoc.EditValueChanged += new System.EventHandler(this.txtBackupLoc_EditValueChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(369, 107);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 29);
            this.btnBrowse.TabIndex = 81;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(37, 16);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(52, 21);
            this.labelControl6.TabIndex = 80;
            this.labelControl6.Text = "Server:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(17, 110);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 21);
            this.labelControl2.TabIndex = 80;
            this.labelControl2.Text = "Location:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(6, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 21);
            this.labelControl1.TabIndex = 80;
            this.labelControl1.Text = "Database:";
            // 
            // radioRestore
            // 
            this.radioRestore.AutoSize = true;
            this.radioRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRestore.Location = new System.Drawing.Point(136, 117);
            this.radioRestore.Name = "radioRestore";
            this.radioRestore.Size = new System.Drawing.Size(90, 24);
            this.radioRestore.TabIndex = 84;
            this.radioRestore.Text = "Restore";
            this.radioRestore.UseVisualStyleBackColor = true;
            this.radioRestore.CheckedChanged += new System.EventHandler(this.radioRestore_CheckedChanged_1);
            // 
            // radioBackup
            // 
            this.radioBackup.AutoSize = true;
            this.radioBackup.Checked = true;
            this.radioBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBackup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBackup.Location = new System.Drawing.Point(40, 117);
            this.radioBackup.Name = "radioBackup";
            this.radioBackup.Size = new System.Drawing.Size(90, 23);
            this.radioBackup.TabIndex = 85;
            this.radioBackup.TabStop = true;
            this.radioBackup.Text = "Back Up";
            this.radioBackup.UseVisualStyleBackColor = true;
            this.radioBackup.CheckedChanged += new System.EventHandler(this.radioBackup_CheckedChanged_1);
            // 
            // panelLightBlue
            // 
            this.panelLightBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.panelLightBlue.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLightBlue.Location = new System.Drawing.Point(0, 72);
            this.panelLightBlue.Name = "panelLightBlue";
            this.panelLightBlue.Size = new System.Drawing.Size(432, 10);
            this.panelLightBlue.TabIndex = 88;
            // 
            // panelNavy
            // 
            this.panelNavy.BackColor = System.Drawing.Color.Navy;
            this.panelNavy.Controls.Add(this.label1);
            this.panelNavy.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavy.Location = new System.Drawing.Point(0, 0);
            this.panelNavy.Name = "panelNavy";
            this.panelNavy.Size = new System.Drawing.Size(432, 72);
            this.panelNavy.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database";
            // 
            // btnBackupRestore
            // 
            this.btnBackupRestore.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnBackupRestore.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupRestore.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBackupRestore.Appearance.Options.UseBackColor = true;
            this.btnBackupRestore.Appearance.Options.UseFont = true;
            this.btnBackupRestore.Appearance.Options.UseForeColor = true;
            this.btnBackupRestore.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnBackupRestore.Enabled = false;
            this.btnBackupRestore.Location = new System.Drawing.Point(117, 316);
            this.btnBackupRestore.Name = "btnBackupRestore";
            this.btnBackupRestore.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnBackupRestore.Size = new System.Drawing.Size(191, 40);
            this.btnBackupRestore.TabIndex = 89;
            this.btnBackupRestore.Text = "BACKUP";
            this.btnBackupRestore.Click += new System.EventHandler(this.btnBackupRestore_Click);
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(432, 369);
            this.Controls.Add(this.btnBackupRestore);
            this.Controls.Add(this.panelLightBlue);
            this.Controls.Add(this.panelNavy);
            this.Controls.Add(this.panelBackup);
            this.Controls.Add(this.radioRestore);
            this.Controls.Add(this.radioBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwDatabasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatabases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwServersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServers)).EndInit();
            this.panelBackup.ResumeLayout(false);
            this.panelBackup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBRLoc.Properties)).EndInit();
            this.panelNavy.ResumeLayout(false);
            this.panelNavy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsServers dsServers;
        private System.Windows.Forms.BindingSource vwServersBindingSource;
        private dsServersTableAdapters.vwServersTableAdapter vwServersTableAdapter;
        private dsDatabases dsDatabases;
        private System.Windows.Forms.BindingSource vwDatabasesBindingSource;
        private dsDatabasesTableAdapters.vwDatabasesTableAdapter vwDatabasesTableAdapter;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelBackup;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.ComboBox cmbServer;
        private DevExpress.XtraEditors.TextEdit txtBRLoc;
        private System.Windows.Forms.Button btnBrowse;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RadioButton radioRestore;
        private System.Windows.Forms.RadioButton radioBackup;
        private System.Windows.Forms.Panel panelLightBlue;
        private System.Windows.Forms.Panel panelNavy;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnBackupRestore;
    }
}