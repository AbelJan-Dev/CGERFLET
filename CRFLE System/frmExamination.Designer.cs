namespace CRFLE_System
{
    partial class frmExamination
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelExamination = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgExaminationSchedule = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionnaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwExaminationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsExamination = new CRFLE_System.dsExamination();
            this.panel20 = new System.Windows.Forms.Panel();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewSched = new DevExpress.XtraEditors.SimpleButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Calendar = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vwExaminationsTableAdapter = new CRFLE_System.dsExaminationTableAdapters.vwExaminationsTableAdapter();
            this.panelExamination.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExaminationSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwExaminationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExamination)).BeginInit();
            this.panel20.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Calendar.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelExamination
            // 
            this.panelExamination.Controls.Add(this.panel7);
            this.panelExamination.Controls.Add(this.panel5);
            this.panelExamination.Controls.Add(this.panel4);
            this.panelExamination.Controls.Add(this.panel3);
            this.panelExamination.Controls.Add(this.panel2);
            this.panelExamination.Controls.Add(this.panel1);
            this.panelExamination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExamination.Location = new System.Drawing.Point(0, 0);
            this.panelExamination.Name = "panelExamination";
            this.panelExamination.Size = new System.Drawing.Size(982, 569);
            this.panelExamination.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgExaminationSchedule);
            this.panel7.Controls.Add(this.panel20);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(50, 40);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(442, 529);
            this.panel7.TabIndex = 5;
            // 
            // dgExaminationSchedule
            // 
            this.dgExaminationSchedule.AllowUserToAddRows = false;
            this.dgExaminationSchedule.AllowUserToDeleteRows = false;
            this.dgExaminationSchedule.AllowUserToResizeColumns = false;
            this.dgExaminationSchedule.AllowUserToResizeRows = false;
            this.dgExaminationSchedule.AutoGenerateColumns = false;
            this.dgExaminationSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgExaminationSchedule.BackgroundColor = System.Drawing.Color.White;
            this.dgExaminationSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgExaminationSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgExaminationSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExaminationSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.questionnaireDataGridViewTextBoxColumn});
            this.dgExaminationSchedule.DataSource = this.vwExaminationsBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgExaminationSchedule.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgExaminationSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgExaminationSchedule.GridColor = System.Drawing.Color.Silver;
            this.dgExaminationSchedule.Location = new System.Drawing.Point(0, 0);
            this.dgExaminationSchedule.MultiSelect = false;
            this.dgExaminationSchedule.Name = "dgExaminationSchedule";
            this.dgExaminationSchedule.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgExaminationSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgExaminationSchedule.RowHeadersVisible = false;
            this.dgExaminationSchedule.RowHeadersWidth = 20;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.dgExaminationSchedule.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgExaminationSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgExaminationSchedule.Size = new System.Drawing.Size(442, 452);
            this.dgExaminationSchedule.TabIndex = 6;
            this.dgExaminationSchedule.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgExaminationSchedule_CellDoubleClick);
            this.dgExaminationSchedule.SelectionChanged += new System.EventHandler(this.dgExaminationSchedule_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "Start Time";
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.startTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.startTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            this.durationDataGridViewTextBoxColumn.Visible = false;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "End Time";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "End Time";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.endTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // questionnaireDataGridViewTextBoxColumn
            // 
            this.questionnaireDataGridViewTextBoxColumn.DataPropertyName = "Questionnaire";
            this.questionnaireDataGridViewTextBoxColumn.HeaderText = "Questionnaire";
            this.questionnaireDataGridViewTextBoxColumn.Name = "questionnaireDataGridViewTextBoxColumn";
            this.questionnaireDataGridViewTextBoxColumn.ReadOnly = true;
            this.questionnaireDataGridViewTextBoxColumn.Visible = false;
            // 
            // vwExaminationsBindingSource
            // 
            this.vwExaminationsBindingSource.DataMember = "vwExaminations";
            this.vwExaminationsBindingSource.DataSource = this.dsExamination;
            // 
            // dsExamination
            // 
            this.dsExamination.DataSetName = "dsExamination";
            this.dsExamination.EnforceConstraints = false;
            this.dsExamination.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.btnCancel);
            this.panel20.Controls.Add(this.btnNewSched);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel20.Location = new System.Drawing.Point(0, 452);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(442, 77);
            this.panel20.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Appearance.Options.UseForeColor = true;
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCancel.Location = new System.Drawing.Point(139, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnCancel.Size = new System.Drawing.Size(122, 40);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNewSched
            // 
            this.btnNewSched.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnNewSched.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSched.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnNewSched.Appearance.Options.UseBackColor = true;
            this.btnNewSched.Appearance.Options.UseFont = true;
            this.btnNewSched.Appearance.Options.UseForeColor = true;
            this.btnNewSched.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnNewSched.Location = new System.Drawing.Point(6, 15);
            this.btnNewSched.Name = "btnNewSched";
            this.btnNewSched.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnNewSched.Size = new System.Drawing.Size(127, 40);
            this.btnNewSched.TabIndex = 18;
            this.btnNewSched.Text = "NEW SCHEDULE";
            this.btnNewSched.Click += new System.EventHandler(this.btnNewSched_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(492, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 529);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Calendar);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(502, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(430, 529);
            this.panel4.TabIndex = 3;
            // 
            // Calendar
            // 
            this.Calendar.AllowAnimatedContentChange = true;
            this.Calendar.AutoSize = false;
            this.Calendar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Calendar.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.Calendar.CalendarAppearance.DayCellSelected.BackColor = System.Drawing.Color.Navy;
            this.Calendar.CalendarAppearance.DayCellSelected.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Calendar.CalendarAppearance.DayCellSelected.ForeColor = System.Drawing.Color.White;
            this.Calendar.CalendarAppearance.DayCellSelected.Options.UseBackColor = true;
            this.Calendar.CalendarAppearance.DayCellSelected.Options.UseFont = true;
            this.Calendar.CalendarAppearance.DayCellSelected.Options.UseForeColor = true;
            this.Calendar.CalendarAppearance.DayCellToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.Calendar.CalendarAppearance.DayCellToday.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Calendar.CalendarAppearance.DayCellToday.ForeColor = System.Drawing.Color.White;
            this.Calendar.CalendarAppearance.DayCellToday.Options.UseBackColor = true;
            this.Calendar.CalendarAppearance.DayCellToday.Options.UseFont = true;
            this.Calendar.CalendarAppearance.DayCellToday.Options.UseForeColor = true;
            this.Calendar.CalendarAppearance.Header.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Calendar.CalendarAppearance.Header.Options.UseFont = true;
            this.Calendar.CalendarAppearance.WeekDay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Calendar.CalendarAppearance.WeekDay.Options.UseFont = true;
            this.Calendar.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Calendar.CellSize = new System.Drawing.Size(55, 55);
            this.Calendar.DateTime = new System.DateTime(((long)(0)));
            this.Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Calendar.EditValue = null;
            this.Calendar.Enabled = false;
            this.Calendar.Location = new System.Drawing.Point(0, 0);
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowMonthNavigationButtons = DevExpress.Utils.DefaultBoolean.False;
            this.Calendar.ShowTodayButton = false;
            this.Calendar.Size = new System.Drawing.Size(430, 452);
            this.Calendar.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 452);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(430, 77);
            this.panel6.TabIndex = 0;
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
            // vwExaminationsTableAdapter
            // 
            this.vwExaminationsTableAdapter.ClearBeforeFill = true;
            // 
            // frmExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 569);
            this.Controls.Add(this.panelExamination);
            this.Name = "frmExamination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmExamination_Load);
            this.panelExamination.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgExaminationSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwExaminationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExamination)).EndInit();
            this.panel20.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Calendar.CalendarTimeProperties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelExamination;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.Controls.CalendarControl Calendar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel20;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnNewSched;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.DataGridView dgExaminationSchedule;
        private dsExamination dsExamination;
        private System.Windows.Forms.BindingSource vwExaminationsBindingSource;
        private dsExaminationTableAdapters.vwExaminationsTableAdapter vwExaminationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionnaireDataGridViewTextBoxColumn;

    }
}