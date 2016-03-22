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
    public class SqlTutorRepository : ITutorRepository
    {
        #region Private Fields

        private readonly string _connection;

        #endregion
        #region Queries

        private const string spSelectAllTutorsWithDisciplinesAndPrices = "spSelectAllTutorsWithDisciplinesAndPrices";        
        private const string spGetTutorsByPartOfEmail = "spGetTutorsByPartOfEmail";
        private const string spGetTutorByEmail = "spGetTutorByEmail";
        private const string spGetTutorById = "spGetTutorById";

        #endregion

        #region Constructors

        public SqlTutorRepository(string connection)
        {
            _connection = connection;
        }

        #endregion

        public IEnumerable<Tutor> SelectAllTutorsWithDisciplinesAndPrices()
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = spSelectAllTutorsWithDisciplinesAndPrices;                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Tutor> tutors = new List<Tutor>();
                        while (reader.Read())
                        {
                            Tutor tutor = new Tutor();                            
                            tutor.PriceInfo = new Price();
                            tutor.DisciplineInfo = new Discipline();                            
                            tutor.Id = (int)reader["Id"];
                            tutor.FirstName = reader["FirstName"].ToString();
                            tutor.LastName = reader["LastName"].ToString();
                            tutor.BeginningWorkingDay = (TimeSpan)reader["BeginningWorkingDay"];
                            tutor.EndWorkingDay = (TimeSpan)reader["EndWorkingDay"];
                            tutor.PriceInfo.LessonPrice = (decimal)reader["LessonPrice"];
                            tutor.DisciplineInfo.Name = reader["Name"].ToString();
                            tutors.Add(tutor);
                        }
                        return tutors;
                    }
                }
            }
        }

        public IEnumerable<Tutor> GetTutorsByPartOfEmail(string email)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = spGetTutorsByPartOfEmail;
                    command.Parameters.AddWithValue("@Email", email);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Tutor> tutors = new List<Tutor>();
                        while (reader.Read())
                        {
                            Tutor tutor = new Tutor();
                            tutor.Id = (int)reader["Id"];
                            tutor.FirstName = reader["FirstName"].ToString();
                            tutor.LastName = reader["LastName"].ToString();
                            tutor.Email = reader["Email"].ToString();
                            tutor.PhoneNumber = reader["PhoneNumber"].ToString();
                            tutor.BeginningWorkingDay = (TimeSpan)reader["BeginningWorkingDay"];
                            tutor.EndWorkingDay = (TimeSpan)reader["EndWorkingDay"];
                            tutors.Add(tutor);
                        }
                        return tutors;
                    }
                }
            }
        }

        public Tutor GetTutorByEmail(string email)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = spGetTutorByEmail;
                    command.Parameters.AddWithValue("@Email", email);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Tutor tutor = null;
                        while (reader.Read())
                        {
                            tutor = new Tutor();
                            tutor.Id = (int)reader["Id"];
                            tutor.FirstName = reader["FirstName"].ToString();
                            tutor.LastName = reader["LastName"].ToString();
                            tutor.Email = reader["Email"].ToString();
                            tutor.PhoneNumber = reader["PhoneNumber"].ToString();
                            tutor.BeginningWorkingDay = (TimeSpan)reader["BeginningWorkingDay"];
                            tutor.EndWorkingDay = (TimeSpan)reader["EndWorkingDay"];
                        }
                        return tutor;
                    }
                }
            }
        }

        public Tutor GetTutorById(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = spGetTutorById;
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Tutor tutor = null;
                        while (reader.Read())
                        {
                            tutor = new Tutor();
                            tutor.Id = (int)reader["Id"];
                            tutor.FirstName = reader["FirstName"].ToString();
                            tutor.LastName = reader["LastName"].ToString();
                            tutor.Email = reader["Email"].ToString();
                            tutor.PhoneNumber = reader["PhoneNumber"].ToString();
                            tutor.BeginningWorkingDay = (TimeSpan)reader["BeginningWorkingDay"];
                            tutor.EndWorkingDay = (TimeSpan)reader["EndWorkingDay"];
                        }
                        return tutor;
                    }
                }
            }
        }
    }
}
