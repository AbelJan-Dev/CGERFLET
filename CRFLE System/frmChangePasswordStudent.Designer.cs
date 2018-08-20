namespace CRFLE_System
{
    partial class frmChangePasswordStudent
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelFail = new System.Windows.Forms.Panel();
            this.lblFail = new System.Windows.Forms.Label();
            this.panelSuccess = new System.Windows.Forms.Panel();
            this.lblSuccessMessage = new System.Windows.Forms.Label();
            this.txtpassword2 = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpassword1 = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panelFail.SuspendLayout();
            this.panelSuccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword2.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.txtpassword1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panelFail);
            this.panel2.Controls.Add(this.panelSuccess);
            this.panel2.Controls.Add(this.txtpassword2);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 286);
            this.panel2.TabIndex = 7;
            // 
            // panelFail
            // 
            this.panelFail.BackColor = System.Drawing.Color.Red;
            this.panelFail.Controls.Add(this.lblFail);
            this.panelFail.Location = new System.Drawing.Point(0, 0);
            this.panelFail.Name = "panelFail";
            this.panelFail.Size = new System.Drawing.Size(404, 35);
            this.panelFail.TabIndex = 134;
            this.panelFail.Visible = false;
            // 
            // lblFail
            // 
            this.lblFail.BackColor = System.Drawing.Color.Transparent;
            this.lblFail.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFail.ForeColor = System.Drawing.Color.White;
            this.lblFail.Location = new System.Drawing.Point(5, 9);
            this.lblFail.Name = "lblFail";
            this.lblFail.Size = new System.Drawing.Size(393, 17);
            this.lblFail.TabIndex = 68;
            this.lblFail.Text = "Password change failed.";
            this.lblFail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSuccess
            // 
            this.panelSuccess.BackColor = System.Drawing.Color.LimeGreen;
            this.panelSuccess.Controls.Add(this.lblSuccessMessage);
            this.panelSuccess.Location = new System.Drawing.Point(0, 0);
            this.panelSuccess.Name = "panelSuccess";
            this.panelSuccess.Size = new System.Drawing.Size(404, 35);
            this.panelSuccess.TabIndex = 133;
            this.panelSuccess.Visible = false;
            // 
            // lblSuccessMessage
            // 
            this.lblSuccessMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccessMessage.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccessMessage.ForeColor = System.Drawing.Color.White;
            this.lblSuccessMessage.Location = new System.Drawing.Point(8, 9);
            this.lblSuccessMessage.Name = "lblSuccessMessage";
            this.lblSuccessMessage.Size = new System.Drawing.Size(390, 17);
            this.lblSuccessMessage.TabIndex = 68;
            this.lblSuccessMessage.Text = "Password successfully changed.";
            this.lblSuccessMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtpassword2
            // 
            this.txtpassword2.Location = new System.Drawing.Point(45, 191);
            this.txtpassword2.Name = "txtpassword2";
            this.txtpassword2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtpassword2.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpassword2.Properties.Appearance.Options.UseBackColor = true;
            this.txtpassword2.Properties.Appearance.Options.UseFont = true;
            this.txtpassword2.Properties.Appearance.Options.UseForeColor = true;
            this.txtpassword2.Properties.Appearance.Options.UseTextOptions = true;
            this.txtpassword2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtpassword2.Properties.AutoHeight = false;
            this.txtpassword2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtpassword2.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtpassword2.Properties.NullValuePrompt = "Current Password";
            this.txtpassword2.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtpassword2.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtpassword2.Properties.UseSystemPasswordChar = true;
            this.txtpassword2.Size = new System.Drawing.Size(306, 32);
            this.txtpassword2.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnOK.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnOK.Appearance.Options.UseBackColor = true;
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Appearance.Options.UseForeColor = true;
            this.btnOK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnOK.Location = new System.Drawing.Point(150, 237);
            this.btnOK.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnOK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOK.Name = "btnOK";
            this.btnOK.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnOK.Size = new System.Drawing.Size(96, 32);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(42, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter your CURRENT password:";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMessage.Location = new System.Drawing.Point(6, 42);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(391, 40);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Would you like to change your password?";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 62);
            this.panel1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(8, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Change Password";
            // 
            // txtpassword1
            // 
            this.txtpassword1.Location = new System.Drawing.Point(45, 114);
            this.txtpassword1.Name = "txtpassword1";
            this.txtpassword1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtpassword1.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpassword1.Properties.Appearance.Options.UseBackColor = true;
            this.txtpassword1.Properties.Appearance.Options.UseFont = true;
            this.txtpassword1.Properties.Appearance.Options.UseForeColor = true;
            this.txtpassword1.Properties.Appearance.Options.UseTextOptions = true;
            this.txtpassword1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtpassword1.Properties.AutoHeight = false;
            this.txtpassword1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtpassword1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.txtpassword1.Properties.NullValuePrompt = "New Password";
            this.txtpassword1.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtpassword1.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtpassword1.Properties.UseSystemPasswordChar = true;
            this.txtpassword1.Size = new System.Drawing.Size(306, 32);
            this.txtpassword1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(42, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 136;
            this.label1.Text = "Enter NEW password:";
            // 
            // frmChangePasswordStudent
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 348);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePasswordStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmChangePasswordStudent_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelFail.ResumeLayout(false);
            this.panelSuccess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword2.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelFail;
        private System.Windows.Forms.Label lblFail;
        private System.Windows.Forms.Panel panelSuccess;
        private System.Windows.Forms.Label lblSuccessMessage;
        private DevExpress.XtraEditors.TextEdit txtpassword2;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtpassword1;
        private System.Windows.Forms.Label label1;
    }
}