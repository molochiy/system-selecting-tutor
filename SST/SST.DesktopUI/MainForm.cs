using SST.DesktopUI.Code;
using SST.DesktopUI.Forms;
using SST.Entities;
using SST.Repositories.Classes;
using SST.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SST.DesktopUI
{
    public partial class MainForm : Form
    {
        #region Private Fields

        enum LessonStatus
        {
            Default = 0,
            Occured = 1,
            Canceled = 2
        }

        private ILearnerRepository _learnerRepository;
        private ILessonRepository _lessonRepository;
        private ITutorRepository _tutorRepository;
        private IDisciplineRepository _disciplineRepository;
        private IPriceRepository _priceRepository;
        private Learner _learner;
        private Tutor _tutor;

        BindingList<string> _unselectedDays = new BindingList<string>() { DayOfWeek.Monday.ToString(), DayOfWeek.Tuesday.ToString(), DayOfWeek.Wednesday.ToString(), DayOfWeek.Thursday.ToString(), DayOfWeek.Friday.ToString() };

        #endregion
        public MainForm()
        {
            InitializeComponent();

            pnlLearnerTutorsInfo.Visible = false;
            pnlSelectTutor.Visible = false;

            txtLearnerByEmail.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtLearnerByEmail.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTutorByEmail.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTutorByEmail.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtLearnerFirstName.ReadOnly = true;
            txtLearnerLastName.ReadOnly = true;
            txtLearnerEmail.ReadOnly = true;
            txtLearnerPhoneNumber.ReadOnly = true;

            txtTutorFirstName.ReadOnly = true;
            txtTutorLastName.ReadOnly = true;
            txtTutorEmail.ReadOnly = true;
            txtTutorPhoneNumber.ReadOnly = true;
            dtmBeginningWorkingDay.Enabled = false;
            dtmEndWorkingDay.Enabled = false;

            lblAmountLessons.Visible = false;
            lblFirstDate.Visible = false;
            dtmFirstLessonStart.Visible = false;
            txtAmountLessons.Visible = false;
            dgvDayTime.Visible = false;
            cmbDay.Visible = false;
            cmbTime.Visible = false;
            btnAddDay.Visible = false;

            btnChangeTutor.Enabled = false;

            btnShowTutors.Enabled = false;

            _learnerRepository = new SqlLearnerRepository(ConfigurationManager.ConnectionStrings["SSTDb"].ConnectionString);
            _lessonRepository = new SqlLessonRepository(ConfigurationManager.ConnectionStrings["SSTDb"].ConnectionString);
            _tutorRepository = new SqlTutorRepository(ConfigurationManager.ConnectionStrings["SSTDb"].ConnectionString);
            _disciplineRepository = new SqlDisciplineRepository(ConfigurationManager.ConnectionStrings["SSTDb"].ConnectionString);
            _priceRepository = new SqlPriceRepository(ConfigurationManager.ConnectionStrings["SSTDb"].ConnectionString);
            _learner = null;
            _tutor = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("SST: {0} {1}", CurrentUser.FirstName, CurrentUser.LastName);
        }

        private void chkNewLearner_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNewLearner.Checked)
            {
                txtLearnerFirstName.Clear();
                txtLearnerLastName.Clear();
                txtLearnerEmail.Clear();
                txtLearnerPhoneNumber.Clear();
                txtLearnerByEmail.Clear();
                txtLearnerFirstName.ReadOnly = false;
                txtLearnerLastName.ReadOnly = false;
                txtLearnerEmail.ReadOnly = false;
                txtLearnerPhoneNumber.ReadOnly = false;
                txtLearnerByEmail.Enabled = false;
                btnLoadInfoAboutLearner.Enabled = false;

                btnShowTutors.Enabled = true;
            }
            else
            {
                txtLearnerFirstName.ReadOnly = true;
                txtLearnerLastName.ReadOnly = true;
                txtLearnerEmail.ReadOnly = true;
                txtLearnerPhoneNumber.ReadOnly = true;
                txtLearnerByEmail.Enabled = true;
                btnLoadInfoAboutLearner.Enabled = true;

                btnShowTutors.Enabled = false;
            }
        }

        private void txtLearnerByEmail_TextChanged(object sender, EventArgs e)
        {

            List<Learner> learners = _learnerRepository.GetLearnersByPartOfEmail(txtLearnerByEmail.Text).ToList<Learner>();

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            foreach (var l in learners)
            {
                collection.Add(l.Email);
            }

            this.txtLearnerByEmail.AutoCompleteCustomSource = collection;
        }

        private void LoadInfoAboutLearnerToDataGrid()
        {

            pnlLearnerTutorsInfo.Visible = true;
            pnlSelectTutor.Visible = false;

            List<Lesson> lessons = _lessonRepository.GetLessonsByLearnerId(_learner.Id).ToList<Lesson>();

            var inf = (from lesson in lessons select new { LessonId = lesson.Id, FirstName = lesson.TutorInfo.FirstName, LastName = lesson.TutorInfo.LastName, Discipline = lesson.DisciplineInfo.Name, LessonTime = lesson.LessonTime, Price = lesson.Price, Paid = lesson.IsPaid, Status = lesson.StatusInfo.StatusName }).ToList();

            dgvLearnersTutorsInfo.DataSource = inf;

            foreach (DataGridViewRow row in dgvLearnersTutorsInfo.Rows)
            {
                string status = row.Cells[dgvLearnersTutorsInfo.Columns["Status"].Index].Value.ToString();
                bool paid = (bool)row.Cells[dgvLearnersTutorsInfo.Columns["Paid"].Index].Value;
                if (status == LessonStatus.Occured.ToString() && paid)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                else if (status == LessonStatus.Occured.ToString())
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                if (status == LessonStatus.Canceled.ToString())
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void btnLoadInfo_Click(object sender, EventArgs e)
        {
            _learner = _learnerRepository.GetLearnerByEmail(txtLearnerByEmail.Text);

            if (_learner == null)
            {
                MessageBox.Show(this, String.Format("Learner with email {0} in not registered", txtLearnerByEmail.Text), "Learner Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtLearnerFirstName.Text = _learner.FirstName;
            txtLearnerLastName.Text = _learner.LastName;
            txtLearnerEmail.Text = _learner.Email;
            txtLearnerPhoneNumber.Text = _learner.PhoneNumber;

            LoadInfoAboutLearnerToDataGrid();

            btnShowTutors.Enabled = true;
        }

        private void btnCancelSelectedLessons_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = dgvLearnersTutorsInfo.SelectedRows;
            if (selectedRow != null)
            {
                int id = (int)dgvLearnersTutorsInfo[0, selectedRow[0].Index].Value;
                _lessonRepository.UpdateLessonStatus(id, (int)LessonStatus.Canceled);
            }

            LoadInfoAboutLearnerToDataGrid();

        }

        private void btnMakeLessonsOccured_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = dgvLearnersTutorsInfo.SelectedRows;
            if (selectedRow != null)
            {
                int id = (int)dgvLearnersTutorsInfo[0, selectedRow[0].Index].Value;
                _lessonRepository.UpdateLessonStatus(id, (int)LessonStatus.Occured);
            }

            LoadInfoAboutLearnerToDataGrid();
        }

        private void btnMakePaid_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = dgvLearnersTutorsInfo.SelectedRows;
            if (selectedRow != null)
            {
                int id = (int)dgvLearnersTutorsInfo[0, selectedRow[0].Index].Value;
                _lessonRepository.UpdateLessonPaid(id);
            }

            LoadInfoAboutLearnerToDataGrid();
        }

        private void btnSelectTutor_Click(object sender, EventArgs e)
        {
            if (chkNewLearner.Checked && (txtLearnerFirstName.Text == string.Empty || txtLearnerLastName.Text == string.Empty || txtLearnerEmail.Text == string.Empty || txtLearnerPhoneNumber.Text == string.Empty))
            {
                MessageBox.Show(this, "You must enter all data about new learner.", "Entered Learner Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Tutor> tutors = _tutorRepository.SelectAllTutorsWithDisciplinesAndPrices().ToList<Tutor>();

            var inf = (from tutor in tutors select new { TutorId = tutor.Id, FirstName = tutor.FirstName, LastName = tutor.LastName, BeginningWorkingDay = tutor.BeginningWorkingDay, EndWorkingDay = tutor.EndWorkingDay, Discipline = tutor.DisciplineInfo.Name, PricePerHour = tutor.PriceInfo.LessonPrice }).ToList();

            dgvTutorsInfo.DataSource = inf;

            List<Discipline> disciplines = _disciplineRepository.GetAllDesciplines().ToList<Discipline>();

            List<string> source = (from discipline in disciplines select discipline.Name).ToList<string>();

            source.Insert(0, "All disciplines");

            cmbDisciplinesFilter.DataSource = source;

            txtMinPrice.Text = (from info in inf select info.PricePerHour).Min().ToString();
            txtMaxPrice.Text = (from info in inf select info.PricePerHour).Max().ToString();

            pnlLearnerTutorsInfo.Visible = false;
            pnlSelectTutor.Visible = true;
        }

        private void Filter()
        {
            List<Tutor> tutors = _tutorRepository.SelectAllTutorsWithDisciplinesAndPrices().ToList<Tutor>();

            decimal minPrice;
            decimal maxPrice;

            if (!Decimal.TryParse(txtMinPrice.Text, out minPrice))
            {
                minPrice = (from tutor in tutors select tutor.PriceInfo.LessonPrice).Min();
            };

            if (!Decimal.TryParse(txtMaxPrice.Text, out maxPrice))
            {
                maxPrice = (from tutor in tutors select tutor.PriceInfo.LessonPrice).Max();
            };

            var inf = (from tutor in tutors where tutor.PriceInfo.LessonPrice >= minPrice && tutor.PriceInfo.LessonPrice <= maxPrice select new { TutorId = tutor.Id, FirstName = tutor.FirstName, LastName = tutor.LastName, BeginningWorkingDay = tutor.BeginningWorkingDay, EndWorkingDay = tutor.EndWorkingDay, Discipline = tutor.DisciplineInfo.Name, PricePerHour = tutor.PriceInfo.LessonPrice }).ToList();

            if (cmbDisciplinesFilter.Text != "All disciplines" && cmbDisciplinesFilter.Text != string.Empty)
            {
                inf = (from i in inf where i.Discipline == cmbDisciplinesFilter.Text select i).ToList();
            }

            dgvTutorsInfo.DataSource = inf;
        }

        private void cmbDisciplinesFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void MinPriceFilter()
        {
            decimal price;
            if (!Decimal.TryParse(txtMinPrice.Text, out price) || price <= 0 || price > Convert.ToDecimal(txtMaxPrice.Text))
            {
                MessageBox.Show("Invalid entered number! Price must be more than 0, less equel than max price and in the form x,xx.", "Parameter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Filter();
        }

        private void txtMinPrice_Leave(object sender, EventArgs e)
        {
            MinPriceFilter();
        }

        private void MaxPriceFilter()
        {
            decimal price;
            if (!Decimal.TryParse(txtMaxPrice.Text, out price) || price <= 0 || price < Convert.ToDecimal(txtMinPrice.Text))
            {
                MessageBox.Show("Invalid entered number! Price must be more than 0, more equel than min price and in the form x,xx.", "Parameter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            Filter();
        }

        private void txtMaxPrice_Leave(object sender, EventArgs e)
        {
            MaxPriceFilter();
        }

        private void btnSelectTutor_Click_1(object sender, EventArgs e)
        {
            dgvTutorsInfo.Enabled = false;
            cmbDisciplinesFilter.Enabled = false;
            txtMaxPrice.Enabled = false;
            txtMinPrice.Enabled = false;
            btnChangeTutor.Enabled = true;
            btnSelectTutor.Enabled = false;

            DataGridViewSelectedRowCollection selectedRow = dgvTutorsInfo.SelectedRows;

            int id = (int)dgvTutorsInfo[0, selectedRow[0].Index].Value;

            _tutor = _tutorRepository.GetTutorById(id);

            InitialDataForm initialDataForm = new InitialDataForm(id);

            while (!initialDataForm.IsValidData)
            {
                if (initialDataForm.ShowDialog() == DialogResult.Cancel)
                {
                    break;
                };
            }

            txtAmountLessons.Text = initialDataForm.AmountLessons.ToString();
            dtmFirstLessonStart.Value = initialDataForm.FirstLessonDate;
            dgvDayTime.Rows.Add(initialDataForm.FirstLessonDate.DayOfWeek.ToString(), initialDataForm.FirstLessonTime.ToString());

            _unselectedDays.Remove(dtmFirstLessonStart.Value.DayOfWeek.ToString());
            cmbDay.DataSource = _unselectedDays;

            lblAmountLessons.Visible = true;
            lblFirstDate.Visible = true;
            dtmFirstLessonStart.Visible = true;
            txtAmountLessons.Visible = true;
            dgvDayTime.Visible = true;
            cmbDay.Visible = true;
            cmbTime.Visible = true;
            btnAddDay.Visible = true;
        }

        private void AllowSelectTutor()
        {
            dgvTutorsInfo.Enabled = true;
            lblAmountLessons.Visible = false;
            lblFirstDate.Visible = false;
            dtmFirstLessonStart.Visible = false;
            txtAmountLessons.Visible = false;
            dgvDayTime.Visible = false;
            cmbDay.Visible = false;
            cmbTime.Visible = false;
            btnAddDay.Visible = false;
            cmbDay.Enabled = true;
            cmbTime.Enabled = true;
            btnAddDay.Enabled = true;
            dgvDayTime.Rows.Clear();
            _unselectedDays = new BindingList<string>() { DayOfWeek.Monday.ToString(), DayOfWeek.Tuesday.ToString(), DayOfWeek.Wednesday.ToString(), DayOfWeek.Thursday.ToString(), DayOfWeek.Friday.ToString() };

            cmbDisciplinesFilter.Enabled = true;
            txtMaxPrice.Enabled = true;
            txtMinPrice.Enabled = true;

            btnChangeTutor.Enabled = false;
            btnSelectTutor.Enabled = true;
        }

        private void btnChangeTutor_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(this, "All selected data will be lost. Do you still want change a selected tutor?", "Change tutor warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                AllowSelectTutor();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btnLoadInfoAboutTutor_Click(object sender, EventArgs e)
        {
            Tutor tutor = _tutorRepository.GetTutorByEmail(txtTutorByEmail.Text);

            List<Discipline> disciplines = _disciplineRepository.GetDisciplinesByTutorId(tutor.Id).ToList<Discipline>();

            txtTutorFirstName.Text = tutor.FirstName;
            txtTutorLastName.Text = tutor.LastName;
            txtTutorEmail.Text = tutor.Email;
            txtTutorPhoneNumber.Text = tutor.PhoneNumber;
            dtmBeginningWorkingDay.Text = tutor.BeginningWorkingDay.ToString();
            dtmEndWorkingDay.Text = tutor.EndWorkingDay.ToString();

            var inf = (from discipline in disciplines select new { TutorId = discipline.TutorInfo.Id, DisciplineId = discipline.Id, DisciplineName = discipline.Name, PricePerHour = discipline.PriceInfo.LessonPrice }).ToList();

            dgvTutorsDisciplines.DataSource = inf;
        }

        private void txtTutorByEmail_TextChanged(object sender, EventArgs e)
        {
            List<Tutor> tutors = _tutorRepository.GetTutorsByPartOfEmail(txtTutorByEmail.Text).ToList<Tutor>();

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            foreach (var t in tutors)
            {
                collection.Add(t.Email);
            }

            this.txtTutorByEmail.AutoCompleteCustomSource = collection;
        }

        private void txtMinPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MinPriceFilter();
            }
        }

        private void txtMaxPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MaxPriceFilter();
            }
        }

        private void btnAddDay_Click(object sender, EventArgs e)
        {
            if (dgvDayTime.Rows.Count < int.Parse(txtAmountLessons.Text))
            {
                dgvDayTime.Rows.Add(cmbDay.SelectedValue.ToString(), cmbTime.SelectedValue.ToString());

                _unselectedDays.Remove(cmbDay.SelectedValue.ToString());

                if (_unselectedDays.Count == 0)
                {
                    cmbDay.Enabled = false;
                    cmbTime.Enabled = false;
                    btnAddDay.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show(this, "You can't add days more then lesson.", "Day Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDay_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_unselectedDays.Count != 0)
            {
                DateTime date = dtmFirstLessonStart.Value;
                while (date.DayOfWeek.ToString() != cmbDay.SelectedValue.ToString())
                {
                    date = date.AddDays(1);
                }


                List<string> freeHours = new List<string>();

                for (TimeSpan t = _tutor.BeginningWorkingDay; t < _tutor.EndWorkingDay; t = t.Add(new TimeSpan(1, 0, 0)))
                {
                    freeHours.Add(t.ToString());
                }

                List<TimeSpan> lessons = (from lesson in _lessonRepository.GetLessonsDateTimesByTutorId(_tutor.Id).ToList<Lesson>() where lesson.LessonTime.Date == date.Date select lesson.LessonTime.TimeOfDay).ToList<TimeSpan>();

                foreach (var l in lessons)
                {
                    freeHours.Remove(l.ToString());
                }

                cmbTime.DataSource = freeHours;

            }
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            int amountLessons = int.Parse(txtAmountLessons.Text);
            List<Tuple<DateTime, TimeSpan>> dates = new List<Tuple<DateTime, TimeSpan>>();
            foreach (DataGridViewRow row in dgvDayTime.Rows)
            {
                DateTime date = dtmFirstLessonStart.Value;
                while (date.DayOfWeek.ToString() != row.Cells[0].Value.ToString())
                {
                    date = date.AddDays(1);
                }

                TimeSpan time = TimeSpan.Parse(row.Cells[1].Value.ToString());

                dates.Add(new Tuple<DateTime, TimeSpan>(date, time));
            }

            dates.Sort((x, y) => x.Item1.CompareTo(y.Item1));

            List<Lesson> lessons = new List<Lesson>();

            for (int i = 0; i < dates.Count; i++)
            {
                for (int j = 0; j < amountLessons / dates.Count; j++)
                {
                    Lesson lesson = new Lesson();

                    lesson.LessonTime = dates[i].Item1.AddDays(j * 7).Date.Add(dates[i].Item2);

                    List<TimeSpan> lessonsTime = (from lessonTime in _lessonRepository.GetLessonsDateTimesByTutorId(_tutor.Id).ToList<Lesson>() where lessonTime.LessonTime.Date == lesson.LessonTime.Date select lessonTime.LessonTime.TimeOfDay).ToList<TimeSpan>();

                    if (lessonsTime.Contains(lesson.LessonTime.TimeOfDay))
                    {
                        MessageBox.Show(this, "You can't do order, beacuse this tutor have lesson at this time in future. Try change a tutor or set less amount of lessons.", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        AllowSelectTutor();

                        return;
                    }

                    lessons.Add(lesson);
                }
            }

            for (int i = 0; i < amountLessons % dates.Count; i++)
            {
                Lesson lesson = new Lesson();

                lesson.LessonTime = dates[i].Item1.AddDays((amountLessons / dates.Count) * 7).Date.Add(dates[i].Item2);

                List<TimeSpan> lessonsTime = (from lessonTime in _lessonRepository.GetLessonsDateTimesByTutorId(_tutor.Id).ToList<Lesson>() where lessonTime.LessonTime.Date == lesson.LessonTime.Date select lessonTime.LessonTime.TimeOfDay).ToList<TimeSpan>();

                if (lessonsTime.Contains(lesson.LessonTime.TimeOfDay))
                {
                    MessageBox.Show(this, "You can't do order, beacuse this tutor have lesson at this time in future. Try change a tutor or set less amount of lessons.", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    AllowSelectTutor();

                    return;
                }

                lessons.Add(lesson);
            }

            if (chkNewLearner.Checked)
            {
                _learner = new Learner();
                _learner.FirstName = txtLearnerFirstName.Text;
                _learner.LastName = txtLearnerLastName.Text;
                _learner.Email = txtLearnerEmail.Text;
                _learner.PhoneNumber = txtLearnerPhoneNumber.Text;
                try
                {
                    _learner.Id = _learnerRepository.InsertLearner(_learner);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DataGridViewSelectedRowCollection selectedRow = dgvTutorsInfo.SelectedRows;

            string disciplineName = dgvTutorsInfo[5, selectedRow[0].Index].Value.ToString();
            int disciplineId = _disciplineRepository.GetDisciplineIdByName(disciplineName);
            decimal price = _priceRepository.GetPriceByTutorIdANDDisciplineId(_tutor.Id, disciplineId);

            foreach (var lesson in lessons)
            {
                lesson.TutorId = _tutor.Id;
                lesson.LearnerId = _learner.Id;
                lesson.DisciplineId = disciplineId;
                lesson.Price = price;
                lesson.IsPaid = false;
                lesson.StatusId = 0;
                lesson.UserId = CurrentUser.Id;
            }

            try
            {
                _lessonRepository.InsertLessons(lessons);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(this, "Order done.", "Order Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AllowSelectTutor();
            LoadInfoAboutLearnerToDataGrid();
        }
    }
}
