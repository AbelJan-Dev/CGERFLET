namespace CRFLE_System
{
    partial class frmQuestionBank
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuestionBank = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dgQuestionBank = new System.Windows.Forms.DataGridView();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difficultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.explanationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwQuestionForDataGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQuestionBank = new CRFLE_System.dsQuestionBank();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.rtQuestion = new DevExpress.XtraRichEdit.RichEditControl();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.txtchoice4 = new DevExpress.XtraEditors.TextEdit();
            this.txtchoice3 = new DevExpress.XtraEditors.TextEdit();
            this.txtchoice2 = new DevExpress.XtraEditors.TextEdit();
            this.txtchoice1 = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.chkFilter = new DevExpress.XtraEditors.CheckEdit();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.tblCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCategory = new CRFLE_System.dsCategory();
            this.panel20 = new System.Windows.Forms.Panel();
            this.btnAddQuestion = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefreshList = new DevExpress.XtraEditors.SimpleButton();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.tblCategoryTableAdapter = new CRFLE_System.dsCategoryTableAdapters.tblCategoryTableAdapter();
            this.vwQuestionForDataGridTableAdapter = new CRFLE_System.dsQuestionBankTableAdapters.vwQuestionForDataGridTableAdapter();
            this.panelQuestionBank.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuestionBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwQuestionForDataGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQuestionBank)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtchoice4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtchoice3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtchoice2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtchoice1.Properties)).BeginInit();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategory)).BeginInit();
            this.panel20.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuestionBank
            // 
            this.panelQuestionBank.Controls.Add(this.panel13);
            this.panelQuestionBank.Controls.Add(this.panel22);
            this.panelQuestionBank.Controls.Add(this.panel23);
            this.panelQuestionBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuestionBank.Location = new System.Drawing.Point(0, 0);
            this.panelQuestionBank.Name = "panelQuestionBank";
            this.panelQuestionBank.Size = new System.Drawing.Size(982, 569);
            this.panelQuestionBank.TabIndex = 11;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.dgQuestionBank);
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Controls.Add(this.panel19);
            this.panel13.Controls.Add(this.panel20);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(50, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(882, 569);
            this.panel13.TabIndex = 5;
            // 
            // dgQuestionBank
            // 
            this.dgQuestionBank.AllowUserToAddRows = false;
            this.dgQuestionBank.AllowUserToDeleteRows = false;
            this.dgQuestionBank.AllowUserToResizeColumns = false;
            this.dgQuestionBank.AllowUserToResizeRows = false;
            this.dgQuestionBank.AutoGenerateColumns = false;
            this.dgQuestionBank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgQuestionBank.BackgroundColor = System.Drawing.Color.White;
            this.dgQuestionBank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgQuestionBank.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgQuestionBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQuestionBank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.answerDataGridViewTextBoxColumn,
            this.difficultyDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.explanationDataGridViewTextBoxColumn});
            this.dgQuestionBank.DataSource = this.vwQuestionForDataGridBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgQuestionBank.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgQuestionBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgQuestionBank.GridColor = System.Drawing.Color.Silver;
            this.dgQuestionBank.Location = new System.Drawing.Point(0, 73);
            this.dgQuestionBank.MultiSelect = false;
            this.dgQuestionBank.Name = "dgQuestionBank";
            this.dgQuestionBank.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgQuestionBank.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgQuestionBank.RowHeadersVisible = false;
            this.dgQuestionBank.RowHeadersWidth = 20;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.dgQuestionBank.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgQuestionBank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgQuestionBank.Size = new System.Drawing.Size(559, 416);
            this.dgQuestionBank.TabIndex = 5;
            this.dgQuestionBank.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgQuestionBank_CellClick);
            this.dgQuestionBank.SelectionChanged += new System.EventHandler(this.dgQuestionBank_SelectionChanged);
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "Question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "Question";
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            this.questionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // answerDataGridViewTextBoxColumn
            // 
            this.answerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.answerDataGridViewTextBoxColumn.DataPropertyName = "Answer";
            this.answerDataGridViewTextBoxColumn.HeaderText = "Answer";
            this.answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            this.answerDataGridViewTextBoxColumn.ReadOnly = true;
            this.answerDataGridViewTextBoxColumn.Width = 140;
            // 
            // difficultyDataGridViewTextBoxColumn
            // 
            this.difficultyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.difficultyDataGridViewTextBoxColumn.DataPropertyName = "Difficulty";
            this.difficultyDataGridViewTextBoxColumn.HeaderText = "Difficulty";
            this.difficultyDataGridViewTextBoxColumn.Name = "difficultyDataGridViewTextBoxColumn";
            this.difficultyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // explanationDataGridViewTextBoxColumn
            // 
            this.explanationDataGridViewTextBoxColumn.DataPropertyName = "Explanation";
            this.explanationDataGridViewTextBoxColumn.HeaderText = "Explanation";
            this.explanationDataGridViewTextBoxColumn.Name = "explanationDataGridViewTextBoxColumn";
            this.explanationDataGridViewTextBoxColumn.ReadOnly = true;
            this.explanationDataGridViewTextBoxColumn.Visible = false;
            // 
            // vwQuestionForDataGridBindingSource
            // 
            this.vwQuestionForDataGridBindingSource.DataMember = "vwQuestionForDataGrid";
            this.vwQuestionForDataGridBindingSource.DataSource = this.dsQuestionBank;
            // 
            // dsQuestionBank
            // 
            this.dsQuestionBank.DataSetName = "dsQuestionBank";
            this.dsQuestionBank.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(559, 73);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(15, 416);
            this.panel14.TabIndex = 4;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.panel17);
            this.panel15.Controls.Add(this.panel18);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(574, 73);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(308, 416);
            this.panel15.TabIndex = 3;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.rtQuestion);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(0, 25);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(308, 174);
            this.panel16.TabIndex = 12;
            // 
            // rtQuestion
            // 
            this.rtQuestion.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.rtQuestion.Appearance.Text.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtQuestion.Appearance.Text.Options.UseFont = true;
            this.rtQuestion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rtQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtQuestion.Enabled = false;
            this.rtQuestion.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Document;
            this.rtQuestion.Location = new System.Drawing.Point(0, 0);
            this.rtQuestion.Name = "rtQuestion";
            this.rtQuestion.Size = new System.Drawing.Size(308, 174);
            this.rtQuestion.TabIndex = 8;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label1);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(308, 25);
            this.panel17.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(-4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Question:";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btnUpdate);
            this.panel18.Controls.Add(this.btnDelete);
            this.panel18.Controls.Add(this.txtchoice4);
            this.panel18.Controls.Add(this.txtchoice3);
            this.panel18.Controls.Add(this.txtchoice2);
            this.panel18.Controls.Add(this.txtchoice1);
            this.panel18.Controls.Add(this.label2);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel18.Location = new System.Drawing.Point(0, 199);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(308, 217);
            this.panel18.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Appearance.Options.UseBackColor = true;
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Appearance.Options.UseForeColor = true;
            this.btnUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnUpdate.Location = new System.Drawing.Point(18, 164);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnUpdate.Size = new System.Drawing.Size(125, 40);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "UPDATE ITEM";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnDelete.Location = new System.Drawing.Point(149, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnDelete.Size = new System.Drawing.Size(125, 40);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "DELETE ITEM";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtchoice4
            // 
            this.txtchoice4.EditValue = "";
            this.txtchoice4.Enabled = false;
            this.txtchoice4.Location = new System.Drawing.Point(0, 124);
            this.txtchoice4.Name = "txtchoice4";
            this.txtchoice4.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtchoice4.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchoice4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtchoice4.Properties.Appearance.Options.UseBackColor = true;
            this.txtchoice4.Properties.Appearance.Options.UseFont = true;
            this.txtchoice4.Properties.Appearance.Options.UseForeColor = true;
            this.txtchoice4.Properties.AutoHeight = false;
            this.txtchoice4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtchoice4.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtchoice4.Properties.Mask.EditMask = "[a-zA-Z ]+";
            this.txtchoice4.Properties.Mask.PlaceHolder = ' ';
            this.txtchoice4.Properties.NullValuePrompt = "Choice";
            this.txtchoice4.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtchoice4.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtchoice4.Size = new System.Drawing.Size(291, 27);
            this.txtchoice4.TabIndex = 25;
            // 
            // txtchoice3
            // 
            this.txtchoice3.EditValue = "";
            this.txtchoice3.Enabled = false;
            this.txtchoice3.Location = new System.Drawing.Point(0, 91);
            this.txtchoice3.Name = "txtchoice3";
            this.txtchoice3.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtchoice3.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchoice3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtchoice3.Properties.Appearance.Options.UseBackColor = true;
            this.txtchoice3.Properties.Appearance.Options.UseFont = true;
            this.txtchoice3.Properties.Appearance.Options.UseForeColor = true;
            this.txtchoice3.Properties.AutoHeight = false;
            this.txtchoice3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtchoice3.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtchoice3.Properties.Mask.EditMask = "[a-zA-Z ]+";
            this.txtchoice3.Properties.Mask.PlaceHolder = ' ';
            this.txtchoice3.Properties.NullValuePrompt = "Choice";
            this.txtchoice3.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtchoice3.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtchoice3.Size = new System.Drawing.Size(291, 27);
            this.txtchoice3.TabIndex = 24;
            // 
            // txtchoice2
            // 
            this.txtchoice2.EditValue = "";
            this.txtchoice2.Enabled = false;
            this.txtchoice2.Location = new System.Drawing.Point(0, 58);
            this.txtchoice2.Name = "txtchoice2";
            this.txtchoice2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtchoice2.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchoice2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtchoice2.Properties.Appearance.Options.UseBackColor = true;
            this.txtchoice2.Properties.Appearance.Options.UseFont = true;
            this.txtchoice2.Properties.Appearance.Options.UseForeColor = true;
            this.txtchoice2.Properties.AutoHeight = false;
            this.txtchoice2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtchoice2.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtchoice2.Properties.Mask.EditMask = "[a-zA-Z ]+";
            this.txtchoice2.Properties.Mask.PlaceHolder = ' ';
            this.txtchoice2.Properties.NullValuePrompt = "Choice";
            this.txtchoice2.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtchoice2.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtchoice2.Size = new System.Drawing.Size(291, 27);
            this.txtchoice2.TabIndex = 23;
            // 
            // txtchoice1
            // 
            this.txtchoice1.EditValue = "";
            this.txtchoice1.Enabled = false;
            this.txtchoice1.Location = new System.Drawing.Point(0, 25);
            this.txtchoice1.Name = "txtchoice1";
            this.txtchoice1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtchoice1.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchoice1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtchoice1.Properties.Appearance.Options.UseBackColor = true;
            this.txtchoice1.Properties.Appearance.Options.UseFont = true;
            this.txtchoice1.Properties.Appearance.Options.UseForeColor = true;
            this.txtchoice1.Properties.AutoHeight = false;
            this.txtchoice1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtchoice1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtchoice1.Properties.Mask.EditMask = "[a-zA-Z ]+";
            this.txtchoice1.Properties.Mask.PlaceHolder = ' ';
            this.txtchoice1.Properties.NullValuePrompt = "Choice";
            this.txtchoice1.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtchoice1.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtchoice1.Size = new System.Drawing.Size(291, 27);
            this.txtchoice1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(-4, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Choice:";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.btnSearch);
            this.panel19.Controls.Add(this.txtSearch);
            this.panel19.Controls.Add(this.chkFilter);
            this.panel19.Controls.Add(this.cmbCategory);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(882, 73);
            this.panel19.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Appearance.Options.UseBackColor = true;
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Appearance.Options.UseForeColor = true;
            this.btnSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSearch.Location = new System.Drawing.Point(401, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnSearch.Size = new System.Drawing.Size(80, 31);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(171, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Properties.Appearance.Options.UseBackColor = true;
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Properties.Appearance.Options.UseForeColor = true;
            this.txtSearch.Properties.AutoHeight = false;
            this.txtSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtSearch.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtSearch.Properties.Mask.EditMask = "[a-zA-Z ]+";
            this.txtSearch.Properties.Mask.PlaceHolder = ' ';
            this.txtSearch.Properties.NullValuePrompt = "Search...";
            this.txtSearch.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtSearch.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtSearch.Size = new System.Drawing.Size(224, 29);
            this.txtSearch.TabIndex = 34;
            // 
            // chkFilter
            // 
            this.chkFilter.Location = new System.Drawing.Point(6, 34);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Properties.AllowFocused = false;
            this.chkFilter.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFilter.Properties.Appearance.Options.UseFont = true;
            this.chkFilter.Properties.AutoWidth = true;
            this.chkFilter.Properties.Caption = "Filter";
            this.chkFilter.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.chkFilter.Size = new System.Drawing.Size(52, 21);
            this.chkFilter.TabIndex = 33;
            this.chkFilter.CheckedChanged += new System.EventHandler(this.chkFilter_CheckedChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DataSource = this.tblCategoryBindingSource;
            this.cmbCategory.DisplayMember = "Category";
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Enabled = false;
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(61, 29);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(104, 29);
            this.cmbCategory.TabIndex = 24;
            this.cmbCategory.ValueMember = "ID";
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // tblCategoryBindingSource
            // 
            this.tblCategoryBindingSource.DataMember = "tblCategory";
            this.tblCategoryBindingSource.DataSource = this.dsCategory;
            // 
            // dsCategory
            // 
            this.dsCategory.DataSetName = "dsCategory";
            this.dsCategory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.btnAddQuestion);
            this.panel20.Controls.Add(this.btnRefreshList);
            this.panel20.Controls.Add(this.panel21);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel20.Location = new System.Drawing.Point(0, 489);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(882, 80);
            this.panel20.TabIndex = 1;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnAddQuestion.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAddQuestion.Appearance.Options.UseBackColor = true;
            this.btnAddQuestion.Appearance.Options.UseFont = true;
            this.btnAddQuestion.Appearance.Options.UseForeColor = true;
            this.btnAddQuestion.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAddQuestion.Location = new System.Drawing.Point(122, 18);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnAddQuestion.Size = new System.Drawing.Size(110, 40);
            this.btnAddQuestion.TabIndex = 19;
            this.btnAddQuestion.Text = "ADD NEW";
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnRefreshList.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshList.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnRefreshList.Appearance.Options.UseBackColor = true;
            this.btnRefreshList.Appearance.Options.UseFont = true;
            this.btnRefreshList.Appearance.Options.UseForeColor = true;
            this.btnRefreshList.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnRefreshList.Location = new System.Drawing.Point(6, 18);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnRefreshList.Size = new System.Drawing.Size(110, 40);
            this.btnRefreshList.TabIndex = 18;
            this.btnRefreshList.Text = "REFRESH LIST";
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // panel21
            // 
            this.panel21.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel21.Location = new System.Drawing.Point(519, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(363, 80);
            this.panel21.TabIndex = 13;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.SystemColors.Control;
            this.panel22.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel22.Location = new System.Drawing.Point(932, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(50, 569);
            this.panel22.TabIndex = 4;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.SystemColors.Control;
            this.panel23.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel23.Location = new System.Drawing.Point(0, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(50, 569);
            this.panel23.TabIndex = 3;
            // 
            // tblCategoryTableAdapter
            // 
            this.tblCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // vwQuestionForDataGridTableAdapter
            // 
            this.vwQuestionForDataGridTableAdapter.ClearBeforeFill = true;
            // 
            // frmQuestionBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 569);
            this.Controls.Add(this.panelQuestionBank);
            this.MinimumSize = new System.Drawing.Size(982, 569);
            this.Name = "frmQuestionBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmQuestionBank_Load);
            this.panelQuestionBank.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgQuestionBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwQuestionForDataGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQuestionBank)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtchoice4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtchoice3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtchoice2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtchoice1.Properties)).EndInit();
            this.panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategory)).EndInit();
            this.panel20.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuestionBank;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel18;
        private DevExpress.XtraEditors.TextEdit txtchoice4;
        private DevExpress.XtraEditors.TextEdit txtchoice3;
        private DevExpress.XtraEditors.TextEdit txtchoice2;
        private DevExpress.XtraEditors.TextEdit txtchoice1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private DevExpress.XtraEditors.SimpleButton btnAddQuestion;
        private DevExpress.XtraEditors.SimpleButton btnRefreshList;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel23;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        public System.Windows.Forms.DataGridView dgQuestionBank;
        public System.Windows.Forms.ComboBox cmbCategory;
        private dsCategory dsCategory;
        private System.Windows.Forms.BindingSource tblCategoryBindingSource;
        private dsCategoryTableAdapters.tblCategoryTableAdapter tblCategoryTableAdapter;
        private DevExpress.XtraEditors.CheckEdit chkFilter;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private dsQuestionBank dsQuestionBank;
        private System.Windows.Forms.BindingSource vwQuestionForDataGridBindingSource;
        private dsQuestionBankTableAdapters.vwQuestionForDataGridTableAdapter vwQuestionForDataGridTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn difficultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn explanationDataGridViewTextBoxColumn;
        public DevExpress.XtraRichEdit.RichEditControl rtQuestion;
    }
}