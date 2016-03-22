namespace SST.DesktopUI.Forms
{
    partial class InitialDataForm
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
            this.grpInitialData = new System.Windows.Forms.GroupBox();
            this.dtmFirstLessonStart = new System.Windows.Forms.DateTimePicker();
            this.lblAmountLessons = new System.Windows.Forms.Label();
            this.lblFirstDate = new System.Windows.Forms.Label();
            this.lblTimeOfLesson = new System.Windows.Forms.Label();
            this.txtAmountLessons = new System.Windows.Forms.TextBox();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpInitialData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInitialData
            // 
            this.grpInitialData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInitialData.Controls.Add(this.cmbTime);
            this.grpInitialData.Controls.Add(this.txtAmountLessons);
            this.grpInitialData.Controls.Add(this.lblTimeOfLesson);
            this.grpInitialData.Controls.Add(this.lblFirstDate);
            this.grpInitialData.Controls.Add(this.lblAmountLessons);
            this.grpInitialData.Controls.Add(this.dtmFirstLessonStart);
            this.grpInitialData.Location = new System.Drawing.Point(12, 12);
            this.grpInitialData.Name = "grpInitialData";
            this.grpInitialData.Size = new System.Drawing.Size(265, 120);
            this.grpInitialData.TabIndex = 0;
            this.grpInitialData.TabStop = false;
            this.grpInitialData.Text = "Enter initial data";
            // 
            // dtmFirstLessonStart
            // 
            this.dtmFirstLessonStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFirstLessonStart.Location = new System.Drawing.Point(142, 55);
            this.dtmFirstLessonStart.Name = "dtmFirstLessonStart";
            this.dtmFirstLessonStart.Size = new System.Drawing.Size(95, 20);
            this.dtmFirstLessonStart.TabIndex = 1;
            this.dtmFirstLessonStart.ValueChanged += new System.EventHandler(this.dtmFirstLessonStart_ValueChanged);
            // 
            // lblAmountLessons
            // 
            this.lblAmountLessons.AutoSize = true;
            this.lblAmountLessons.Location = new System.Drawing.Point(28, 33);
            this.lblAmountLessons.Name = "lblAmountLessons";
            this.lblAmountLessons.Size = new System.Drawing.Size(81, 13);
            this.lblAmountLessons.TabIndex = 1;
            this.lblAmountLessons.Text = "Amount lessons";
            // 
            // lblFirstDate
            // 
            this.lblFirstDate.AutoSize = true;
            this.lblFirstDate.Location = new System.Drawing.Point(28, 61);
            this.lblFirstDate.Name = "lblFirstDate";
            this.lblFirstDate.Size = new System.Drawing.Size(50, 13);
            this.lblFirstDate.TabIndex = 2;
            this.lblFirstDate.Text = "First date";
            // 
            // lblTimeOfLesson
            // 
            this.lblTimeOfLesson.AutoSize = true;
            this.lblTimeOfLesson.Location = new System.Drawing.Point(28, 91);
            this.lblTimeOfLesson.Name = "lblTimeOfLesson";
            this.lblTimeOfLesson.Size = new System.Drawing.Size(75, 13);
            this.lblTimeOfLesson.TabIndex = 3;
            this.lblTimeOfLesson.Text = "Time of lesson";
            // 
            // txtAmountLessons
            // 
            this.txtAmountLessons.Location = new System.Drawing.Point(142, 30);
            this.txtAmountLessons.Name = "txtAmountLessons";
            this.txtAmountLessons.Size = new System.Drawing.Size(79, 20);
            this.txtAmountLessons.TabIndex = 0;
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(142, 82);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(95, 21);
            this.cmbTime.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(121, 138);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(202, 138);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // InitialDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 165);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpInitialData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InitialDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initial Data";
            this.grpInitialData.ResumeLayout(false);
            this.grpInitialData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInitialData;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.TextBox txtAmountLessons;
        private System.Windows.Forms.Label lblTimeOfLesson;
        private System.Windows.Forms.Label lblFirstDate;
        private System.Windows.Forms.Label lblAmountLessons;
        private System.Windows.Forms.DateTimePicker dtmFirstLessonStart;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}