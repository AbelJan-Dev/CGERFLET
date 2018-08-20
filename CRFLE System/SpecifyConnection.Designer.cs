namespace CRFLE_System
{
    partial class SpecifyConnection
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
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelPrompt = new System.Windows.Forms.Panel();
            this.promptText = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtpword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtuname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtdbname = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtsvname = new DevExpress.XtraEditors.TextEdit();
            this.panelLightBlue = new System.Windows.Forms.Panel();
            this.panelNavy = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelWhite.SuspendLayout();
            this.panelPrompt.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdbname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsvname.Properties)).BeginInit();
            this.panelNavy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelWhite.Controls.Add(this.panelPrompt);
            this.panelWhite.Controls.Add(this.btnSave);
            this.panelWhite.Controls.Add(this.btnClose);
            this.panelWhite.Controls.Add(this.panel4);
            this.panelWhite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWhite.Location = new System.Drawing.Point(0, 82);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(479, 305);
            this.panelWhite.TabIndex = 4;
            // 
            // panelPrompt
            // 
            this.panelPrompt.BackColor = System.Drawing.Color.Red;
            this.panelPrompt.Controls.Add(this.promptText);
            this.panelPrompt.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrompt.Location = new System.Drawing.Point(0, 0);
            this.panelPrompt.Name = "panelPrompt";
            this.panelPrompt.Size = new System.Drawing.Size(479, 40);
            this.panelPrompt.TabIndex = 74;
            // 
            // promptText
            // 
            this.promptText.BackColor = System.Drawing.Color.Transparent;
            this.promptText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.promptText.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptText.ForeColor = System.Drawing.Color.White;
            this.promptText.Location = new System.Drawing.Point(0, 0);
            this.promptText.Name = "promptText";
            this.promptText.Size = new System.Drawing.Size(479, 40);
            this.promptText.TabIndex = 66;
            this.promptText.Text = "Invalid connection to the server. Please specify connection parameters.";
            this.promptText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnSave.Location = new System.Drawing.Point(107, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnSave.Size = new System.Drawing.Size(125, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.BackColor = System.Drawing.Color.Gray;
            this.btnClose.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Appearance.Options.UseForeColor = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.Location = new System.Drawing.Point(244, 245);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnClose.Size = new System.Drawing.Size(125, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "CLOSE";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.labelControl4);
            this.panel4.Controls.Add(this.txtpword);
            this.panel4.Controls.Add(this.labelControl3);
            this.panel4.Controls.Add(this.txtuname);
            this.panel4.Controls.Add(this.labelControl2);
            this.panel4.Controls.Add(this.txtdbname);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.labelControl1);
            this.panel4.Controls.Add(this.txtsvname);
            this.panel4.Location = new System.Drawing.Point(21, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(438, 195);
            this.panel4.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(226, 119);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 16);
            this.labelControl4.TabIndex = 72;
            this.labelControl4.Text = "Password";
            // 
            // txtpword
            // 
            this.txtpword.Location = new System.Drawing.Point(225, 137);
            this.txtpword.Name = "txtpword";
            this.txtpword.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtpword.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpword.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpword.Properties.Appearance.Options.UseBackColor = true;
            this.txtpword.Properties.Appearance.Options.UseFont = true;
            this.txtpword.Properties.Appearance.Options.UseForeColor = true;
            this.txtpword.Properties.AutoHeight = false;
            this.txtpword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtpword.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtpword.Properties.Mask.EditMask = "[a-zA-Z ]+";
            this.txtpword.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtpword.Properties.Mask.PlaceHolder = ' ';
            this.txtpword.Properties.MaxLength = 25;
            this.txtpword.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtpword.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtpword.Properties.UseSystemPasswordChar = true;
            this.txtpword.Size = new System.Drawing.Size(183, 27);
            this.txtpword.TabIndex = 71;
            this.txtpword.TextChanged += new System.EventHandler(this.txtsvname_TextChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(30, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 16);
            this.labelControl3.TabIndex = 70;
            this.labelControl3.Text = "User Name";
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(29, 137);
            this.txtuname.Name = "txtuname";
            this.txtuname.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtuname.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuname.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtuname.Properties.Appearance.Options.UseBackColor = true;
            this.txtuname.Properties.Appearance.Options.UseFont = true;
            this.txtuname.Properties.Appearance.Options.UseForeColor = true;
            this.txtuname.Properties.AutoHeight = false;
            this.txtuname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtuname.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtuname.Properties.Mask.EditMask = "[a-zA-Z ]+";
            this.txtuname.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtuname.Properties.Mask.PlaceHolder = ' ';
            this.txtuname.Properties.MaxLength = 25;
            this.txtuname.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtuname.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtuname.Size = new System.Drawing.Size(183, 27);
            this.txtuname.TabIndex = 69;
            this.txtuname.TextChanged += new System.EventHandler(this.txtsvname_TextChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(226, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(106, 16);
            this.labelControl2.TabIndex = 68;
            this.labelControl2.Text = "Database Name";
            // 
            // txtdbname
            // 
            this.txtdbname.Location = new System.Drawing.Point(225, 74);
            this.txtdbname.Name = "txtdbname";
            this.txtdbname.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtdbname.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdbname.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdbname.Properties.Appearance.Options.UseBackColor = true;
            this.txtdbname.Properties.Appearance.Options.UseFont = true;
            this.txtdbname.Properties.Appearance.Options.UseForeColor = true;
            this.txtdbname.Properties.AutoHeight = false;
            this.txtdbname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtdbname.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtdbname.Properties.Mask.EditMask = "[a-zA-Z ]+";
            this.txtdbname.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtdbname.Properties.Mask.PlaceHolder = ' ';
            this.txtdbname.Properties.MaxLength = 25;
            this.txtdbname.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtdbname.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtdbname.Size = new System.Drawing.Size(185, 27);
            this.txtdbname.TabIndex = 67;
            this.txtdbname.TextChanged += new System.EventHandler(this.txtsvname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "For any questions, you may ask support from the ICT Department.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Fill-up all the required information.";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(28, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 16);
            this.labelControl1.TabIndex = 63;
            this.labelControl1.Text = "Server Name";
            // 
            // txtsvname
            // 
            this.txtsvname.Location = new System.Drawing.Point(27, 74);
            this.txtsvname.Name = "txtsvname";
            this.txtsvname.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtsvname.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsvname.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsvname.Properties.Appearance.Options.UseBackColor = true;
            this.txtsvname.Properties.Appearance.Options.UseFont = true;
            this.txtsvname.Properties.Appearance.Options.UseForeColor = true;
            this.txtsvname.Properties.AutoHeight = false;
            this.txtsvname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtsvname.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtsvname.Properties.Mask.EditMask = "[a-zA-Z ]+";
            this.txtsvname.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtsvname.Properties.Mask.PlaceHolder = ' ';
            this.txtsvname.Properties.MaxLength = 25;
            this.txtsvname.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtsvname.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtsvname.Size = new System.Drawing.Size(185, 27);
            this.txtsvname.TabIndex = 2;
            this.txtsvname.TextChanged += new System.EventHandler(this.txtsvname_TextChanged);
            // 
            // panelLightBlue
            // 
            this.panelLightBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.panelLightBlue.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLightBlue.Location = new System.Drawing.Point(0, 72);
            this.panelLightBlue.Name = "panelLightBlue";
            this.panelLightBlue.Size = new System.Drawing.Size(479, 10);
            this.panelLightBlue.TabIndex = 3;
            // 
            // panelNavy
            // 
            this.panelNavy.BackColor = System.Drawing.Color.Navy;
            this.panelNavy.Controls.Add(this.label1);
            this.panelNavy.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavy.Location = new System.Drawing.Point(0, 0);
            this.panelNavy.Name = "panelNavy";
            this.panelNavy.Size = new System.Drawing.Size(479, 72);
            this.panelNavy.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Connection";
            // 
            // SpecifyConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 387);
            this.Controls.Add(this.panelWhite);
            this.Controls.Add(this.panelLightBlue);
            this.Controls.Add(this.panelNavy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpecifyConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelWhite.ResumeLayout(false);
            this.panelPrompt.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdbname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsvname.Properties)).EndInit();
            this.panelNavy.ResumeLayout(false);
            this.panelNavy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWhite;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtsvname;
        private System.Windows.Forms.Panel panelLightBlue;
        private System.Windows.Forms.Panel panelNavy;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtpword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtuname;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtdbname;
        private System.Windows.Forms.Panel panelPrompt;
        private System.Windows.Forms.Label promptText;
    }
}