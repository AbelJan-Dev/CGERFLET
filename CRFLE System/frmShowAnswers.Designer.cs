namespace CRFLE_System
{
    partial class frmShowAnswers
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPrevious = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblYourLetter = new System.Windows.Forms.Label();
            this.lblYourAnswer = new DevExpress.XtraRichEdit.RichEditControl();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCorrectLetter = new System.Windows.Forms.Label();
            this.lblCorrectAnswer = new DevExpress.XtraRichEdit.RichEditControl();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblCorrectWrong = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblQtn = new DevExpress.XtraRichEdit.RichEditControl();
            this.lblNo = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblExplanation = new DevExpress.XtraRichEdit.RichEditControl();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 62);
            this.panel1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(8, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Examination Answers";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 30);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPrevious);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 509);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(720, 60);
            this.panel3.TabIndex = 7;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnPrevious.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Appearance.Options.UseBackColor = true;
            this.btnPrevious.Appearance.Options.UseFont = true;
            this.btnPrevious.Appearance.Options.UseForeColor = true;
            this.btnPrevious.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnPrevious.Location = new System.Drawing.Point(189, 11);
            this.btnPrevious.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnPrevious.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnPrevious.Size = new System.Drawing.Size(109, 38);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "PREVIOUS";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Appearance.Options.UseForeColor = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.Location = new System.Drawing.Point(419, 11);
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnClose.Size = new System.Drawing.Size(109, 38);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "CLOSE";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNext
            // 
            this.btnNext.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnNext.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnNext.Appearance.Options.UseBackColor = true;
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Appearance.Options.UseForeColor = true;
            this.btnNext.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnNext.Location = new System.Drawing.Point(304, 11);
            this.btnNext.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnNext.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNext.Name = "btnNext";
            this.btnNext.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnNext.Size = new System.Drawing.Size(109, 38);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "NEXT";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panelControl1);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(720, 417);
            this.panel4.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.lblYourLetter);
            this.flowLayoutPanel1.Controls.Add(this.lblYourAnswer);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.lblCorrectLetter);
            this.flowLayoutPanel1.Controls.Add(this.lblCorrectAnswer);
            this.flowLayoutPanel1.Controls.Add(this.lblCorrectWrong);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.lblExplanation);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(76, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(619, 362);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Your Answer:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblYourLetter
            // 
            this.lblYourLetter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourLetter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblYourLetter.Location = new System.Drawing.Point(138, 0);
            this.lblYourLetter.Name = "lblYourLetter";
            this.lblYourLetter.Size = new System.Drawing.Size(27, 29);
            this.lblYourLetter.TabIndex = 4;
            this.lblYourLetter.Text = "C.";
            this.lblYourLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYourAnswer
            // 
            this.lblYourAnswer.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.lblYourAnswer.Appearance.Text.BackColor = System.Drawing.SystemColors.Control;
            this.lblYourAnswer.Appearance.Text.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblYourAnswer.Appearance.Text.Options.UseBackColor = true;
            this.lblYourAnswer.Appearance.Text.Options.UseFont = true;
            this.lblYourAnswer.AutoSizeMode = DevExpress.XtraRichEdit.AutoSizeMode.Vertical;
            this.lblYourAnswer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblYourAnswer.Enabled = false;
            this.lblYourAnswer.Location = new System.Drawing.Point(171, 3);
            this.lblYourAnswer.Name = "lblYourAnswer";
            this.lblYourAnswer.Options.VerticalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.lblYourAnswer.Size = new System.Drawing.Size(439, 22);
            this.lblYourAnswer.TabIndex = 5;
            this.lblYourAnswer.Text = "Your Answer";
            this.lblYourAnswer.Views.SimpleView.BackColor = System.Drawing.SystemColors.Control;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Correct Answer:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCorrectLetter
            // 
            this.lblCorrectLetter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectLetter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCorrectLetter.Location = new System.Drawing.Point(138, 29);
            this.lblCorrectLetter.Name = "lblCorrectLetter";
            this.lblCorrectLetter.Size = new System.Drawing.Size(27, 29);
            this.lblCorrectLetter.TabIndex = 4;
            this.lblCorrectLetter.Text = "C.";
            this.lblCorrectLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.lblCorrectAnswer.Appearance.Text.BackColor = System.Drawing.SystemColors.Control;
            this.lblCorrectAnswer.Appearance.Text.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblCorrectAnswer.Appearance.Text.Options.UseBackColor = true;
            this.lblCorrectAnswer.Appearance.Text.Options.UseFont = true;
            this.lblCorrectAnswer.AutoSizeMode = DevExpress.XtraRichEdit.AutoSizeMode.Vertical;
            this.lblCorrectAnswer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblCorrectAnswer.Enabled = false;
            this.lblCorrectAnswer.Location = new System.Drawing.Point(171, 32);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Options.VerticalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.lblCorrectAnswer.Size = new System.Drawing.Size(439, 22);
            this.lblCorrectAnswer.TabIndex = 5;
            this.lblCorrectAnswer.Text = "Correct Answer";
            this.lblCorrectAnswer.Views.SimpleView.BackColor = System.Drawing.SystemColors.Control;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(76, 30);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(619, 25);
            this.panel8.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(25, 30);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(51, 387);
            this.panel7.TabIndex = 6;
            // 
            // lblCorrectWrong
            // 
            this.lblCorrectWrong.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectWrong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCorrectWrong.Location = new System.Drawing.Point(3, 58);
            this.lblCorrectWrong.Name = "lblCorrectWrong";
            this.lblCorrectWrong.Size = new System.Drawing.Size(558, 66);
            this.lblCorrectWrong.TabIndex = 4;
            this.lblCorrectWrong.Text = "Correct!";
            this.lblCorrectWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.AutoSize = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.lblQtn);
            this.panelControl1.Controls.Add(this.lblNo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(25, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(15, 10, 10, 0);
            this.panelControl1.Size = new System.Drawing.Size(670, 30);
            this.panelControl1.TabIndex = 2;
            // 
            // lblQtn
            // 
            this.lblQtn.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.lblQtn.Appearance.Text.BackColor = System.Drawing.SystemColors.Control;
            this.lblQtn.Appearance.Text.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblQtn.Appearance.Text.Options.UseBackColor = true;
            this.lblQtn.Appearance.Text.Options.UseFont = true;
            this.lblQtn.AutoSizeMode = DevExpress.XtraRichEdit.AutoSizeMode.Vertical;
            this.lblQtn.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblQtn.Enabled = false;
            this.lblQtn.Location = new System.Drawing.Point(45, 5);
            this.lblQtn.Name = "lblQtn";
            this.lblQtn.Options.VerticalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.lblQtn.Size = new System.Drawing.Size(617, 22);
            this.lblQtn.TabIndex = 1;
            this.lblQtn.Text = "Question";
            this.lblQtn.Views.SimpleView.BackColor = System.Drawing.SystemColors.Control;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblNo.Location = new System.Drawing.Point(18, 9);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(21, 20);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "1.";
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(25, 417);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(695, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(25, 417);
            this.panel5.TabIndex = 0;
            // 
            // lblExplanation
            // 
            this.lblExplanation.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.lblExplanation.Appearance.Text.BackColor = System.Drawing.SystemColors.Control;
            this.lblExplanation.Appearance.Text.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblExplanation.Appearance.Text.Options.UseBackColor = true;
            this.lblExplanation.Appearance.Text.Options.UseFont = true;
            this.lblExplanation.AutoSizeMode = DevExpress.XtraRichEdit.AutoSizeMode.Vertical;
            this.lblExplanation.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblExplanation.Enabled = false;
            this.lblExplanation.Location = new System.Drawing.Point(3, 156);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Options.VerticalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.lblExplanation.Size = new System.Drawing.Size(558, 22);
            this.lblExplanation.TabIndex = 5;
            this.lblExplanation.Text = "Explanation";
            this.lblExplanation.Views.SimpleView.BackColor = System.Drawing.SystemColors.Control;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Explanation:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmShowAnswers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 569);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowAnswers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmShowAnswers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnPrevious;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraRichEdit.RichEditControl lblQtn;
        public System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblYourLetter;
        public DevExpress.XtraRichEdit.RichEditControl lblYourAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCorrectLetter;
        public DevExpress.XtraRichEdit.RichEditControl lblCorrectAnswer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblCorrectWrong;
        private System.Windows.Forms.Label label2;
        public DevExpress.XtraRichEdit.RichEditControl lblExplanation;
    }
}