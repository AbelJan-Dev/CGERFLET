namespace CRFLE_System
{
    partial class frmExamSchedule
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
            this.panelWhite = new System.Windows.Forms.Panel();
            this.cmbQuestionnaire = new System.Windows.Forms.ComboBox();
            this.tblQuestionnairesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQuestionnaires = new CRFLE_System.dsQuestionnaires();
            this.dateExam = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSet = new DevExpress.XtraEditors.SimpleButton();
            this.timeExam = new DevExpress.XtraEditors.TimeEdit();
            this.durationExam = new DevExpress.XtraEditors.TimeSpanEdit();
            this.panelLightBlue = new System.Windows.Forms.Panel();
            this.panelNavy = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tblQuestionnairesTableAdapter = new CRFLE_System.dsQuestionnairesTableAdapters.tblQuestionnairesTableAdapter();
            this.panelSuccess = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelError = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.panelWhite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionnairesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQuestionnaires)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateExam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeExam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationExam.Properties)).BeginInit();
            this.panelNavy.SuspendLayout();
            this.panelSuccess.SuspendLayout();
            this.panelError.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelWhite.Controls.Add(this.cmbQuestionnaire);
            this.panelWhite.Controls.Add(this.dateExam);
            this.panelWhite.Controls.Add(this.labelControl1);
            this.panelWhite.Controls.Add(this.labelControl3);
            this.panelWhite.Controls.Add(this.labelControl2);
            this.panelWhite.Controls.Add(this.labelControl4);
            this.panelWhite.Controls.Add(this.btnCancel);
            this.panelWhite.Controls.Add(this.btnSet);
            this.panelWhite.Controls.Add(this.timeExam);
            this.panelWhite.Controls.Add(this.durationExam);
            this.panelWhite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWhite.Location = new System.Drawing.Point(0, 82);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(315, 285);
            this.panelWhite.TabIndex = 4;
            // 
            // cmbQuestionnaire
            // 
            this.cmbQuestionnaire.DataSource = this.tblQuestionnairesBindingSource;
            this.cmbQuestionnaire.DisplayMember = "Title";
            this.cmbQuestionnaire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestionnaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbQuestionnaire.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuestionnaire.FormattingEnabled = true;
            this.cmbQuestionnaire.Location = new System.Drawing.Point(17, 171);
            this.cmbQuestionnaire.Name = "cmbQuestionnaire";
            this.cmbQuestionnaire.Size = new System.Drawing.Size(281, 29);
            this.cmbQuestionnaire.TabIndex = 77;
            this.cmbQuestionnaire.ValueMember = "ID";
            // 
            // tblQuestionnairesBindingSource
            // 
            this.tblQuestionnairesBindingSource.DataMember = "tblQuestionnaires";
            this.tblQuestionnairesBindingSource.DataSource = this.dsQuestionnaires;
            // 
            // dsQuestionnaires
            // 
            this.dsQuestionnaires.DataSetName = "dsQuestionnaires";
            this.dsQuestionnaires.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateExam
            // 
            this.dateExam.EditValue = null;
            this.dateExam.Location = new System.Drawing.Point(17, 61);
            this.dateExam.Name = "dateExam";
            this.dateExam.Properties.AllowFocused = false;
            this.dateExam.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateExam.Properties.Appearance.Options.UseFont = true;
            this.dateExam.Properties.AutoHeight = false;
            this.dateExam.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dateExam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateExam.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.dateExam.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateExam.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateExam.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.dateExam.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.dateExam.Properties.Mask.EditMask = "d";
            this.dateExam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateExam.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateExam.Properties.NullValuePrompt = "dd/mm/yyyy";
            this.dateExam.Properties.NullValuePromptShowForEmptyValue = true;
            this.dateExam.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateExam.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.dateExam.Size = new System.Drawing.Size(169, 27);
            this.dateExam.TabIndex = 75;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(192, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 16);
            this.labelControl1.TabIndex = 70;
            this.labelControl1.Text = "Time:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(17, 152);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(95, 16);
            this.labelControl3.TabIndex = 70;
            this.labelControl3.Text = "Questionnaire:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(17, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 16);
            this.labelControl2.TabIndex = 70;
            this.labelControl2.Text = "Duration:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(17, 42);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 16);
            this.labelControl4.TabIndex = 70;
            this.labelControl4.Text = "Date:";
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
            this.btnCancel.Location = new System.Drawing.Point(160, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSet
            // 
            this.btnSet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnSet.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSet.Appearance.Options.UseBackColor = true;
            this.btnSet.Appearance.Options.UseFont = true;
            this.btnSet.Appearance.Options.UseForeColor = true;
            this.btnSet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSet.Location = new System.Drawing.Point(54, 227);
            this.btnSet.Name = "btnSet";
            this.btnSet.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnSet.Size = new System.Drawing.Size(100, 40);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "SET";
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // timeExam
            // 
            this.timeExam.EditValue = null;
            this.timeExam.Location = new System.Drawing.Point(192, 61);
            this.timeExam.Name = "timeExam";
            this.timeExam.Properties.AllowFocused = false;
            this.timeExam.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeExam.Properties.Appearance.Options.UseFont = true;
            this.timeExam.Properties.AutoHeight = false;
            this.timeExam.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.timeExam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeExam.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.timeExam.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeExam.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeExam.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.timeExam.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.timeExam.Properties.Mask.EditMask = "t";
            this.timeExam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.timeExam.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.timeExam.Properties.NullValuePrompt = "hh/mm";
            this.timeExam.Properties.NullValuePromptShowForEmptyValue = true;
            this.timeExam.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.timeExam.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.timeExam.Size = new System.Drawing.Size(106, 27);
            this.timeExam.TabIndex = 74;
            // 
            // durationExam
            // 
            this.durationExam.EditValue = null;
            this.durationExam.Location = new System.Drawing.Point(17, 116);
            this.durationExam.Name = "durationExam";
            this.durationExam.Properties.AllowEditDays = false;
            this.durationExam.Properties.AllowEditSeconds = false;
            this.durationExam.Properties.AllowFocused = false;
            this.durationExam.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationExam.Properties.Appearance.Options.UseFont = true;
            this.durationExam.Properties.AutoHeight = false;
            this.durationExam.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.durationExam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.durationExam.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.durationExam.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.durationExam.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.durationExam.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.durationExam.Properties.Mask.EditMask = "HH:mm";
            this.durationExam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.durationExam.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.durationExam.Properties.MaxHours = 6;
            this.durationExam.Properties.NullValuePrompt = "hh/mm";
            this.durationExam.Properties.NullValuePromptShowForEmptyValue = true;
            this.durationExam.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.durationExam.Properties.TouchUIMaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.durationExam.Properties.TouchUIMinValue = new System.DateTime(((long)(0)));
            this.durationExam.Size = new System.Drawing.Size(125, 27);
            this.durationExam.TabIndex = 76;
            // 
            // panelLightBlue
            // 
            this.panelLightBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.panelLightBlue.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLightBlue.Location = new System.Drawing.Point(0, 72);
            this.panelLightBlue.Name = "panelLightBlue";
            this.panelLightBlue.Size = new System.Drawing.Size(315, 10);
            this.panelLightBlue.TabIndex = 3;
            // 
            // panelNavy
            // 
            this.panelNavy.BackColor = System.Drawing.Color.Navy;
            this.panelNavy.Controls.Add(this.label1);
            this.panelNavy.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavy.Location = new System.Drawing.Point(0, 0);
            this.panelNavy.Name = "panelNavy";
            this.panelNavy.Size = new System.Drawing.Size(315, 72);
            this.panelNavy.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Schedule";
            // 
            // tblQuestionnairesTableAdapter
            // 
            this.tblQuestionnairesTableAdapter.ClearBeforeFill = true;
            // 
            // panelSuccess
            // 
            this.panelSuccess.BackColor = System.Drawing.Color.LimeGreen;
            this.panelSuccess.Controls.Add(this.label2);
            this.panelSuccess.Location = new System.Drawing.Point(0, 71);
            this.panelSuccess.Name = "panelSuccess";
            this.panelSuccess.Size = new System.Drawing.Size(315, 40);
            this.panelSuccess.TabIndex = 131;
            this.panelSuccess.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Schedule successfully set.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelError
            // 
            this.panelError.BackColor = System.Drawing.Color.Red;
            this.panelError.Controls.Add(this.lblError);
            this.panelError.Location = new System.Drawing.Point(0, 71);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(315, 40);
            this.panelError.TabIndex = 130;
            this.panelError.Visible = false;
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(6, 11);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(303, 17);
            this.lblError.TabIndex = 68;
            this.lblError.Text = "Oops! Please supply all required data.";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmExamSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 367);
            this.Controls.Add(this.panelSuccess);
            this.Controls.Add(this.panelError);
            this.Controls.Add(this.panelWhite);
            this.Controls.Add(this.panelLightBlue);
            this.Controls.Add(this.panelNavy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExamSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmExamSchedule_Load);
            this.panelWhite.ResumeLayout(false);
            this.panelWhite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionnairesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQuestionnaires)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateExam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeExam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationExam.Properties)).EndInit();
            this.panelNavy.ResumeLayout(false);
            this.panelNavy.PerformLayout();
            this.panelSuccess.ResumeLayout(false);
            this.panelError.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWhite;
        private DevExpress.XtraEditors.SimpleButton btnSet;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Panel panelLightBlue;
        private System.Windows.Forms.Panel panelNavy;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TimeEdit timeExam;
        private DevExpress.XtraEditors.TimeEdit dateExam;
        private DevExpress.XtraEditors.TimeSpanEdit durationExam;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cmbQuestionnaire;
        private dsQuestionnaires dsQuestionnaires;
        private System.Windows.Forms.BindingSource tblQuestionnairesBindingSource;
        private dsQuestionnairesTableAdapters.tblQuestionnairesTableAdapter tblQuestionnairesTableAdapter;
        private System.Windows.Forms.Panel panelSuccess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelError;
        private System.Windows.Forms.Label lblError;
    }
}