namespace CRFLE_System
{
    partial class frmClassRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelClassRecord = new System.Windows.Forms.Panel();
            this.dgCRStudentData = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgCRStudents = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dsClassRecordStudents = new CRFLE_System.dsClassRecordStudents();
            this.vwActiveStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwActiveStudentsTableAdapter = new CRFLE_System.dsClassRecordStudentsTableAdapters.vwActiveStudentsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsClassRecordData = new CRFLE_System.dsClassRecordData();
            this.vwActiveStudentsRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwActiveStudentsRecordTableAdapter = new CRFLE_System.dsClassRecordDataTableAdapters.vwActiveStudentsRecordTableAdapter();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionnaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeFinishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelClassRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCRStudentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCRStudents)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsClassRecordStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwActiveStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClassRecordData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwActiveStudentsRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelClassRecord
            // 
            this.panelClassRecord.Controls.Add(this.dgCRStudentData);
            this.panelClassRecord.Controls.Add(this.panel5);
            this.panelClassRecord.Controls.Add(this.dgCRStudents);
            this.panelClassRecord.Controls.Add(this.panel4);
            this.panelClassRecord.Controls.Add(this.panel3);
            this.panelClassRecord.Controls.Add(this.panel2);
            this.panelClassRecord.Controls.Add(this.panel1);
            this.panelClassRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClassRecord.Location = new System.Drawing.Point(0, 0);
            this.panelClassRecord.Name = "panelClassRecord";
            this.panelClassRecord.Size = new System.Drawing.Size(982, 569);
            this.panelClassRecord.TabIndex = 1;
            // 
            // dgCRStudentData
            // 
            this.dgCRStudentData.AllowUserToAddRows = false;
            this.dgCRStudentData.AllowUserToDeleteRows = false;
            this.dgCRStudentData.AllowUserToResizeColumns = false;
            this.dgCRStudentData.AllowUserToResizeRows = false;
            this.dgCRStudentData.AutoGenerateColumns = false;
            this.dgCRStudentData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCRStudentData.BackgroundColor = System.Drawing.Color.White;
            this.dgCRStudentData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCRStudentData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCRStudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCRStudentData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.scheduleDataGridViewTextBoxColumn,
            this.questionnaireDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.timeFinishedDataGridViewTextBoxColumn,
            this.percentageDataGridViewTextBoxColumn});
            this.dgCRStudentData.DataSource = this.vwActiveStudentsRecordBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCRStudentData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgCRStudentData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCRStudentData.GridColor = System.Drawing.Color.Silver;
            this.dgCRStudentData.Location = new System.Drawing.Point(403, 40);
            this.dgCRStudentData.MultiSelect = false;
            this.dgCRStudentData.Name = "dgCRStudentData";
            this.dgCRStudentData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCRStudentData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgCRStudentData.RowHeadersVisible = false;
            this.dgCRStudentData.RowHeadersWidth = 20;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgCRStudentData.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgCRStudentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCRStudentData.Size = new System.Drawing.Size(529, 449);
            this.dgCRStudentData.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(378, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(25, 449);
            this.panel5.TabIndex = 7;
            // 
            // dgCRStudents
            // 
            this.dgCRStudents.AllowUserToAddRows = false;
            this.dgCRStudents.AllowUserToDeleteRows = false;
            this.dgCRStudents.AllowUserToResizeColumns = false;
            this.dgCRStudents.AllowUserToResizeRows = false;
            this.dgCRStudents.AutoGenerateColumns = false;
            this.dgCRStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCRStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgCRStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCRStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgCRStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCRStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.studentDataGridViewTextBoxColumn});
            this.dgCRStudents.DataSource = this.vwActiveStudentsBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCRStudents.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgCRStudents.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgCRStudents.GridColor = System.Drawing.Color.Silver;
            this.dgCRStudents.Location = new System.Drawing.Point(50, 40);
            this.dgCRStudents.MultiSelect = false;
            this.dgCRStudents.Name = "dgCRStudents";
            this.dgCRStudents.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCRStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgCRStudents.RowHeadersVisible = false;
            this.dgCRStudents.RowHeadersWidth = 20;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.dgCRStudents.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgCRStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCRStudents.Size = new System.Drawing.Size(328, 449);
            this.dgCRStudents.TabIndex = 6;
            this.dgCRStudents.SelectionChanged += new System.EventHandler(this.dgCRStudents_SelectionChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(50, 489);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(882, 80);
            this.panel4.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Appearance.Options.UseBackColor = true;
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Appearance.Options.UseForeColor = true;
            this.btnRefresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnRefresh.Location = new System.Drawing.Point(6, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnRefresh.Size = new System.Drawing.Size(110, 40);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(50, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(882, 40);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(932, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 569);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 569);
            this.panel1.TabIndex = 0;
            // 
            // dsClassRecordStudents
            // 
            this.dsClassRecordStudents.DataSetName = "dsClassRecordStudents";
            this.dsClassRecordStudents.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwActiveStudentsBindingSource
            // 
            this.vwActiveStudentsBindingSource.DataMember = "vwActiveStudents";
            this.vwActiveStudentsBindingSource.DataSource = this.dsClassRecordStudents;
            // 
            // vwActiveStudentsTableAdapter
            // 
            this.vwActiveStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDataGridViewTextBoxColumn
            // 
            this.studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn.HeaderText = "Student";
            this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            this.studentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsClassRecordData
            // 
            this.dsClassRecordData.DataSetName = "dsClassRecordData";
            this.dsClassRecordData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwActiveStudentsRecordBindingSource
            // 
            this.vwActiveStudentsRecordBindingSource.DataMember = "vwActiveStudentsRecord";
            this.vwActiveStudentsRecordBindingSource.DataSource = this.dsClassRecordData;
            // 
            // vwActiveStudentsRecordTableAdapter
            // 
            this.vwActiveStudentsRecordTableAdapter.ClearBeforeFill = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // scheduleDataGridViewTextBoxColumn
            // 
            this.scheduleDataGridViewTextBoxColumn.DataPropertyName = "Schedule";
            this.scheduleDataGridViewTextBoxColumn.HeaderText = "Schedule";
            this.scheduleDataGridViewTextBoxColumn.Name = "scheduleDataGridViewTextBoxColumn";
            this.scheduleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // questionnaireDataGridViewTextBoxColumn
            // 
            this.questionnaireDataGridViewTextBoxColumn.DataPropertyName = "Questionnaire";
            this.questionnaireDataGridViewTextBoxColumn.HeaderText = "Questionnaire";
            this.questionnaireDataGridViewTextBoxColumn.Name = "questionnaireDataGridViewTextBoxColumn";
            this.questionnaireDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.scoreDataGridViewTextBoxColumn.Width = 60;
            // 
            // timeFinishedDataGridViewTextBoxColumn
            // 
            this.timeFinishedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.timeFinishedDataGridViewTextBoxColumn.DataPropertyName = "Time Finished";
            this.timeFinishedDataGridViewTextBoxColumn.HeaderText = "Time Finished";
            this.timeFinishedDataGridViewTextBoxColumn.Name = "timeFinishedDataGridViewTextBoxColumn";
            this.timeFinishedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // percentageDataGridViewTextBoxColumn
            // 
            this.percentageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.percentageDataGridViewTextBoxColumn.DataPropertyName = "Percentage";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.percentageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.percentageDataGridViewTextBoxColumn.HeaderText = "Percentage";
            this.percentageDataGridViewTextBoxColumn.Name = "percentageDataGridViewTextBoxColumn";
            this.percentageDataGridViewTextBoxColumn.ReadOnly = true;
            this.percentageDataGridViewTextBoxColumn.Width = 80;
            // 
            // frmClassRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 569);
            this.Controls.Add(this.panelClassRecord);
            this.Name = "frmClassRecord";
            this.Text = "frmClassRecord";
            this.Load += new System.EventHandler(this.frmClassRecord_Load);
            this.panelClassRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCRStudentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCRStudents)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsClassRecordStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwActiveStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClassRecordData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwActiveStudentsRecordBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClassRecord;
        public System.Windows.Forms.DataGridView dgCRStudentData;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.DataGridView dgCRStudents;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private dsClassRecordStudents dsClassRecordStudents;
        private System.Windows.Forms.BindingSource vwActiveStudentsBindingSource;
        private dsClassRecordStudentsTableAdapters.vwActiveStudentsTableAdapter vwActiveStudentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private dsClassRecordData dsClassRecordData;
        private System.Windows.Forms.BindingSource vwActiveStudentsRecordBindingSource;
        private dsClassRecordDataTableAdapters.vwActiveStudentsRecordTableAdapter vwActiveStudentsRecordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionnaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeFinishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageDataGridViewTextBoxColumn;

    }
}