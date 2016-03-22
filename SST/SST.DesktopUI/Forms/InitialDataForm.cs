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

namespace SST.DesktopUI.Forms
{
    public partial class InitialDataForm : Form
    {
        private int _id;
        private ITutorRepository _tutorRepository;
        private ILessonRepository _lessonRepository;

        public int AmountLessons { get; set; }
        public DateTime FirstLessonDate { get; set; }
        public TimeSpan FirstLessonTime { get; set; }
        public bool IsValidData { get; set; }

        public InitialDataForm(int id)
        {            
            InitializeComponent();
            _id = id;
            _tutorRepository = new SqlTutorRepository(ConfigurationManager.ConnectionStrings["SSTDb"].ConnectionString);
            _lessonRepository = new SqlLessonRepository(ConfigurationManager.ConnectionStrings["SSTDb"].ConnectionString);
            dtmFirstLessonStart.MinDate = DateTime.Now;
            IsValidData = false;
        }

        private void dtmFirstLessonStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtmFirstLessonStart.Value.DayOfWeek == DayOfWeek.Saturday || dtmFirstLessonStart.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show(this, "You can't choose holiday.", "Date Pick Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtmFirstLessonStart.Value = DateTime.Now;
            }

            Tutor tutor = _tutorRepository.GetTutorById(_id);

            List<string> freeHours = new List<string>();

            for (TimeSpan t = tutor.BeginningWorkingDay; t < tutor.EndWorkingDay; t = t.Add(new TimeSpan(1, 0, 0)))
            {
                freeHours.Add(t.ToString());                
            }

            List<TimeSpan> lessons = (from lesson in _lessonRepository.GetLessonsDateTimesByTutorId(_id).ToList<Lesson>() where lesson.LessonTime.Date == dtmFirstLessonStart.Value.Date select lesson.LessonTime.TimeOfDay).ToList<TimeSpan>();

            foreach (var l in lessons)
            {
                freeHours.Remove(l.ToString());
            }

            cmbTime.DataSource = freeHours;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int amountLessons;
            if (int.TryParse(txtAmountLessons.Text, out amountLessons) && amountLessons > 0)
            {
                AmountLessons = amountLessons;
                FirstLessonDate = dtmFirstLessonStart.Value;
                FirstLessonTime = TimeSpan.Parse(cmbTime.Text);
                IsValidData = true;
            }
            else
            {
                MessageBox.Show(this, "Invalid entered amount of lessons", "Invalid Entered Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
