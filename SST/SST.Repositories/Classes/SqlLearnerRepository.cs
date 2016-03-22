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
    public class SqlLearnerRepository : ILearnerRepository
    {
        #region Private Fields

        private readonly string _connection;

        #endregion
        #region Queries

        private const string spGetLearnersByPartOfEmail = "spGetLearnersByPartOfEmail";
        private const string spGetLearnerByEmail = "spGetLearnerByEmail";


        #endregion

        #region Constructors

        public SqlLearnerRepository(string connection)
        {
            _connection = connection;
        }

        #endregion

        #region ILearnerRepository

        public IEnumerable<Learner> GetLearnersByPartOfEmail(string email)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = spGetLearnersByPartOfEmail;
                    command.Parameters.AddWithValue("@Email", email);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Learner> learners = new List<Learner>();
                        while (reader.Read())
                        {
                            Learner learner = new Learner();
                            learner.Id = (int)reader["Id"];
                            learner.FirstName = reader["FirstName"].ToString();
                            learner.LastName = reader["LastName"].ToString();
                            learner.Email = reader["Email"].ToString();
                            learner.PhoneNumber = reader["PhoneNumber"].ToString();
                            learners.Add(learner);
                        }
                        return learners;
                    }
                }
            }
        }

        public Learner GetLearnerByEmail(string email)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = spGetLearnerByEmail;
                    command.Parameters.AddWithValue("@Email", email);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Learner learner = null;
                        while (reader.Read())
                        {
                            learner = new Learner();
                            learner.Id = (int)reader["Id"];
                            learner.FirstName = reader["FirstName"].ToString();
                            learner.LastName = reader["LastName"].ToString();
                            learner.Email = reader["Email"].ToString();
                            learner.PhoneNumber = reader["PhoneNumber"].ToString();
                        }
                        return learner;
                    }
                }
            }
        }

        #endregion

    }
}
