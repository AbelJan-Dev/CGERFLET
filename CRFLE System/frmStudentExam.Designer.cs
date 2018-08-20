namespace CRFLE_System
{
    partial class frmStudentExam
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
            this.panelQuestionnaires = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMaxItems = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAnsweredItems = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.btnFinish = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.examTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelQuestionnaires.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuestionnaires
            // 
            this.panelQuestionnaires.Controls.Add(this.flowLayoutPanel1);
            this.panelQuestionnaires.Controls.Add(this.panel4);
            this.panelQuestionnaires.Controls.Add(this.panel3);
            this.panelQuestionnaires.Controls.Add(this.panel2);
            this.panelQuestionnaires.Controls.Add(this.panel1);
            this.panelQuestionnaires.Location = new System.Drawing.Point(0, 0);
            this.panelQuestionnaires.Name = "panelQuestionnaires";
            this.panelQuestionnaires.Size = new System.Drawing.Size(982, 569);
            this.panelQuestionnaires.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(50, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(882, 409);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(50, 509);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(882, 60);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblMaxItems);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblSec);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblAnsweredItems);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblMin);
            this.panel3.Controls.Add(this.btnFinish);
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(50, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(882, 100);
            this.panel3.TabIndex = 2;
            // 
            // lblMaxItems
            // 
            this.lblMaxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxItems.Location = new System.Drawing.Point(273, 43);
            this.lblMaxItems.Name = "lblMaxItems";
            this.lblMaxItems.Size = new System.Drawing.Size(62, 37);
            this.lblMaxItems.TabIndex = 21;
            this.lblMaxItems.Text = "0";
            this.lblMaxItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "out of";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSec
            // 
            this.lblSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.Location = new System.Drawing.Point(465, 43);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(62, 37);
            this.lblSec.TabIndex = 21;
            this.lblSec.Text = "00";
            this.lblSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Answered Items";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnsweredItems
            // 
            this.lblAnsweredItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnsweredItems.Location = new System.Drawing.Point(170, 43);
            this.lblAnsweredItems.Name = "lblAnsweredItems";
            this.lblAnsweredItems.Size = new System.Drawing.Size(59, 37);
            this.lblAnsweredItems.TabIndex = 23;
            this.lblAnsweredItems.Text = "0";
            this.lblAnsweredItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(410, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Time Left";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMin
            // 
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(379, 43);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(59, 37);
            this.lblMin.TabIndex = 23;
            this.lblMin.Text = "0";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFinish
            // 
            this.btnFinish.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnFinish.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Appearance.Options.UseBackColor = true;
            this.btnFinish.Appearance.Options.UseFont = true;
            this.btnFinish.Appearance.Options.UseForeColor = true;
            this.btnFinish.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnFinish.Location = new System.Drawing.Point(591, 37);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnFinish.Size = new System.Drawing.Size(110, 40);
            this.btnFinish.TabIndex = 20;
            this.btnFinish.Text = "FINISH";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnStart
            // 
            this.btnStart.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnStart.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnStart.Appearance.Options.UseBackColor = true;
            this.btnStart.Appearance.Options.UseFont = true;
            this.btnStart.Appearance.Options.UseForeColor = true;
            this.btnStart.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnStart.Location = new System.Drawing.Point(19, 37);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnStart.Size = new System.Drawing.Size(110, 40);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "START";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
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
            // examTimer
            // 
            this.examTimer.Interval = 1000;
            this.examTimer.Tick += new System.EventHandler(this.examTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmStudentExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 569);
            this.Controls.Add(this.panelQuestionnaires);
            this.Name = "frmStudentExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmStudentExam_Load);
            this.panelQuestionnaires.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuestionnaires;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Timer examTimer;
        private System.Windows.Forms.Label lblMaxItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAnsweredItems;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton btnFinish;

    }
}