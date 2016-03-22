namespace SST.DesktopUI
{
    partial class MainForm
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
            this.tabModes = new System.Windows.Forms.TabControl();
            this.tabPageLearner = new System.Windows.Forms.TabPage();
            this.pnlSelectTutor = new System.Windows.Forms.Panel();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.txtAmountLessons = new System.Windows.Forms.TextBox();
            this.lblFirstDate = new System.Windows.Forms.Label();
            this.lblAmountLessons = new System.Windows.Forms.Label();
            this.dtmFirstLessonStart = new System.Windows.Forms.DateTimePicker();
            this.btnAddDay = new System.Windows.Forms.Button();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.dgvDayTime = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChangeTutor = new System.Windows.Forms.Button();
            this.btnSelectTutor = new System.Windows.Forms.Button();
            this.lblPriceBetween = new System.Windows.Forms.Label();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.cmbDisciplinesFilter = new System.Windows.Forms.ComboBox();
            this.dgvTutorsInfo = new System.Windows.Forms.DataGridView();
            this.pnlLearnerTutorsInfo = new System.Windows.Forms.Panel();
            this.btnMakePaid = new System.Windows.Forms.Button();
            this.btnMakeLessonOccured = new System.Windows.Forms.Button();
            this.btnCancelSelectedLesson = new System.Windows.Forms.Button();
            this.dgvLearnersTutorsInfo = new System.Windows.Forms.DataGridView();
            this.btnShowTutors = new System.Windows.Forms.Button();
            this.btnLoadInfoAboutLearner = new System.Windows.Forms.Button();
            this.txtLearnerByEmail = new System.Windows.Forms.TextBox();
            this.grpLearnerInfo = new System.Windows.Forms.GroupBox();
            this.txtLearnerPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtLearnerEmail = new System.Windows.Forms.TextBox();
            this.txtLearnerLastName = new System.Windows.Forms.TextBox();
            this.txtLearnerFirstName = new System.Windows.Forms.TextBox();
            this.lblLearnerPhoneNumber = new System.Windows.Forms.Label();
            this.lblLearnerEmail = new System.Windows.Forms.Label();
            this.lblLearnerLastName = new System.Windows.Forms.Label();
            this.lblLearnerFirstName = new System.Windows.Forms.Label();
            this.chkNewLearner = new System.Windows.Forms.CheckBox();
            this.lblFindLearner = new System.Windows.Forms.Label();
            this.tabPageTutor = new System.Windows.Forms.TabPage();
            this.dgvTutorsDisciplines = new System.Windows.Forms.DataGridView();
            this.btnLoadInfoAboutTutor = new System.Windows.Forms.Button();
            this.txtTutorByEmail = new System.Windows.Forms.TextBox();
            this.grpTutorInfo = new System.Windows.Forms.GroupBox();
            this.lblEndWorkingDay = new System.Windows.Forms.Label();
            this.lblBeginningWorkingDay = new System.Windows.Forms.Label();
            this.dtmEndWorkingDay = new System.Windows.Forms.DateTimePicker();
            this.dtmBeginningWorkingDay = new System.Windows.Forms.DateTimePicker();
            this.txtTutorPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtTutorEmail = new System.Windows.Forms.TextBox();
            this.txtTutorLastName = new System.Windows.Forms.TextBox();
            this.txtTutorFirstName = new System.Windows.Forms.TextBox();
            this.lblTutorPhoneNumber = new System.Windows.Forms.Label();
            this.lblTutorEmail = new System.Windows.Forms.Label();
            this.lblTutorLastName = new System.Windows.Forms.Label();
            this.lblTutorFirstName = new System.Windows.Forms.Label();
            this.lblFindTutor = new System.Windows.Forms.Label();
            this.tabModes.SuspendLayout();
            this.tabPageLearner.SuspendLayout();
            this.pnlSelectTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorsInfo)).BeginInit();
            this.pnlLearnerTutorsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearnersTutorsInfo)).BeginInit();
            this.grpLearnerInfo.SuspendLayout();
            this.tabPageTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorsDisciplines)).BeginInit();
            this.grpTutorInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabModes
            // 
            this.tabModes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabModes.Controls.Add(this.tabPageLearner);
            this.tabModes.Controls.Add(this.tabPageTutor);
            this.tabModes.Location = new System.Drawing.Point(-1, 0);
            this.tabModes.Name = "tabModes";
            this.tabModes.SelectedIndex = 0;
            this.tabModes.Size = new System.Drawing.Size(961, 527);
            this.tabModes.TabIndex = 0;
            // 
            // tabPageLearner
            // 
            this.tabPageLearner.Controls.Add(this.pnlSelectTutor);
            this.tabPageLearner.Controls.Add(this.pnlLearnerTutorsInfo);
            this.tabPageLearner.Controls.Add(this.btnShowTutors);
            this.tabPageLearner.Controls.Add(this.btnLoadInfoAboutLearner);
            this.tabPageLearner.Controls.Add(this.txtLearnerByEmail);
            this.tabPageLearner.Controls.Add(this.grpLearnerInfo);
            this.tabPageLearner.Controls.Add(this.chkNewLearner);
            this.tabPageLearner.Controls.Add(this.lblFindLearner);
            this.tabPageLearner.Location = new System.Drawing.Point(4, 22);
            this.tabPageLearner.Name = "tabPageLearner";
            this.tabPageLearner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLearner.Size = new System.Drawing.Size(953, 501);
            this.tabPageLearner.TabIndex = 0;
            this.tabPageLearner.Text = "Learner";
            this.tabPageLearner.UseVisualStyleBackColor = true;
            // 
            // pnlSelectTutor
            // 
            this.pnlSelectTutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSelectTutor.Controls.Add(this.btnMakeOrder);
            this.pnlSelectTutor.Controls.Add(this.txtAmountLessons);
            this.pnlSelectTutor.Controls.Add(this.lblFirstDate);
            this.pnlSelectTutor.Controls.Add(this.lblAmountLessons);
            this.pnlSelectTutor.Controls.Add(this.dtmFirstLessonStart);
            this.pnlSelectTutor.Controls.Add(this.btnAddDay);
            this.pnlSelectTutor.Controls.Add(this.cmbTime);
            this.pnlSelectTutor.Controls.Add(this.cmbDay);
            this.pnlSelectTutor.Controls.Add(this.dgvDayTime);
            this.pnlSelectTutor.Controls.Add(this.btnChangeTutor);
            this.pnlSelectTutor.Controls.Add(this.btnSelectTutor);
            this.pnlSelectTutor.Controls.Add(this.lblPriceBetween);
            this.pnlSelectTutor.Controls.Add(this.txtMaxPrice);
            this.pnlSelectTutor.Controls.Add(this.txtMinPrice);
            this.pnlSelectTutor.Controls.Add(this.cmbDisciplinesFilter);
            this.pnlSelectTutor.Controls.Add(this.dgvTutorsInfo);
            this.pnlSelectTutor.Location = new System.Drawing.Point(9, 176);
            this.pnlSelectTutor.Name = "pnlSelectTutor";
            this.pnlSelectTutor.Size = new System.Drawing.Size(932, 313);
            this.pnlSelectTutor.TabIndex = 8;
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(643, 287);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(241, 23);
            this.btnMakeOrder.TabIndex = 16;
            this.btnMakeOrder.Text = "Make an order";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // txtAmountLessons
            // 
            this.txtAmountLessons.Enabled = false;
            this.txtAmountLessons.Location = new System.Drawing.Point(834, 47);
            this.txtAmountLessons.Name = "txtAmountLessons";
            this.txtAmountLessons.Size = new System.Drawing.Size(79, 20);
            this.txtAmountLessons.TabIndex = 15;
            // 
            // lblFirstDate
            // 
            this.lblFirstDate.AutoSize = true;
            this.lblFirstDate.Location = new System.Drawing.Point(720, 78);
            this.lblFirstDate.Name = "lblFirstDate";
            this.lblFirstDate.Size = new System.Drawing.Size(50, 13);
            this.lblFirstDate.TabIndex = 14;
            this.lblFirstDate.Text = "First date";
            // 
            // lblAmountLessons
            // 
            this.lblAmountLessons.AutoSize = true;
            this.lblAmountLessons.Location = new System.Drawing.Point(720, 50);
            this.lblAmountLessons.Name = "lblAmountLessons";
            this.lblAmountLessons.Size = new System.Drawing.Size(81, 13);
            this.lblAmountLessons.TabIndex = 13;
            this.lblAmountLessons.Text = "Amount lessons";
            // 
            // dtmFirstLessonStart
            // 
            this.dtmFirstLessonStart.Enabled = false;
            this.dtmFirstLessonStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFirstLessonStart.Location = new System.Drawing.Point(834, 72);
            this.dtmFirstLessonStart.Name = "dtmFirstLessonStart";
            this.dtmFirstLessonStart.Size = new System.Drawing.Size(95, 20);
            this.dtmFirstLessonStart.TabIndex = 12;
            // 
            // btnAddDay
            // 
            this.btnAddDay.Location = new System.Drawing.Point(787, 209);
            this.btnAddDay.Name = "btnAddDay";
            this.btnAddDay.Size = new System.Drawing.Size(75, 23);
            this.btnAddDay.TabIndex = 11;
            this.btnAddDay.Text = "Add day";
            this.btnAddDay.UseVisualStyleBackColor = true;
            this.btnAddDay.Click += new System.EventHandler(this.btnAddDay_Click);
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(777, 159);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(94, 21);
            this.cmbTime.TabIndex = 10;
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(777, 117);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(94, 21);
            this.cmbDay.TabIndex = 9;
            this.cmbDay.SelectedValueChanged += new System.EventHandler(this.cmbDay_SelectedValueChanged);
            // 
            // dgvDayTime
            // 
            this.dgvDayTime.AllowUserToAddRows = false;
            this.dgvDayTime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDayTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDayTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.Time});
            this.dgvDayTime.Location = new System.Drawing.Point(593, 117);
            this.dgvDayTime.MultiSelect = false;
            this.dgvDayTime.Name = "dgvDayTime";
            this.dgvDayTime.ReadOnly = true;
            this.dgvDayTime.Size = new System.Drawing.Size(166, 150);
            this.dgvDayTime.TabIndex = 8;
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // btnChangeTutor
            // 
            this.btnChangeTutor.Location = new System.Drawing.Point(593, 74);
            this.btnChangeTutor.Name = "btnChangeTutor";
            this.btnChangeTutor.Size = new System.Drawing.Size(93, 23);
            this.btnChangeTutor.TabIndex = 7;
            this.btnChangeTutor.Text = "Change tutor";
            this.btnChangeTutor.UseVisualStyleBackColor = true;
            this.btnChangeTutor.Click += new System.EventHandler(this.btnChangeTutor_Click);
            // 
            // btnSelectTutor
            // 
            this.btnSelectTutor.Location = new System.Drawing.Point(593, 33);
            this.btnSelectTutor.Name = "btnSelectTutor";
            this.btnSelectTutor.Size = new System.Drawing.Size(93, 23);
            this.btnSelectTutor.TabIndex = 6;
            this.btnSelectTutor.Text = "Select tutor";
            this.btnSelectTutor.UseVisualStyleBackColor = true;
            this.btnSelectTutor.Click += new System.EventHandler(this.btnSelectTutor_Click_1);
            // 
            // lblPriceBetween
            // 
            this.lblPriceBetween.AutoSize = true;
            this.lblPriceBetween.Location = new System.Drawing.Point(233, 9);
            this.lblPriceBetween.Name = "lblPriceBetween";
            this.lblPriceBetween.Size = new System.Drawing.Size(117, 13);
            this.lblPriceBetween.TabIndex = 5;
            this.lblPriceBetween.Text = "Price per hour between";
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Location = new System.Drawing.Point(440, 7);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(63, 20);
            this.txtMaxPrice.TabIndex = 4;
            this.txtMaxPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaxPrice_KeyDown);
            this.txtMaxPrice.Leave += new System.EventHandler(this.txtMaxPrice_Leave);
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Location = new System.Drawing.Point(356, 7);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(63, 20);
            this.txtMinPrice.TabIndex = 3;
            this.txtMinPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMinPrice_KeyDown);
            this.txtMinPrice.Leave += new System.EventHandler(this.txtMinPrice_Leave);
            // 
            // cmbDisciplinesFilter
            // 
            this.cmbDisciplinesFilter.FormattingEnabled = true;
            this.cmbDisciplinesFilter.Location = new System.Drawing.Point(4, 6);
            this.cmbDisciplinesFilter.Name = "cmbDisciplinesFilter";
            this.cmbDisciplinesFilter.Size = new System.Drawing.Size(159, 21);
            this.cmbDisciplinesFilter.TabIndex = 2;
            this.cmbDisciplinesFilter.SelectedIndexChanged += new System.EventHandler(this.cmbDisciplinesFilter_SelectedIndexChanged);
            // 
            // dgvTutorsInfo
            // 
            this.dgvTutorsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTutorsInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTutorsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutorsInfo.Location = new System.Drawing.Point(4, 33);
            this.dgvTutorsInfo.MultiSelect = false;
            this.dgvTutorsInfo.Name = "dgvTutorsInfo";
            this.dgvTutorsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTutorsInfo.Size = new System.Drawing.Size(582, 277);
            this.dgvTutorsInfo.TabIndex = 0;
            // 
            // pnlLearnerTutorsInfo
            // 
            this.pnlLearnerTutorsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLearnerTutorsInfo.Controls.Add(this.btnMakePaid);
            this.pnlLearnerTutorsInfo.Controls.Add(this.btnMakeLessonOccured);
            this.pnlLearnerTutorsInfo.Controls.Add(this.btnCancelSelectedLesson);
            this.pnlLearnerTutorsInfo.Controls.Add(this.dgvLearnersTutorsInfo);
            this.pnlLearnerTutorsInfo.Location = new System.Drawing.Point(9, 176);
            this.pnlLearnerTutorsInfo.Name = "pnlLearnerTutorsInfo";
            this.pnlLearnerTutorsInfo.Size = new System.Drawing.Size(874, 313);
            this.pnlLearnerTutorsInfo.TabIndex = 7;
            this.pnlLearnerTutorsInfo.Visible = false;
            // 
            // btnMakePaid
            // 
            this.btnMakePaid.Location = new System.Drawing.Point(643, 88);
            this.btnMakePaid.Name = "btnMakePaid";
            this.btnMakePaid.Size = new System.Drawing.Size(99, 23);
            this.btnMakePaid.TabIndex = 3;
            this.btnMakePaid.Text = "Pay lesson";
            this.btnMakePaid.UseVisualStyleBackColor = true;
            this.btnMakePaid.Click += new System.EventHandler(this.btnMakePaid_Click);
            // 
            // btnMakeLessonOccured
            // 
            this.btnMakeLessonOccured.Location = new System.Drawing.Point(643, 44);
            this.btnMakeLessonOccured.Name = "btnMakeLessonOccured";
            this.btnMakeLessonOccured.Size = new System.Drawing.Size(99, 23);
            this.btnMakeLessonOccured.TabIndex = 2;
            this.btnMakeLessonOccured.Text = "Make occured";
            this.btnMakeLessonOccured.UseVisualStyleBackColor = true;
            this.btnMakeLessonOccured.Click += new System.EventHandler(this.btnMakeLessonsOccured_Click);
            // 
            // btnCancelSelectedLesson
            // 
            this.btnCancelSelectedLesson.Location = new System.Drawing.Point(643, 4);
            this.btnCancelSelectedLesson.Name = "btnCancelSelectedLesson";
            this.btnCancelSelectedLesson.Size = new System.Drawing.Size(99, 23);
            this.btnCancelSelectedLesson.TabIndex = 1;
            this.btnCancelSelectedLesson.Text = "Cancel lesson";
            this.btnCancelSelectedLesson.UseVisualStyleBackColor = true;
            this.btnCancelSelectedLesson.Click += new System.EventHandler(this.btnCancelSelectedLessons_Click);
            // 
            // dgvLearnersTutorsInfo
            // 
            this.dgvLearnersTutorsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvLearnersTutorsInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLearnersTutorsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLearnersTutorsInfo.Location = new System.Drawing.Point(4, 4);
            this.dgvLearnersTutorsInfo.MultiSelect = false;
            this.dgvLearnersTutorsInfo.Name = "dgvLearnersTutorsInfo";
            this.dgvLearnersTutorsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLearnersTutorsInfo.Size = new System.Drawing.Size(582, 306);
            this.dgvLearnersTutorsInfo.TabIndex = 0;
            // 
            // btnShowTutors
            // 
            this.btnShowTutors.Location = new System.Drawing.Point(675, 21);
            this.btnShowTutors.Name = "btnShowTutors";
            this.btnShowTutors.Size = new System.Drawing.Size(104, 23);
            this.btnShowTutors.TabIndex = 6;
            this.btnShowTutors.Text = "Show tutors";
            this.btnShowTutors.UseVisualStyleBackColor = true;
            this.btnShowTutors.Click += new System.EventHandler(this.btnSelectTutor_Click);
            // 
            // btnLoadInfoAboutLearner
            // 
            this.btnLoadInfoAboutLearner.Location = new System.Drawing.Point(388, 20);
            this.btnLoadInfoAboutLearner.Name = "btnLoadInfoAboutLearner";
            this.btnLoadInfoAboutLearner.Size = new System.Drawing.Size(75, 23);
            this.btnLoadInfoAboutLearner.TabIndex = 5;
            this.btnLoadInfoAboutLearner.Text = "Load info";
            this.btnLoadInfoAboutLearner.UseVisualStyleBackColor = true;
            this.btnLoadInfoAboutLearner.Click += new System.EventHandler(this.btnLoadInfo_Click);
            // 
            // txtLearnerByEmail
            // 
            this.txtLearnerByEmail.Location = new System.Drawing.Point(196, 21);
            this.txtLearnerByEmail.Name = "txtLearnerByEmail";
            this.txtLearnerByEmail.Size = new System.Drawing.Size(177, 20);
            this.txtLearnerByEmail.TabIndex = 4;
            this.txtLearnerByEmail.TextChanged += new System.EventHandler(this.txtLearnerByEmail_TextChanged);
            // 
            // grpLearnerInfo
            // 
            this.grpLearnerInfo.Controls.Add(this.txtLearnerPhoneNumber);
            this.grpLearnerInfo.Controls.Add(this.txtLearnerEmail);
            this.grpLearnerInfo.Controls.Add(this.txtLearnerLastName);
            this.grpLearnerInfo.Controls.Add(this.txtLearnerFirstName);
            this.grpLearnerInfo.Controls.Add(this.lblLearnerPhoneNumber);
            this.grpLearnerInfo.Controls.Add(this.lblLearnerEmail);
            this.grpLearnerInfo.Controls.Add(this.lblLearnerLastName);
            this.grpLearnerInfo.Controls.Add(this.lblLearnerFirstName);
            this.grpLearnerInfo.Location = new System.Drawing.Point(193, 57);
            this.grpLearnerInfo.Name = "grpLearnerInfo";
            this.grpLearnerInfo.Size = new System.Drawing.Size(586, 113);
            this.grpLearnerInfo.TabIndex = 3;
            this.grpLearnerInfo.TabStop = false;
            this.grpLearnerInfo.Text = "Learner information:";
            // 
            // txtLearnerPhoneNumber
            // 
            this.txtLearnerPhoneNumber.Location = new System.Drawing.Point(381, 67);
            this.txtLearnerPhoneNumber.Name = "txtLearnerPhoneNumber";
            this.txtLearnerPhoneNumber.Size = new System.Drawing.Size(151, 20);
            this.txtLearnerPhoneNumber.TabIndex = 7;
            // 
            // txtLearnerEmail
            // 
            this.txtLearnerEmail.Location = new System.Drawing.Point(381, 24);
            this.txtLearnerEmail.Name = "txtLearnerEmail";
            this.txtLearnerEmail.Size = new System.Drawing.Size(151, 20);
            this.txtLearnerEmail.TabIndex = 6;
            // 
            // txtLearnerLastName
            // 
            this.txtLearnerLastName.Location = new System.Drawing.Point(94, 67);
            this.txtLearnerLastName.Name = "txtLearnerLastName";
            this.txtLearnerLastName.Size = new System.Drawing.Size(151, 20);
            this.txtLearnerLastName.TabIndex = 5;
            // 
            // txtLearnerFirstName
            // 
            this.txtLearnerFirstName.Location = new System.Drawing.Point(94, 28);
            this.txtLearnerFirstName.Name = "txtLearnerFirstName";
            this.txtLearnerFirstName.Size = new System.Drawing.Size(151, 20);
            this.txtLearnerFirstName.TabIndex = 4;
            // 
            // lblLearnerPhoneNumber
            // 
            this.lblLearnerPhoneNumber.AutoSize = true;
            this.lblLearnerPhoneNumber.Location = new System.Drawing.Point(287, 70);
            this.lblLearnerPhoneNumber.Name = "lblLearnerPhoneNumber";
            this.lblLearnerPhoneNumber.Size = new System.Drawing.Size(76, 13);
            this.lblLearnerPhoneNumber.TabIndex = 3;
            this.lblLearnerPhoneNumber.Text = "Phone number";
            // 
            // lblLearnerEmail
            // 
            this.lblLearnerEmail.AutoSize = true;
            this.lblLearnerEmail.Location = new System.Drawing.Point(287, 31);
            this.lblLearnerEmail.Name = "lblLearnerEmail";
            this.lblLearnerEmail.Size = new System.Drawing.Size(32, 13);
            this.lblLearnerEmail.TabIndex = 2;
            this.lblLearnerEmail.Text = "Email";
            // 
            // lblLearnerLastName
            // 
            this.lblLearnerLastName.AutoSize = true;
            this.lblLearnerLastName.Location = new System.Drawing.Point(16, 70);
            this.lblLearnerLastName.Name = "lblLearnerLastName";
            this.lblLearnerLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLearnerLastName.TabIndex = 1;
            this.lblLearnerLastName.Text = "Last name";
            // 
            // lblLearnerFirstName
            // 
            this.lblLearnerFirstName.AutoSize = true;
            this.lblLearnerFirstName.Location = new System.Drawing.Point(16, 31);
            this.lblLearnerFirstName.Name = "lblLearnerFirstName";
            this.lblLearnerFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblLearnerFirstName.TabIndex = 0;
            this.lblLearnerFirstName.Text = "First name";
            // 
            // chkNewLearner
            // 
            this.chkNewLearner.AutoSize = true;
            this.chkNewLearner.Location = new System.Drawing.Point(483, 24);
            this.chkNewLearner.Name = "chkNewLearner";
            this.chkNewLearner.Size = new System.Drawing.Size(83, 17);
            this.chkNewLearner.TabIndex = 2;
            this.chkNewLearner.Text = "New learner";
            this.chkNewLearner.UseVisualStyleBackColor = true;
            this.chkNewLearner.CheckedChanged += new System.EventHandler(this.chkNewLearner_CheckedChanged);
            // 
            // lblFindLearner
            // 
            this.lblFindLearner.AutoSize = true;
            this.lblFindLearner.Location = new System.Drawing.Point(193, 4);
            this.lblFindLearner.Name = "lblFindLearner";
            this.lblFindLearner.Size = new System.Drawing.Size(106, 13);
            this.lblFindLearner.TabIndex = 1;
            this.lblFindLearner.Text = "Find learner by email:";
            // 
            // tabPageTutor
            // 
            this.tabPageTutor.Controls.Add(this.dgvTutorsDisciplines);
            this.tabPageTutor.Controls.Add(this.btnLoadInfoAboutTutor);
            this.tabPageTutor.Controls.Add(this.txtTutorByEmail);
            this.tabPageTutor.Controls.Add(this.grpTutorInfo);
            this.tabPageTutor.Controls.Add(this.lblFindTutor);
            this.tabPageTutor.Location = new System.Drawing.Point(4, 22);
            this.tabPageTutor.Name = "tabPageTutor";
            this.tabPageTutor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTutor.Size = new System.Drawing.Size(953, 501);
            this.tabPageTutor.TabIndex = 1;
            this.tabPageTutor.Text = "Tutor";
            this.tabPageTutor.UseVisualStyleBackColor = true;
            // 
            // dgvTutorsDisciplines
            // 
            this.dgvTutorsDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTutorsDisciplines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTutorsDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutorsDisciplines.Location = new System.Drawing.Point(309, 215);
            this.dgvTutorsDisciplines.Name = "dgvTutorsDisciplines";
            this.dgvTutorsDisciplines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTutorsDisciplines.Size = new System.Drawing.Size(403, 274);
            this.dgvTutorsDisciplines.TabIndex = 11;
            // 
            // btnLoadInfoAboutTutor
            // 
            this.btnLoadInfoAboutTutor.Location = new System.Drawing.Point(402, 19);
            this.btnLoadInfoAboutTutor.Name = "btnLoadInfoAboutTutor";
            this.btnLoadInfoAboutTutor.Size = new System.Drawing.Size(75, 23);
            this.btnLoadInfoAboutTutor.TabIndex = 10;
            this.btnLoadInfoAboutTutor.Text = "Load info";
            this.btnLoadInfoAboutTutor.UseVisualStyleBackColor = true;
            this.btnLoadInfoAboutTutor.Click += new System.EventHandler(this.btnLoadInfoAboutTutor_Click);
            // 
            // txtTutorByEmail
            // 
            this.txtTutorByEmail.Location = new System.Drawing.Point(210, 20);
            this.txtTutorByEmail.Name = "txtTutorByEmail";
            this.txtTutorByEmail.Size = new System.Drawing.Size(177, 20);
            this.txtTutorByEmail.TabIndex = 9;
            this.txtTutorByEmail.TextChanged += new System.EventHandler(this.txtTutorByEmail_TextChanged);
            // 
            // grpTutorInfo
            // 
            this.grpTutorInfo.Controls.Add(this.lblEndWorkingDay);
            this.grpTutorInfo.Controls.Add(this.lblBeginningWorkingDay);
            this.grpTutorInfo.Controls.Add(this.dtmEndWorkingDay);
            this.grpTutorInfo.Controls.Add(this.dtmBeginningWorkingDay);
            this.grpTutorInfo.Controls.Add(this.txtTutorPhoneNumber);
            this.grpTutorInfo.Controls.Add(this.txtTutorEmail);
            this.grpTutorInfo.Controls.Add(this.txtTutorLastName);
            this.grpTutorInfo.Controls.Add(this.txtTutorFirstName);
            this.grpTutorInfo.Controls.Add(this.lblTutorPhoneNumber);
            this.grpTutorInfo.Controls.Add(this.lblTutorEmail);
            this.grpTutorInfo.Controls.Add(this.lblTutorLastName);
            this.grpTutorInfo.Controls.Add(this.lblTutorFirstName);
            this.grpTutorInfo.Location = new System.Drawing.Point(207, 56);
            this.grpTutorInfo.Name = "grpTutorInfo";
            this.grpTutorInfo.Size = new System.Drawing.Size(586, 153);
            this.grpTutorInfo.TabIndex = 8;
            this.grpTutorInfo.TabStop = false;
            this.grpTutorInfo.Text = "Tutor information:";
            // 
            // lblEndWorkingDay
            // 
            this.lblEndWorkingDay.AutoSize = true;
            this.lblEndWorkingDay.Location = new System.Drawing.Point(287, 111);
            this.lblEndWorkingDay.Name = "lblEndWorkingDay";
            this.lblEndWorkingDay.Size = new System.Drawing.Size(86, 13);
            this.lblEndWorkingDay.TabIndex = 11;
            this.lblEndWorkingDay.Text = "End working day";
            // 
            // lblBeginningWorkingDay
            // 
            this.lblBeginningWorkingDay.AutoSize = true;
            this.lblBeginningWorkingDay.Location = new System.Drawing.Point(16, 111);
            this.lblBeginningWorkingDay.Name = "lblBeginningWorkingDay";
            this.lblBeginningWorkingDay.Size = new System.Drawing.Size(114, 13);
            this.lblBeginningWorkingDay.TabIndex = 10;
            this.lblBeginningWorkingDay.Text = "Beginning working day";
            // 
            // dtmEndWorkingDay
            // 
            this.dtmEndWorkingDay.CustomFormat = "HH:mm";
            this.dtmEndWorkingDay.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmEndWorkingDay.Location = new System.Drawing.Point(460, 105);
            this.dtmEndWorkingDay.Name = "dtmEndWorkingDay";
            this.dtmEndWorkingDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtmEndWorkingDay.ShowUpDown = true;
            this.dtmEndWorkingDay.Size = new System.Drawing.Size(72, 20);
            this.dtmEndWorkingDay.TabIndex = 9;
            // 
            // dtmBeginningWorkingDay
            // 
            this.dtmBeginningWorkingDay.CustomFormat = "HH:mm";
            this.dtmBeginningWorkingDay.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmBeginningWorkingDay.Location = new System.Drawing.Point(173, 105);
            this.dtmBeginningWorkingDay.Name = "dtmBeginningWorkingDay";
            this.dtmBeginningWorkingDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtmBeginningWorkingDay.ShowUpDown = true;
            this.dtmBeginningWorkingDay.Size = new System.Drawing.Size(72, 20);
            this.dtmBeginningWorkingDay.TabIndex = 8;
            // 
            // txtTutorPhoneNumber
            // 
            this.txtTutorPhoneNumber.Location = new System.Drawing.Point(381, 67);
            this.txtTutorPhoneNumber.Name = "txtTutorPhoneNumber";
            this.txtTutorPhoneNumber.Size = new System.Drawing.Size(151, 20);
            this.txtTutorPhoneNumber.TabIndex = 7;
            // 
            // txtTutorEmail
            // 
            this.txtTutorEmail.Location = new System.Drawing.Point(381, 24);
            this.txtTutorEmail.Name = "txtTutorEmail";
            this.txtTutorEmail.Size = new System.Drawing.Size(151, 20);
            this.txtTutorEmail.TabIndex = 6;
            // 
            // txtTutorLastName
            // 
            this.txtTutorLastName.Location = new System.Drawing.Point(94, 67);
            this.txtTutorLastName.Name = "txtTutorLastName";
            this.txtTutorLastName.Size = new System.Drawing.Size(151, 20);
            this.txtTutorLastName.TabIndex = 5;
            // 
            // txtTutorFirstName
            // 
            this.txtTutorFirstName.Location = new System.Drawing.Point(94, 28);
            this.txtTutorFirstName.Name = "txtTutorFirstName";
            this.txtTutorFirstName.Size = new System.Drawing.Size(151, 20);
            this.txtTutorFirstName.TabIndex = 4;
            // 
            // lblTutorPhoneNumber
            // 
            this.lblTutorPhoneNumber.AutoSize = true;
            this.lblTutorPhoneNumber.Location = new System.Drawing.Point(287, 70);
            this.lblTutorPhoneNumber.Name = "lblTutorPhoneNumber";
            this.lblTutorPhoneNumber.Size = new System.Drawing.Size(76, 13);
            this.lblTutorPhoneNumber.TabIndex = 3;
            this.lblTutorPhoneNumber.Text = "Phone number";
            // 
            // lblTutorEmail
            // 
            this.lblTutorEmail.AutoSize = true;
            this.lblTutorEmail.Location = new System.Drawing.Point(287, 31);
            this.lblTutorEmail.Name = "lblTutorEmail";
            this.lblTutorEmail.Size = new System.Drawing.Size(32, 13);
            this.lblTutorEmail.TabIndex = 2;
            this.lblTutorEmail.Text = "Email";
            // 
            // lblTutorLastName
            // 
            this.lblTutorLastName.AutoSize = true;
            this.lblTutorLastName.Location = new System.Drawing.Point(16, 70);
            this.lblTutorLastName.Name = "lblTutorLastName";
            this.lblTutorLastName.Size = new System.Drawing.Size(56, 13);
            this.lblTutorLastName.TabIndex = 1;
            this.lblTutorLastName.Text = "Last name";
            // 
            // lblTutorFirstName
            // 
            this.lblTutorFirstName.AutoSize = true;
            this.lblTutorFirstName.Location = new System.Drawing.Point(16, 31);
            this.lblTutorFirstName.Name = "lblTutorFirstName";
            this.lblTutorFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblTutorFirstName.TabIndex = 0;
            this.lblTutorFirstName.Text = "First name";
            // 
            // lblFindTutor
            // 
            this.lblFindTutor.AutoSize = true;
            this.lblFindTutor.Location = new System.Drawing.Point(207, 3);
            this.lblFindTutor.Name = "lblFindTutor";
            this.lblFindTutor.Size = new System.Drawing.Size(95, 13);
            this.lblFindTutor.TabIndex = 6;
            this.lblFindTutor.Text = "Find tutor by email:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 523);
            this.Controls.Add(this.tabModes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SST";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabModes.ResumeLayout(false);
            this.tabPageLearner.ResumeLayout(false);
            this.tabPageLearner.PerformLayout();
            this.pnlSelectTutor.ResumeLayout(false);
            this.pnlSelectTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorsInfo)).EndInit();
            this.pnlLearnerTutorsInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearnersTutorsInfo)).EndInit();
            this.grpLearnerInfo.ResumeLayout(false);
            this.grpLearnerInfo.PerformLayout();
            this.tabPageTutor.ResumeLayout(false);
            this.tabPageTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorsDisciplines)).EndInit();
            this.grpTutorInfo.ResumeLayout(false);
            this.grpTutorInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabModes;
        private System.Windows.Forms.TabPage tabPageLearner;
        private System.Windows.Forms.TabPage tabPageTutor;
        private System.Windows.Forms.Label lblFindLearner;
        private System.Windows.Forms.GroupBox grpLearnerInfo;
        private System.Windows.Forms.CheckBox chkNewLearner;
        private System.Windows.Forms.TextBox txtLearnerPhoneNumber;
        private System.Windows.Forms.TextBox txtLearnerEmail;
        private System.Windows.Forms.TextBox txtLearnerLastName;
        private System.Windows.Forms.TextBox txtLearnerFirstName;
        private System.Windows.Forms.Label lblLearnerPhoneNumber;
        private System.Windows.Forms.Label lblLearnerEmail;
        private System.Windows.Forms.Label lblLearnerLastName;
        private System.Windows.Forms.Label lblLearnerFirstName;
        private System.Windows.Forms.TextBox txtLearnerByEmail;
        private System.Windows.Forms.Button btnLoadInfoAboutLearner;
        private System.Windows.Forms.Button btnShowTutors;
        private System.Windows.Forms.Panel pnlLearnerTutorsInfo;
        private System.Windows.Forms.DataGridView dgvLearnersTutorsInfo;
        private System.Windows.Forms.Button btnMakePaid;
        private System.Windows.Forms.Button btnMakeLessonOccured;
        private System.Windows.Forms.Button btnCancelSelectedLesson;
        private System.Windows.Forms.Panel pnlSelectTutor;
        private System.Windows.Forms.DataGridView dgvTutorsInfo;
        private System.Windows.Forms.ComboBox cmbDisciplinesFilter;
        private System.Windows.Forms.Label lblPriceBetween;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.Button btnChangeTutor;
        private System.Windows.Forms.Button btnSelectTutor;
        private System.Windows.Forms.Button btnLoadInfoAboutTutor;
        private System.Windows.Forms.TextBox txtTutorByEmail;
        private System.Windows.Forms.GroupBox grpTutorInfo;
        private System.Windows.Forms.TextBox txtTutorPhoneNumber;
        private System.Windows.Forms.TextBox txtTutorEmail;
        private System.Windows.Forms.TextBox txtTutorLastName;
        private System.Windows.Forms.TextBox txtTutorFirstName;
        private System.Windows.Forms.Label lblTutorPhoneNumber;
        private System.Windows.Forms.Label lblTutorEmail;
        private System.Windows.Forms.Label lblTutorLastName;
        private System.Windows.Forms.Label lblTutorFirstName;
        private System.Windows.Forms.Label lblFindTutor;
        private System.Windows.Forms.DateTimePicker dtmBeginningWorkingDay;
        private System.Windows.Forms.DataGridView dgvTutorsDisciplines;
        private System.Windows.Forms.Label lblEndWorkingDay;
        private System.Windows.Forms.Label lblBeginningWorkingDay;
        private System.Windows.Forms.DateTimePicker dtmEndWorkingDay;
        private System.Windows.Forms.DataGridView dgvDayTime;
        private System.Windows.Forms.Button btnAddDay;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.TextBox txtAmountLessons;
        private System.Windows.Forms.Label lblFirstDate;
        private System.Windows.Forms.Label lblAmountLessons;
        private System.Windows.Forms.DateTimePicker dtmFirstLessonStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Button btnMakeOrder;
    }
}

