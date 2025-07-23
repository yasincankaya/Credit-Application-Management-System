using Forms.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace Forms.Repositories
{
    public class TeminatCinsRepository
    {
        private readonly string connectionString = "Data Source=YASIN\\SQLEXPRESS;Initial Catalog=halk;Integrated Security=True;Trust Server Certificate=True";

        public List<TeminatCins> GetCinslerByTipId(int tipId)
        {
            var cinsList = new List<TeminatCins>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT cinsId, tipId, cinsAd FROM TeminatCins WHERE tipId = @tipId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tipId", tipId);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cinsList.Add(new TeminatCins
                        {
                            cinsId = Convert.ToInt32(reader["cinsId"]),
                            tipId = Convert.ToInt32(reader["tipId"]),
                            cinsAd = reader["cinsAd"].ToString()
                        });
                    }
                }
            }

            return cinsList;
        }

        public TeminatCins GetById(int cinsId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT cinsId, tipId, cinsAd FROM TeminatCins WHERE cinsId = @cinsId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@cinsId", cinsId);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new TeminatCins
                        {
                            cinsId = Convert.ToInt32(reader["cinsId"]),
                            tipId = Convert.ToInt32(reader["tipId"]),
                            cinsAd = reader["cinsAd"].ToString()
                        };
                    }
                }
            }

            return null; // Bulunamazsa null dön
        }

    }
}
