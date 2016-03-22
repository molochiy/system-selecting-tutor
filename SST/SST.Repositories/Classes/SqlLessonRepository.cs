using SST.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SST.Entities;
using System.Data.SqlClient;

namespace SST.Repositories.Classes
{
    public class SqlLessonRepository : ILessonRepository
    {
        #region Private Fields

        private readonly string _connection;

        #endregion
        #region Queries

        private const string spGetLessonsByLearnerId = "spGetLessonsByLearnerId";
        private const string spGetLessonsDateTimesByTutorId = "spGetLessonsDateTimesByTutorId";
        private const string spUpdateLessonStatus = "spUpdateLessonStatus";
        private const string spUpdateLessonPaid = "spUpdateLessonPaid";

        #endregion


        #region Constructors
        public SqlLessonRepository(string connection)
        {
            _connection = connection;
        }
        #endregion

        public IEnumerable<Lesson> GetLessonsByLearnerId(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = spGetLessonsByLearnerId;
                    command.Parameters.AddWithValue("@LearnerId", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Lesson> lessons = new List<Lesson>();
                        while (reader.Read())
                        {
                            Lesson lesson = new Lesson();
                            lesson.TutorInfo = new Tutor();                            
                            lesson.DisciplineInfo = new Discipline();
                            lesson.StatusInfo = new Status();
                            lesson.Id = (int)reader["Id"];
                            lesson.TutorInfo.FirstName = reader["TutorFirstName"].ToString();
                            lesson.TutorInfo.LastName = reader["TutorLastName"].ToString();
                            lesson.DisciplineInfo.Name = reader["Discipline"].ToString();
                            lesson.LessonTime = (DateTime)reader["LessonTime"];
                            lesson.Price = (decimal)reader["Price"];
                            lesson.IsPaid = (bool)reader["Paid"];
                            lesson.StatusInfo.StatusName = reader["Status"].ToString();
                            lessons.Add(lesson);
                        }
                        return lessons;
                    }
                }
            }
        }

        public void UpdateLessonStatus(int id, int status)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = spUpdateLessonStatus;
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Status", status);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateLessonPaid(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = spUpdateLessonPaid;
                    command.Parameters.AddWithValue("@Id", id);                    
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Lesson> GetLessonsDateTimesByTutorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = spGetLessonsDateTimesByTutorId;
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Lesson> lessons = new List<Lesson>();
                        while (reader.Read())
                        {
                            Lesson lesson = new Lesson();
                            lesson.TutorInfo = new Tutor();
                            lesson.LessonTime = (DateTime)reader["LessonTime"];
                            lesson.TutorInfo.BeginningWorkingDay = (TimeSpan)reader["BeginningWorkingDay"];
                            lesson.TutorInfo.EndWorkingDay = (TimeSpan)reader["EndWorkingDay"];
                            lessons.Add(lesson);
                        }
                        return lessons;
                    }
                }
            }
        }
    }
}
