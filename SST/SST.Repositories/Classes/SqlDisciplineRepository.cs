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
    public class SqlDisciplineRepository : IDisciplineRepository
    {
        #region Private Fields

        private readonly string _connection;

        #endregion
        #region Queries

        private const string spGetAllDesciplines = "spGetAllDesciplines";
        private const string spGetDisciplinesByTutorId = "spGetDisciplinesByTutorId";

        #endregion

        #region Constructors

        public SqlDisciplineRepository(string connection)
        {
            _connection = connection;
        }

        #endregion
        public IEnumerable<Discipline> GetAllDesciplines()
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = spGetAllDesciplines;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Discipline> disciplines = new List<Discipline>();
                        while (reader.Read())
                        {
                            Discipline discipline = new Discipline();
                            discipline.Id = (int)reader["Id"];
                            discipline.Name = reader["Name"].ToString();
                            disciplines.Add(discipline);
                        }
                        return disciplines;
                    }
                }
            }
        }

        public IEnumerable<Discipline> GetDisciplinesByTutorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = spGetDisciplinesByTutorId;
                    command.Parameters.AddWithValue("@TutorId", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Discipline> disciplines = new List<Discipline>();
                        while (reader.Read())
                        {
                            Discipline discipline = new Discipline();
                            discipline.TutorInfo = new Tutor();
                            discipline.PriceInfo = new Price();
                            discipline.Id = (int)reader["DisciplineId"];
                            discipline.TutorInfo.Id = (int)reader["TutorId"];
                            discipline.Name = reader["Name"].ToString();
                            discipline.PriceInfo.LessonPrice = (decimal)reader["LessonPrice"];
                            disciplines.Add(discipline);
                        }
                        return disciplines;
                    }
                }
            }
        }
    }
}
