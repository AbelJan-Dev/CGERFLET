namespace CRFLE_System
{
    partial class frmStudentAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelAccountTeachers = new System.Windows.Forms.Panel();
            this.dgAccounts = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtusername = new DevExpress.XtraEditors.TextEdit();
            this.btnChangePassword = new DevExpress.XtraEditors.SimpleButton();
            this.txtaddress2 = new DevExpress.XtraEditors.TextEdit();
            this.txtaddress1 = new DevExpress.XtraEditors.TextEdit();
            this.txtage = new DevExpress.XtraEditors.TextEdit();
            this.txtgender = new DevExpress.XtraEditors.TextEdit();
            this.txtfullname = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblIDNo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRetake = new DevExpress.XtraEditors.SimpleButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panelAccountTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfullname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.panelAccountTeachers.TabIndex = 9;
            // 
            // dgAccounts
            // 
            this.dgAccounts.AllowUserToAddRows = false;
            this.dgAccounts.AllowUserToDeleteRows = false;
            this.dgAccounts.AllowUserToResizeColumns = false;
            this.dgAccounts.AllowUserToResizeRows = false;
            this.dgAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAccounts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAccounts.GridColor = System.Drawing.Color.Silver;
            this.dgAccounts.Location = new System.Drawing.Point(50, 67);
            this.dgAccounts.MultiSelect = false;
            this.dgAccounts.Name = "dgAccounts";
            this.dgAccounts.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgAccounts.RowHeadersVisible = false;
            this.dgAccounts.RowHeadersWidth = 20;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.dgAccounts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccounts.Size = new System.Drawing.Size(544, 434);
            this.dgAccounts.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(594, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(40, 434);
            this.panel6.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtusername);
            this.panel5.Controls.Add(this.btnChangePassword);
            this.panel5.Controls.Add(this.txtaddress2);
            this.panel5.Controls.Add(this.txtaddress1);
            this.panel5.Controls.Add(this.txtage);
            this.panel5.Controls.Add(this.txtgender);
            this.panel5.Controls.Add(this.txtfullname);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.lblUserType);
            this.panel5.Controls.Add(this.lblIDNo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(634, 67);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 434);
            this.panel5.TabIndex = 11;
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
            // btnChangePassword
            // 
            this.btnChangePassword.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnChangePassword.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Appearance.Options.UseBackColor = true;
            this.btnChangePassword.Appearance.Options.UseFont = true;
            this.btnChangePassword.Appearance.Options.UseForeColor = true;
            this.btnChangePassword.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnChangePassword.Location = new System.Drawing.Point(9, 372);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnChangePassword.Size = new System.Drawing.Size(285, 40);
            this.btnChangePassword.TabIndex = 16;
            this.btnChangePassword.Text = "CHANGE PASSWORD";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
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
            this.panel4.Controls.Add(this.btnRetake);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(50, 501);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(884, 70);
            this.panel4.TabIndex = 10;
            // 
            // btnRetake
            // 
            this.btnRetake.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnRetake.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetake.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnRetake.Appearance.Options.UseBackColor = true;
            this.btnRetake.Appearance.Options.UseFont = true;
            this.btnRetake.Appearance.Options.UseForeColor = true;
            this.btnRetake.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnRetake.Location = new System.Drawing.Point(6, 10);
            this.btnRetake.Name = "btnRetake";
            this.btnRetake.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnRetake.Size = new System.Drawing.Size(130, 40);
            this.btnRetake.TabIndex = 17;
            this.btnRetake.Text = "RETAKE EXAM";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(50, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(884, 67);
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
            // frmStudentAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 569);
            this.Controls.Add(this.panelAccountTeachers);
            this.Name = "frmStudentAccount";
            this.Text = "frmStudentAccount";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAccountTeachers;
        public System.Windows.Forms.DataGridView dgAccounts;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.TextEdit txtusername;
        private DevExpress.XtraEditors.SimpleButton btnChangePassword;
        private DevExpress.XtraEditors.TextEdit txtaddress2;
        private DevExpress.XtraEditors.TextEdit txtaddress1;
        private DevExpress.XtraEditors.TextEdit txtage;
        private DevExpress.XtraEditors.TextEdit txtgender;
        private DevExpress.XtraEditors.TextEdit txtfullname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblIDNo;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnRetake;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
    }
}