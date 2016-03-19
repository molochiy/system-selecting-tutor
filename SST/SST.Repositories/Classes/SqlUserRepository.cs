using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SST.Entities;
using SST.Repositories.Intefaces;
using System.Data.SqlClient;
using System.Data;

namespace SST.Repositories.Classes
{
    public class SqlUserRepository : IUserRepository
    {
        #region Private Fields

        private readonly string _connection;

        #endregion
        #region Queries

        private const string spGetUserByLoginQuery = "spGetUserByLogin";
        

        #endregion

        #region Constructors

        public SqlUserRepository(string connection)
        {
            _connection = connection;
        }

        #endregion

        #region IUserRepository

        public User GetUserByLogin(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spGetUserByLoginQuery;
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        User user = null;
                        if (reader.Read())
                        {
                            user = new User();
                            user.Id = (int)reader["Id"];
                            user.FirstName = (string)reader["FirstName"];
                            user.LastName = (string)reader["LastName"];
                            user.Login = (string)reader["Login"];
                            user.Disabled = (bool)reader["Disabled"];
                        }
                        return user;
                    }
                }
            }
        }

        #endregion        
    }
}
