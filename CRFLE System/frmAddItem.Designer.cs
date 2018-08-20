namespace CRFLE_System
{
    partial class frmAddItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.tblCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCategory = new CRFLE_System.dsCategory();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChoice4 = new DevExpress.XtraEditors.TextEdit();
            this.txtChoice2 = new DevExpress.XtraEditors.TextEdit();
            this.txtChoice3 = new DevExpress.XtraEditors.TextEdit();
            this.txtChoice1 = new DevExpress.XtraEditors.TextEdit();
            this.flag4 = new System.Windows.Forms.RadioButton();
            this.flag2 = new System.Windows.Forms.RadioButton();
            this.flag3 = new System.Windows.Forms.RadioButton();
            this.flag1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.tblCategoryTableAdapter = new CRFLE_System.dsCategoryTableAdapters.tblCategoryTableAdapter();
            this.panelErrorQuestion = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelSaved = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rtQuestion = new DevExpress.XtraRichEdit.RichEditControl();
            this.rtExplanation = new DevExpress.XtraRichEdit.RichEditControl();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoice4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoice2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoice3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoice1.Properties)).BeginInit();
            this.panelErrorQuestion.SuspendLayout();
            this.panelSaved.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 65);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(12, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Add New Item";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 10);
            this.panel2.TabIndex = 1;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DataSource = this.tblCategoryBindingSource;
            this.cmbCategory.DisplayMember = "Category";
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(36, 183);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(185, 29);
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.ValueMember = "ID";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(33, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 125;
            this.label8.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 16);
            this.label4.TabIndex = 123;
            this.label4.Text = "Select the correct answer from the choices before saving.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 16);
            this.label5.TabIndex = 122;
            this.label5.Text = "Make sure all the spellings are typed correctly before saving.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 16);
            this.label6.TabIndex = 121;
            this.label6.Text = "Fill-up all the required information.";
            // 
            // txtChoice4
            // 
            this.txtChoice4.Location = new System.Drawing.Point(311, 483);
            this.txtChoice4.Name = "txtChoice4";
            this.txtChoice4.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtChoice4.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoice4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtChoice4.Properties.Appearance.Options.UseBackColor = true;
            this.txtChoice4.Properties.Appearance.Options.UseFont = true;
            this.txtChoice4.Properties.Appearance.Options.UseForeColor = true;
            this.txtChoice4.Properties.AutoHeight = false;
            this.txtChoice4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtChoice4.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtChoice4.Properties.MaxLength = 400;
            this.txtChoice4.Properties.NullValuePrompt = "Choice";
            this.txtChoice4.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtChoice4.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtChoice4.Size = new System.Drawing.Size(184, 27);
            this.txtChoice4.TabIndex = 6;
            this.txtChoice4.TextChanged += new System.EventHandler(this.txtChoice4_TextChanged);
            // 
            // txtChoice2
            // 
            this.txtChoice2.Location = new System.Drawing.Point(311, 450);
            this.txtChoice2.Name = "txtChoice2";
            this.txtChoice2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtChoice2.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoice2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtChoice2.Properties.Appearance.Options.UseBackColor = true;
            this.txtChoice2.Properties.Appearance.Options.UseFont = true;
            this.txtChoice2.Properties.Appearance.Options.UseForeColor = true;
            this.txtChoice2.Properties.AutoHeight = false;
            this.txtChoice2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtChoice2.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtChoice2.Properties.MaxLength = 400;
            this.txtChoice2.Properties.NullValuePrompt = "Choice";
            this.txtChoice2.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtChoice2.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtChoice2.Size = new System.Drawing.Size(184, 27);
            this.txtChoice2.TabIndex = 4;
            this.txtChoice2.TextChanged += new System.EventHandler(this.txtChoice2_TextChanged);
            // 
            // txtChoice3
            // 
            this.txtChoice3.Location = new System.Drawing.Point(72, 483);
            this.txtChoice3.Name = "txtChoice3";
            this.txtChoice3.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtChoice3.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoice3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtChoice3.Properties.Appearance.Options.UseBackColor = true;
            this.txtChoice3.Properties.Appearance.Options.UseFont = true;
            this.txtChoice3.Properties.Appearance.Options.UseForeColor = true;
            this.txtChoice3.Properties.AutoHeight = false;
            this.txtChoice3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtChoice3.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtChoice3.Properties.MaxLength = 400;
            this.txtChoice3.Properties.NullValuePrompt = "Choice";
            this.txtChoice3.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtChoice3.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtChoice3.Size = new System.Drawing.Size(184, 27);
            this.txtChoice3.TabIndex = 5;
            this.txtChoice3.TextChanged += new System.EventHandler(this.txtChoice3_TextChanged);
            // 
            // txtChoice1
            // 
            this.txtChoice1.Location = new System.Drawing.Point(72, 450);
            this.txtChoice1.Name = "txtChoice1";
            this.txtChoice1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtChoice1.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoice1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtChoice1.Properties.Appearance.Options.UseBackColor = true;
            this.txtChoice1.Properties.Appearance.Options.UseFont = true;
            this.txtChoice1.Properties.Appearance.Options.UseForeColor = true;
            this.txtChoice1.Properties.AutoHeight = false;
            this.txtChoice1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtChoice1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtChoice1.Properties.MaxLength = 400;
            this.txtChoice1.Properties.NullValuePrompt = "Choice";
            this.txtChoice1.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtChoice1.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtChoice1.Size = new System.Drawing.Size(184, 27);
            this.txtChoice1.TabIndex = 3;
            this.txtChoice1.TextChanged += new System.EventHandler(this.txtChoice1_TextChanged);
            // 
            // flag4
            // 
            this.flag4.AutoSize = true;
            this.flag4.Location = new System.Drawing.Point(275, 491);
            this.flag4.Name = "flag4";
            this.flag4.Size = new System.Drawing.Size(14, 13);
            this.flag4.TabIndex = 120;
            this.flag4.UseVisualStyleBackColor = true;
            // 
            // flag2
            // 
            this.flag2.AutoSize = true;
            this.flag2.Location = new System.Drawing.Point(275, 460);
            this.flag2.Name = "flag2";
            this.flag2.Size = new System.Drawing.Size(14, 13);
            this.flag2.TabIndex = 119;
            this.flag2.UseVisualStyleBackColor = true;
            // 
            // flag3
            // 
            this.flag3.AutoSize = true;
            this.flag3.Location = new System.Drawing.Point(36, 491);
            this.flag3.Name = "flag3";
            this.flag3.Size = new System.Drawing.Size(14, 13);
            this.flag3.TabIndex = 117;
            this.flag3.UseVisualStyleBackColor = true;
            // 
            // flag1
            // 
            this.flag1.AutoSize = true;
            this.flag1.Checked = true;
            this.flag1.Location = new System.Drawing.Point(36, 458);
            this.flag1.Name = "flag1";
            this.flag1.Size = new System.Drawing.Size(14, 13);
            this.flag1.TabIndex = 116;
            this.flag1.TabStop = true;
            this.flag1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(33, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 115;
            this.label3.Text = "Choices:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(33, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 114;
            this.label2.Text = "Explanation:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(33, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 113;
            this.label1.Text = "Question:";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSave.Location = new System.Drawing.Point(71, 533);
            this.btnSave.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnSave.Size = new System.Drawing.Size(188, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(270, 533);
            this.btnCancel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnCancel.Size = new System.Drawing.Size(188, 40);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tblCategoryTableAdapter
            // 
            this.tblCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // panelErrorQuestion
            // 
            this.panelErrorQuestion.BackColor = System.Drawing.Color.Red;
            this.panelErrorQuestion.Controls.Add(this.label7);
            this.panelErrorQuestion.Location = new System.Drawing.Point(0, 64);
            this.panelErrorQuestion.Name = "panelErrorQuestion";
            this.panelErrorQuestion.Size = new System.Drawing.Size(531, 40);
            this.panelErrorQuestion.TabIndex = 127;
            this.panelErrorQuestion.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(114, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 17);
            this.label7.TabIndex = 68;
            this.label7.Text = "Oops! Please supply all required data.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSaved
            // 
            this.panelSaved.BackColor = System.Drawing.Color.LimeGreen;
            this.panelSaved.Controls.Add(this.label10);
            this.panelSaved.Location = new System.Drawing.Point(0, 64);
            this.panelSaved.Name = "panelSaved";
            this.panelSaved.Size = new System.Drawing.Size(531, 40);
            this.panelSaved.TabIndex = 129;
            this.panelSaved.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(189, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 17);
            this.label10.TabIndex = 68;
            this.label10.Text = "Successfully saved.";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDifficulty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDifficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard"});
            this.cmbDifficulty.Location = new System.Drawing.Point(237, 183);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(122, 29);
            this.cmbDifficulty.TabIndex = 130;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(234, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 131;
            this.label11.Text = "Difficulty:";
            // 
            // rtQuestion
            // 
            this.rtQuestion.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.rtQuestion.Appearance.Text.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtQuestion.Appearance.Text.ForeColor = System.Drawing.Color.Black;
            this.rtQuestion.Appearance.Text.Options.UseFont = true;
            this.rtQuestion.Appearance.Text.Options.UseForeColor = true;
            this.rtQuestion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rtQuestion.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Document;
            this.rtQuestion.Location = new System.Drawing.Point(36, 236);
            this.rtQuestion.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.rtQuestion.LookAndFeel.UseDefaultLookAndFeel = false;
            this.rtQuestion.Name = "rtQuestion";
            this.rtQuestion.Size = new System.Drawing.Size(459, 81);
            this.rtQuestion.TabIndex = 132;
            // 
            // rtExplanation
            // 
            this.rtExplanation.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.rtExplanation.Appearance.Text.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtExplanation.Appearance.Text.ForeColor = System.Drawing.Color.Black;
            this.rtExplanation.Appearance.Text.Options.UseFont = true;
            this.rtExplanation.Appearance.Text.Options.UseForeColor = true;
            this.rtExplanation.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rtExplanation.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Document;
            this.rtExplanation.Location = new System.Drawing.Point(36, 343);
            this.rtExplanation.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.rtExplanation.LookAndFeel.UseDefaultLookAndFeel = false;
            this.rtExplanation.Name = "rtExplanation";
            this.rtExplanation.Size = new System.Drawing.Size(459, 81);
            this.rtExplanation.TabIndex = 133;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(49, 454);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 19);
            this.label12.TabIndex = 134;
            this.label12.Text = "A.";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(289, 455);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 19);
            this.label13.TabIndex = 135;
            this.label13.Text = "B.";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(49, 487);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 19);
            this.label14.TabIndex = 136;
            this.label14.Text = "C.";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(289, 488);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 19);
            this.label15.TabIndex = 137;
            this.label15.Text = "D.";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // frmAddItem
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 593);
            this.Controls.Add(this.rtExplanation);
            this.Controls.Add(this.rtQuestion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.panelSaved);
            this.Controls.Add(this.panelErrorQuestion);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtChoice4);
            this.Controls.Add(this.txtChoice2);
            this.Controls.Add(this.txtChoice3);
            this.Controls.Add(this.txtChoice1);
            this.Controls.Add(this.flag4);
            this.Controls.Add(this.flag2);
            this.Controls.Add(this.flag3);
            this.Controls.Add(this.flag1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoice4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoice2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoice3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoice1.Properties)).EndInit();
            this.panelErrorQuestion.ResumeLayout(false);
            this.panelSaved.ResumeLayout(false);
            this.panelSaved.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ComboBox cmbCategory;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtChoice4;
        private DevExpress.XtraEditors.TextEdit txtChoice2;
        private DevExpress.XtraEditors.TextEdit txtChoice3;
        private DevExpress.XtraEditors.TextEdit txtChoice1;
        private System.Windows.Forms.RadioButton flag4;
        private System.Windows.Forms.RadioButton flag2;
        private System.Windows.Forms.RadioButton flag3;
        private System.Windows.Forms.RadioButton flag1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private dsCategory dsCategory;
        private System.Windows.Forms.BindingSource tblCategoryBindingSource;
        private dsCategoryTableAdapters.tblCategoryTableAdapter tblCategoryTableAdapter;
        private System.Windows.Forms.Panel panelErrorQuestion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelSaved;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmbDifficulty;
        public System.Windows.Forms.Label label11;
        public DevExpress.XtraRichEdit.RichEditControl rtQuestion;
        public DevExpress.XtraRichEdit.RichEditControl rtExplanation;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;

    }
}