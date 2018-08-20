namespace CRFLE_System
{
    partial class frmUpdateItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelUpdated = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panelErrorQuestion = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.rtExplanation = new DevExpress.XtraRichEdit.RichEditControl();
            this.rtQuestion = new DevExpress.XtraRichEdit.RichEditControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
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
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelUpdated.SuspendLayout();
            this.panelErrorQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoice4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoice2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoice3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoice1.Properties)).BeginInit();
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
            this.panel1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(12, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Update Item";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 10);
            this.panel2.TabIndex = 2;
            // 
            // panelUpdated
            // 
            this.panelUpdated.BackColor = System.Drawing.Color.LimeGreen;
            this.panelUpdated.Controls.Add(this.label10);
            this.panelUpdated.Location = new System.Drawing.Point(0, 64);
            this.panelUpdated.Name = "panelUpdated";
            this.panelUpdated.Size = new System.Drawing.Size(531, 40);
            this.panelUpdated.TabIndex = 131;
            this.panelUpdated.Visible = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(525, 17);
            this.label10.TabIndex = 68;
            this.label10.Text = "Item successfully updated.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelErrorQuestion
            // 
            this.panelErrorQuestion.BackColor = System.Drawing.Color.Red;
            this.panelErrorQuestion.Controls.Add(this.label7);
            this.panelErrorQuestion.Location = new System.Drawing.Point(0, 64);
            this.panelErrorQuestion.Name = "panelErrorQuestion";
            this.panelErrorQuestion.Size = new System.Drawing.Size(531, 40);
            this.panelErrorQuestion.TabIndex = 130;
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
            // rtExplanation
            // 
            this.rtExplanation.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.rtExplanation.Appearance.Text.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtExplanation.Appearance.Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtExplanation.Appearance.Text.Options.UseFont = true;
            this.rtExplanation.Appearance.Text.Options.UseForeColor = true;
            this.rtExplanation.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rtExplanation.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Document;
            this.rtExplanation.Location = new System.Drawing.Point(36, 238);
            this.rtExplanation.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.rtExplanation.LookAndFeel.UseDefaultLookAndFeel = false;
            this.rtExplanation.Name = "rtExplanation";
            this.rtExplanation.Size = new System.Drawing.Size(459, 81);
            this.rtExplanation.TabIndex = 1;
            // 
            // rtQuestion
            // 
            this.rtQuestion.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.rtQuestion.Appearance.Text.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtQuestion.Appearance.Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtQuestion.Appearance.Text.Options.UseFont = true;
            this.rtQuestion.Appearance.Text.Options.UseForeColor = true;
            this.rtQuestion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rtQuestion.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Document;
            this.rtQuestion.Location = new System.Drawing.Point(36, 131);
            this.rtQuestion.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.rtQuestion.LookAndFeel.UseDefaultLookAndFeel = false;
            this.rtQuestion.Name = "rtQuestion";
            this.rtQuestion.Size = new System.Drawing.Size(459, 81);
            this.rtQuestion.TabIndex = 0;
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
            this.btnSave.Location = new System.Drawing.Point(71, 428);
            this.btnSave.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnSave.Size = new System.Drawing.Size(188, 40);
            this.btnSave.TabIndex = 6;
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
            this.btnCancel.Location = new System.Drawing.Point(270, 428);
            this.btnCancel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnCancel.Size = new System.Drawing.Size(188, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtChoice4
            // 
            this.txtChoice4.Location = new System.Drawing.Point(311, 378);
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
            this.txtChoice4.TabIndex = 5;
            // 
            // txtChoice2
            // 
            this.txtChoice2.Location = new System.Drawing.Point(311, 345);
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
            this.txtChoice2.TabIndex = 3;
            // 
            // txtChoice3
            // 
            this.txtChoice3.Location = new System.Drawing.Point(72, 378);
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
            this.txtChoice3.TabIndex = 4;
            // 
            // txtChoice1
            // 
            this.txtChoice1.Location = new System.Drawing.Point(72, 345);
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
            this.txtChoice1.TabIndex = 2;
            // 
            // flag4
            // 
            this.flag4.AutoSize = true;
            this.flag4.Location = new System.Drawing.Point(275, 386);
            this.flag4.Name = "flag4";
            this.flag4.Size = new System.Drawing.Size(14, 13);
            this.flag4.TabIndex = 151;
            this.flag4.UseVisualStyleBackColor = true;
            // 
            // flag2
            // 
            this.flag2.AutoSize = true;
            this.flag2.Location = new System.Drawing.Point(275, 355);
            this.flag2.Name = "flag2";
            this.flag2.Size = new System.Drawing.Size(14, 13);
            this.flag2.TabIndex = 150;
            this.flag2.UseVisualStyleBackColor = true;
            // 
            // flag3
            // 
            this.flag3.AutoSize = true;
            this.flag3.Location = new System.Drawing.Point(36, 386);
            this.flag3.Name = "flag3";
            this.flag3.Size = new System.Drawing.Size(14, 13);
            this.flag3.TabIndex = 149;
            this.flag3.UseVisualStyleBackColor = true;
            // 
            // flag1
            // 
            this.flag1.AutoSize = true;
            this.flag1.Checked = true;
            this.flag1.Location = new System.Drawing.Point(36, 353);
            this.flag1.Name = "flag1";
            this.flag1.Size = new System.Drawing.Size(14, 13);
            this.flag1.TabIndex = 148;
            this.flag1.TabStop = true;
            this.flag1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(33, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 147;
            this.label3.Text = "Choices:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(33, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 146;
            this.label2.Text = "Explanation:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(33, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 145;
            this.label1.Text = "Question:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(49, 349);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 19);
            this.label12.TabIndex = 160;
            this.label12.Text = "A.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(289, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 19);
            this.label13.TabIndex = 161;
            this.label13.Text = "B.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(49, 382);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 19);
            this.label14.TabIndex = 162;
            this.label14.Text = "C.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(289, 383);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 19);
            this.label15.TabIndex = 163;
            this.label15.Text = "D.";
            // 
            // frmUpdateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 488);
            this.Controls.Add(this.rtExplanation);
            this.Controls.Add(this.rtQuestion);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
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
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panelUpdated);
            this.Controls.Add(this.panelErrorQuestion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUpdateItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelUpdated.ResumeLayout(false);
            this.panelErrorQuestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtChoice4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoice2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoice3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoice1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelUpdated;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelErrorQuestion;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.RadioButton flag4;
        private System.Windows.Forms.RadioButton flag2;
        private System.Windows.Forms.RadioButton flag3;
        private System.Windows.Forms.RadioButton flag1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        private DevExpress.XtraRichEdit.RichEditControl rtExplanation;
        private DevExpress.XtraRichEdit.RichEditControl rtQuestion;
        private DevExpress.XtraEditors.TextEdit txtChoice4;
        private DevExpress.XtraEditors.TextEdit txtChoice2;
        private DevExpress.XtraEditors.TextEdit txtChoice3;
        private DevExpress.XtraEditors.TextEdit txtChoice1;
    }
}