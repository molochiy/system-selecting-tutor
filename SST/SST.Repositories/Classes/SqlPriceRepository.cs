using SST.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SST.Repositories.Classes
{
    public class SqlPriceRepository : IPriceRepository
    {

        #region Private Fields

        private readonly string _connection;

        #endregion
        #region Queries

        private const string spGetPriceByTutorIdANDDisciplineId = "spGetPriceByTutorIdANDDisciplineId";
        
        #endregion

        #region Constructors

        public SqlPriceRepository(string connection)
        {
            _connection = connection;
        }

        #endregion

        public decimal GetPriceByTutorIdANDDisciplineId(int TutorId, int DisciplineId)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = spGetPriceByTutorIdANDDisciplineId;
                    command.Parameters.AddWithValue("@TutorId", TutorId);
                    command.Parameters.AddWithValue("@DisciplineId", DisciplineId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (decimal)reader["LessonPrice"];
                        }
                    }
                }
            }
            return -1;
        }
    }
}
