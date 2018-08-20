namespace CRFLE_System
{
    partial class frmAccounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelAccountTeachers = new System.Windows.Forms.Panel();
            this.dgAccounts = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnUpdateAccount = new DevExpress.XtraEditors.SimpleButton();
            this.txtusername = new DevExpress.XtraEditors.TextEdit();
            this.btnPasswordReset = new DevExpress.XtraEditors.SimpleButton();
            this.txtaddress2 = new DevExpress.XtraEditors.TextEdit();
            this.txtaddress1 = new DevExpress.XtraEditors.TextEdit();
            this.txtage = new DevExpress.XtraEditors.TextEdit();
            this.txtgender = new DevExpress.XtraEditors.TextEdit();
            this.txtfullname = new DevExpress.XtraEditors.TextEdit();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblIDNo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwAccountInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAccountInfo = new CRFLE_System.dsAccountInfo();
            this.vwAccountInfoTableAdapter = new CRFLE_System.dsAccountInfoTableAdapters.vwAccountInfoTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelAccountTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfullname.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwAccountInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccountInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAccountTeachers
            // 
            this.panelAccountTeachers.Controls.Add(this.dgAccounts);
            this.panelAccountTeachers.Controls.Add(this.panel6);
            this.panelAccountTeachers.Controls.Add(this.panel5);
            this.panelAccountTeachers.Controls.Add(this.panel4);
            this.panelAccountTeachers.Controls.Add(this.panel10);
            this.panelAccountTeachers.Controls.Add(this.panel11);
            this.panelAccountTeachers.Controls.Add(this.panel12);
            this.panelAccountTeachers.Location = new System.Drawing.Point(-1, -1);
            this.panelAccountTeachers.Name = "panelAccountTeachers";
            this.panelAccountTeachers.Size = new System.Drawing.Size(984, 571);
            this.panelAccountTeachers.TabIndex = 8;
            // 
            // dgAccounts
            // 
            this.dgAccounts.AllowUserToAddRows = false;
            this.dgAccounts.AllowUserToDeleteRows = false;
            this.dgAccounts.AllowUserToResizeColumns = false;
            this.dgAccounts.AllowUserToResizeRows = false;
            this.dgAccounts.AutoGenerateColumns = false;
            this.dgAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.address1DataGridViewTextBoxColumn,
            this.address2DataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.verifiedDataGridViewCheckBoxColumn});
            this.dgAccounts.DataSource = this.vwAccountInfoBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAccounts.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAccounts.GridColor = System.Drawing.Color.Silver;
            this.dgAccounts.Location = new System.Drawing.Point(50, 40);
            this.dgAccounts.MultiSelect = false;
            this.dgAccounts.Name = "dgAccounts";
            this.dgAccounts.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgAccounts.RowHeadersVisible = false;
            this.dgAccounts.RowHeadersWidth = 20;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.dgAccounts.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccounts.Size = new System.Drawing.Size(569, 461);
            this.dgAccounts.TabIndex = 13;
            this.dgAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAccounts_CellClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(619, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 461);
            this.panel6.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnUpdateAccount);
            this.panel5.Controls.Add(this.txtusername);
            this.panel5.Controls.Add(this.btnPasswordReset);
            this.panel5.Controls.Add(this.txtaddress2);
            this.panel5.Controls.Add(this.txtaddress1);
            this.panel5.Controls.Add(this.txtage);
            this.panel5.Controls.Add(this.txtgender);
            this.panel5.Controls.Add(this.txtfullname);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.lblUserType);
            this.panel5.Controls.Add(this.lblIDNo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(634, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 461);
            this.panel5.TabIndex = 11;
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnUpdateAccount.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAccount.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAccount.Appearance.Options.UseBackColor = true;
            this.btnUpdateAccount.Appearance.Options.UseFont = true;
            this.btnUpdateAccount.Appearance.Options.UseForeColor = true;
            this.btnUpdateAccount.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnUpdateAccount.Location = new System.Drawing.Point(9, 418);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnUpdateAccount.Size = new System.Drawing.Size(285, 40);
            this.btnUpdateAccount.TabIndex = 18;
            this.btnUpdateAccount.Text = "UPDATE STATUS";
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // txtusername
            // 
            this.txtusername.Enabled = false;
            this.txtusername.Location = new System.Drawing.Point(9, 320);
            this.txtusername.Name = "txtusername";
            this.txtusername.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtusername.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtusername.Properties.Appearance.Options.UseBackColor = true;
            this.txtusername.Properties.Appearance.Options.UseFont = true;
            this.txtusername.Properties.Appearance.Options.UseForeColor = true;
            this.txtusername.Properties.AutoHeight = false;
            this.txtusername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtusername.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtusername.Properties.Mask.EditMask = "[a-zA-Z ]+";
            this.txtusername.Properties.Mask.PlaceHolder = ' ';
            this.txtusername.Properties.NullText = "Username";
            this.txtusername.Properties.NullValuePrompt = "Address";
            this.txtusername.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtusername.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtusername.Size = new System.Drawing.Size(285, 27);
            this.txtusername.TabIndex = 17;
            // 
            // btnPasswordReset
            // 
            this.btnPasswordReset.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnPasswordReset.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswordReset.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnPasswordReset.Appearance.Options.UseBackColor = true;
            this.btnPasswordReset.Appearance.Options.UseFont = true;
            this.btnPasswordReset.Appearance.Options.UseForeColor = true;
            this.btnPasswordReset.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnPasswordReset.Location = new System.Drawing.Point(9, 372);
            this.btnPasswordReset.Name = "btnPasswordReset";
            this.btnPasswordReset.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnPasswordReset.Size = new System.Drawing.Size(285, 40);
            this.btnPasswordReset.TabIndex = 16;
            this.btnPasswordReset.Text = "RESET PASSWORD";
            this.btnPasswordReset.Click += new System.EventHandler(this.btnPasswordReset_Click);
            // 
            // txtaddress2
            // 
            this.txtaddress2.Enabled = false;
            this.txtaddress2.Location = new System.Drawing.Point(9, 268);
            this.txtaddress2.Name = "txtaddress2";
            this.txtaddress2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtaddress2.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtaddress2.Properties.Appearance.Options.UseBackColor = true;
            this.txtaddress2.Properties.Appearance.Options.UseFont = true;
            this.txtaddress2.Properties.Appearance.Options.UseForeColor = true;
            this.txtaddress2.Properties.AutoHeight = false;
            this.txtaddress2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtaddress2.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtaddress2.Properties.Mask.EditMask = "[a-zA-Z ]+";
            this.txtaddress2.Properties.Mask.PlaceHolder = ' ';
            this.txtaddress2.Properties.NullText = "Address";
            this.txtaddress2.Properties.NullValuePrompt = "Address";
            this.txtaddress2.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtaddress2.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtaddress2.Size = new System.Drawing.Size(285, 27);
            this.txtaddress2.TabIndex = 15;
            // 
            // txtaddress1
            // 
            this.txtaddress1.Enabled = false;
            this.txtaddress1.Location = new System.Drawing.Point(9, 235);
            this.txtaddress1.Name = "txtaddress1";
            this.txtaddress1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtaddress1.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtaddress1.Properties.Appearance.Options.UseBackColor = true;
            this.txtaddress1.Properties.Appearance.Options.UseFont = true;
            this.txtaddress1.Properties.Appearance.Options.UseForeColor = true;
            this.txtaddress1.Properties.AutoHeight = false;
            this.txtaddress1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtaddress1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtaddress1.Properties.Mask.EditMask = "[a-zA-Z ]+";
            this.txtaddress1.Properties.Mask.PlaceHolder = ' ';
            this.txtaddress1.Properties.NullText = "Address";
            this.txtaddress1.Properties.NullValuePrompt = "Address";
            this.txtaddress1.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtaddress1.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtaddress1.Size = new System.Drawing.Size(285, 27);
            this.txtaddress1.TabIndex = 12;
            // 
            // txtage
            // 
            this.txtage.Enabled = false;
            this.txtage.Location = new System.Drawing.Point(9, 183);
            this.txtage.Name = "txtage";
            this.txtage.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtage.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtage.Properties.Appearance.Options.UseBackColor = true;
            this.txtage.Properties.Appearance.Options.UseFont = true;
            this.txtage.Properties.Appearance.Options.UseForeColor = true;
            this.txtage.Properties.AutoHeight = false;
            this.txtage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtage.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtage.Properties.Mask.EditMask = "[a-zA-Z ]+";
            this.txtage.Properties.Mask.PlaceHolder = ' ';
            this.txtage.Properties.MaxLength = 25;
            this.txtage.Properties.NullText = "Age";
            this.txtage.Properties.NullValuePrompt = "Age";
            this.txtage.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtage.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtage.Size = new System.Drawing.Size(138, 27);
            this.txtage.TabIndex = 11;
            // 
            // txtgender
            // 
            this.txtgender.Enabled = false;
            this.txtgender.Location = new System.Drawing.Point(9, 150);
            this.txtgender.Name = "txtgender";
            this.txtgender.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtgender.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgender.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtgender.Properties.Appearance.Options.UseBackColor = true;
            this.txtgender.Properties.Appearance.Options.UseFont = true;
            this.txtgender.Properties.Appearance.Options.UseForeColor = true;
            this.txtgender.Properties.AutoHeight = false;
            this.txtgender.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtgender.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtgender.Properties.Mask.EditMask = "[a-zA-Z ]+";
            this.txtgender.Properties.Mask.PlaceHolder = ' ';
            this.txtgender.Properties.MaxLength = 25;
            this.txtgender.Properties.NullText = "Gender";
            this.txtgender.Properties.NullValuePrompt = "Gender";
            this.txtgender.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtgender.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtgender.Size = new System.Drawing.Size(138, 27);
            this.txtgender.TabIndex = 10;
            // 
            // txtfullname
            // 
            this.txtfullname.Enabled = false;
            this.txtfullname.Location = new System.Drawing.Point(9, 117);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtfullname.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfullname.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtfullname.Properties.Appearance.Options.UseBackColor = true;
            this.txtfullname.Properties.Appearance.Options.UseFont = true;
            this.txtfullname.Properties.Appearance.Options.UseForeColor = true;
            this.txtfullname.Properties.AutoHeight = false;
            this.txtfullname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtfullname.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtfullname.Properties.Mask.EditMask = "[a-zA-Z ]+";
            this.txtfullname.Properties.Mask.PlaceHolder = ' ';
            this.txtfullname.Properties.NullText = "Fullname";
            this.txtfullname.Properties.NullValuePrompt = "Full Name";
            this.txtfullname.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtfullname.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtfullname.Size = new System.Drawing.Size(285, 27);
            this.txtfullname.TabIndex = 9;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.Color.Navy;
            this.lblUserType.Location = new System.Drawing.Point(83, 84);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(62, 17);
            this.lblUserType.TabIndex = 8;
            this.lblUserType.Text = "Teacher";
            // 
            // lblIDNo
            // 
            this.lblIDNo.AutoSize = true;
            this.lblIDNo.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNo.ForeColor = System.Drawing.Color.Navy;
            this.lblIDNo.Location = new System.Drawing.Point(75, 57);
            this.lblIDNo.Name = "lblIDNo";
            this.lblIDNo.Size = new System.Drawing.Size(101, 32);
            this.lblIDNo.TabIndex = 7;
            this.lblIDNo.Text = "14-701";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(50, 501);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(884, 70);
            this.panel4.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(569, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(315, 70);
            this.panel8.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAdd.Location = new System.Drawing.Point(137, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnAdd.Size = new System.Drawing.Size(125, 40);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "ADD TEACHER";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(6, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnRefresh.Size = new System.Drawing.Size(125, 40);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "REFRESH LIST";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(50, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(884, 40);
            this.panel10.TabIndex = 9;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(50, 571);
            this.panel11.TabIndex = 8;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(934, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(50, 571);
            this.panel12.TabIndex = 7;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "UserType";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            this.userTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.userTypeDataGridViewTextBoxColumn.Width = 120;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Visible = false;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Visible = false;
            // 
            // address1DataGridViewTextBoxColumn
            // 
            this.address1DataGridViewTextBoxColumn.DataPropertyName = "Address1";
            this.address1DataGridViewTextBoxColumn.HeaderText = "Address1";
            this.address1DataGridViewTextBoxColumn.Name = "address1DataGridViewTextBoxColumn";
            this.address1DataGridViewTextBoxColumn.ReadOnly = true;
            this.address1DataGridViewTextBoxColumn.Visible = false;
            // 
            // address2DataGridViewTextBoxColumn
            // 
            this.address2DataGridViewTextBoxColumn.DataPropertyName = "Address2";
            this.address2DataGridViewTextBoxColumn.HeaderText = "Address2";
            this.address2DataGridViewTextBoxColumn.Name = "address2DataGridViewTextBoxColumn";
            this.address2DataGridViewTextBoxColumn.ReadOnly = true;
            this.address2DataGridViewTextBoxColumn.Visible = false;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Visible = false;
            // 
            // verifiedDataGridViewCheckBoxColumn
            // 
            this.verifiedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.verifiedDataGridViewCheckBoxColumn.DataPropertyName = "Verified";
            this.verifiedDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.verifiedDataGridViewCheckBoxColumn.Name = "verifiedDataGridViewCheckBoxColumn";
            this.verifiedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.verifiedDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.verifiedDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // vwAccountInfoBindingSource
            // 
            this.vwAccountInfoBindingSource.DataMember = "vwAccountInfo";
            this.vwAccountInfoBindingSource.DataSource = this.dsAccountInfo;
            // 
            // dsAccountInfo
            // 
            this.dsAccountInfo.DataSetName = "dsAccountInfo";
            this.dsAccountInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwAccountInfoTableAdapter
            // 
            this.vwAccountInfoTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRFLE_System.Properties.Resources.BISU_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 569);
            this.Controls.Add(this.panelAccountTeachers);
            this.Name = "frmAccounts";
            this.Load += new System.EventHandler(this.frmAccounts_Load);
            this.panelAccountTeachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfullname.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vwAccountInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccountInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAccountTeachers;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnUpdateAccount;
        private DevExpress.XtraEditors.TextEdit txtusername;
        private DevExpress.XtraEditors.SimpleButton btnPasswordReset;
        private DevExpress.XtraEditors.TextEdit txtaddress1;
        private DevExpress.XtraEditors.TextEdit txtage;
        private DevExpress.XtraEditors.TextEdit txtgender;
        private DevExpress.XtraEditors.TextEdit txtfullname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblIDNo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        public System.Windows.Forms.DataGridView dgAccounts;
        private DevExpress.XtraEditors.TextEdit txtaddress2;
        private dsAccountInfo dsAccountInfo;
        private System.Windows.Forms.BindingSource vwAccountInfoBindingSource;
        private dsAccountInfoTableAdapters.vwAccountInfoTableAdapter vwAccountInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verifiedDataGridViewCheckBoxColumn;
    }
}