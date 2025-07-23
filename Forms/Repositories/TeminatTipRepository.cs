using Forms.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace Forms.Repositories
{
    public class TeminatTipRepository
    {
        private readonly string connectionString = "Data Source=YASIN\\SQLEXPRESS;Initial Catalog=halk;Integrated Security=True;Trust Server Certificate=True";

        public List<TeminatTip> GetAllTeminatTipleri()
        {
            var tipList = new List<TeminatTip>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT tipId, teminatTipAd FROM TeminatTip";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        tipList.Add(new TeminatTip
                        {
                            tipId = Convert.ToInt32(reader["tipId"]),
                            teminatTipAd = reader["teminatTipAd"].ToString()
                        });
                    }
                }
            }

            return tipList;
        }

        public TeminatTip GetTeminatTipByCinsId(int cinsId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT tt.tipId, tt.teminatTipAd 
                         FROM TeminatCins tc 
                         JOIN TeminatTip tt ON tc.tipId = tt.tipId 
                         WHERE tc.cinsId = @cinsId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@cinsId", cinsId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new TeminatTip
                            {
                                tipId = Convert.ToInt32(reader["tipId"]),
                                teminatTipAd = reader["teminatTipAd"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

    }
}
