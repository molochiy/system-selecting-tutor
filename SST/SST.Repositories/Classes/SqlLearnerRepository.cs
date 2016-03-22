using SST.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SST.Entities;
using System.Data.SqlClient;
using System.Data;

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
        private const string spInsertLearner = "spInsertLearner";


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

        public int InsertLearner(Learner learner)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = spInsertLearner;

                    command.Parameters.AddWithValue("@FirstName", learner.FirstName);
                    command.Parameters.AddWithValue("@LastName", learner.LastName);
                    command.Parameters.AddWithValue("@Email", learner.Email);
                    command.Parameters.AddWithValue("@PhoneNumber", learner.PhoneNumber);

                    SqlParameter output = new SqlParameter("@Id", SqlDbType.Int);
                    output.Direction = ParameterDirection.Output;
                    command.Parameters.Add(output);

                    command.ExecuteNonQuery();
                    return (int)output.Value;
                }
            }
        }

        #endregion

    }
}
