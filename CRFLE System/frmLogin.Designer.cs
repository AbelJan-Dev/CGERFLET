namespace CRFLE_System
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkShowPassword = new DevExpress.XtraEditors.CheckEdit();
            this.lnkNoAccount = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtpassword = new DevExpress.XtraEditors.TextEdit();
            this.txtusername = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panelErrorUsername = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelErrorCredentials = new System.Windows.Forms.Panel();
            this.labelusernameorpassword = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelErrorPassword = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelErrorVerify = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.panelErrorUsername.SuspendLayout();
            this.panelErrorCredentials.SuspendLayout();
            this.panelErrorPassword.SuspendLayout();
            this.panelErrorVerify.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 154);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 345);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 299);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(304, 46);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chkShowPassword);
            this.panel4.Controls.Add(this.lnkNoAccount);
            this.panel4.Controls.Add(this.btnLogin);
            this.panel4.Controls.Add(this.txtpassword);
            this.panel4.Controls.Add(this.txtusername);
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Controls.Add(this.pictureEdit2);
            this.panel4.Controls.Add(this.pictureEdit1);
            this.panel4.Location = new System.Drawing.Point(9, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 238);
            this.panel4.TabIndex = 0;
            this.panel4.TabStop = true;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.Location = new System.Drawing.Point(140, 95);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Properties.AllowFocused = false;
            this.chkShowPassword.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.Properties.Appearance.Options.UseFont = true;
            this.chkShowPassword.Properties.Caption = "Show Password";
            this.chkShowPassword.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.chkShowPassword.Size = new System.Drawing.Size(128, 21);
            this.chkShowPassword.TabIndex = 32;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // lnkNoAccount
            // 
            this.lnkNoAccount.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkNoAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkNoAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkNoAccount.Location = new System.Drawing.Point(108, 214);
            this.lnkNoAccount.Name = "lnkNoAccount";
            this.lnkNoAccount.Size = new System.Drawing.Size(160, 17);
            this.lnkNoAccount.TabIndex = 5;
            this.lnkNoAccount.Text = "Don\'t have an account?";
            this.lnkNoAccount.Click += new System.EventHandler(this.lnkNoAccount_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Appearance.Options.UseForeColor = true;
            this.btnLogin.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnLogin.AppearanceHovered.ForeColor = System.Drawing.Color.Navy;
            this.btnLogin.AppearanceHovered.Options.UseBackColor = true;
            this.btnLogin.AppearanceHovered.Options.UseForeColor = true;
            this.btnLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLogin.Location = new System.Drawing.Point(18, 122);
            this.btnLogin.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnLogin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnLogin.Size = new System.Drawing.Size(250, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseHover += new System.EventHandler(this.btnLogin_MouseHover);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(48, 54);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtpassword.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpassword.Properties.Appearance.Options.UseBackColor = true;
            this.txtpassword.Properties.Appearance.Options.UseFont = true;
            this.txtpassword.Properties.Appearance.Options.UseForeColor = true;
            this.txtpassword.Properties.AutoHeight = false;
            this.txtpassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtpassword.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtpassword.Properties.NullValuePrompt = "Password";
            this.txtpassword.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtpassword.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtpassword.Properties.UseSystemPasswordChar = true;
            this.txtpassword.Size = new System.Drawing.Size(220, 35);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(48, 8);
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
            this.txtusername.Properties.MaxLength = 25;
            this.txtusername.Properties.NullValuePrompt = "Username";
            this.txtusername.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtusername.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtusername.Size = new System.Drawing.Size(220, 35);
            this.txtusername.TabIndex = 0;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Appearance.Options.UseForeColor = true;
            this.btnCancel.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnCancel.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnCancel.AppearanceHovered.Options.UseBackColor = true;
            this.btnCancel.AppearanceHovered.Options.UseForeColor = true;
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCancel.Location = new System.Drawing.Point(18, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnCancel.Size = new System.Drawing.Size(250, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(17, 56);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.AllowFocused = false;
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit2.Size = new System.Drawing.Size(28, 28);
            this.pictureEdit2.TabIndex = 4;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::CRFLE_System.Properties.Resources.user_icon;
            this.pictureEdit1.Location = new System.Drawing.Point(16, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(28, 28);
            this.pictureEdit1.TabIndex = 3;
            // 
            // panelErrorUsername
            // 
            this.panelErrorUsername.BackColor = System.Drawing.Color.Red;
            this.panelErrorUsername.Controls.Add(this.label3);
            this.panelErrorUsername.Controls.Add(this.label1);
            this.panelErrorUsername.Controls.Add(this.label2);
            this.panelErrorUsername.Location = new System.Drawing.Point(0, 153);
            this.panelErrorUsername.Name = "panelErrorUsername";
            this.panelErrorUsername.Size = new System.Drawing.Size(304, 40);
            this.panelErrorUsername.TabIndex = 3;
            this.panelErrorUsername.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(123, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 68;
            this.label3.Text = "Sign up for an account.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "any account.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "The username you\'ve entered doesn\'t match";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelErrorCredentials
            // 
            this.panelErrorCredentials.BackColor = System.Drawing.Color.Red;
            this.panelErrorCredentials.Controls.Add(this.labelusernameorpassword);
            this.panelErrorCredentials.Controls.Add(this.label6);
            this.panelErrorCredentials.Location = new System.Drawing.Point(0, 153);
            this.panelErrorCredentials.Name = "panelErrorCredentials";
            this.panelErrorCredentials.Size = new System.Drawing.Size(304, 40);
            this.panelErrorCredentials.TabIndex = 70;
            this.panelErrorCredentials.Visible = false;
            // 
            // labelusernameorpassword
            // 
            this.labelusernameorpassword.BackColor = System.Drawing.Color.Transparent;
            this.labelusernameorpassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusernameorpassword.ForeColor = System.Drawing.Color.White;
            this.labelusernameorpassword.Location = new System.Drawing.Point(33, 19);
            this.labelusernameorpassword.Name = "labelusernameorpassword";
            this.labelusernameorpassword.Size = new System.Drawing.Size(238, 15);
            this.labelusernameorpassword.TabIndex = 68;
            this.labelusernameorpassword.Text = "Please enter your username and password.";
            this.labelusernameorpassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 16);
            this.label6.TabIndex = 66;
            this.label6.Text = "Looks like your credentials are lacking.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelErrorPassword
            // 
            this.panelErrorPassword.BackColor = System.Drawing.Color.Red;
            this.panelErrorPassword.Controls.Add(this.label5);
            this.panelErrorPassword.Controls.Add(this.label7);
            this.panelErrorPassword.Location = new System.Drawing.Point(0, 153);
            this.panelErrorPassword.Name = "panelErrorPassword";
            this.panelErrorPassword.Size = new System.Drawing.Size(304, 40);
            this.panelErrorPassword.TabIndex = 72;
            this.panelErrorPassword.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(101, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 68;
            this.label5.Text = "Please try again.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 16);
            this.label7.TabIndex = 66;
            this.label7.Text = "Oops! You have entered an incorrect password.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelErrorVerify
            // 
            this.panelErrorVerify.BackColor = System.Drawing.Color.Red;
            this.panelErrorVerify.Controls.Add(this.label8);
            this.panelErrorVerify.Controls.Add(this.label9);
            this.panelErrorVerify.Location = new System.Drawing.Point(0, 153);
            this.panelErrorVerify.Name = "panelErrorVerify";
            this.panelErrorVerify.Size = new System.Drawing.Size(304, 40);
            this.panelErrorVerify.TabIndex = 73;
            this.panelErrorVerify.Visible = false;
            this.panelErrorVerify.Paint += new System.Windows.Forms.PaintEventHandler(this.panelErrorVerify_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(41, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 15);
            this.label8.TabIndex = 68;
            this.label8.Text = "Please ask assistance from the teacher.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(53, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 16);
            this.label9.TabIndex = 66;
            this.label9.Text = "Your account needs to be verified.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 509);
            this.Controls.Add(this.panelErrorVerify);
            this.Controls.Add(this.panelErrorPassword);
            this.Controls.Add(this.panelErrorCredentials);
            this.Controls.Add(this.panelErrorUsername);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.panelErrorUsername.ResumeLayout(false);
            this.panelErrorUsername.PerformLayout();
            this.panelErrorCredentials.ResumeLayout(false);
            this.panelErrorCredentials.PerformLayout();
            this.panelErrorPassword.ResumeLayout(false);
            this.panelErrorPassword.PerformLayout();
            this.panelErrorVerify.ResumeLayout(false);
            this.panelErrorVerify.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txtusername;
        private DevExpress.XtraEditors.TextEdit txtpassword;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.HyperlinkLabelControl lnkNoAccount;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.CheckEdit chkShowPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelErrorCredentials;
        private System.Windows.Forms.Label labelusernameorpassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelErrorPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelErrorVerify;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelErrorUsername;


    }
}