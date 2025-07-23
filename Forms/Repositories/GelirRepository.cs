using Forms.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Repositories
{
    public class GelirRepository
    {
        private readonly string connectionString = "Data Source=YASIN\\SQLEXPRESS;Initial Catalog=halk;Integrated Security=True;Trust Server Certificate=True";

        public void AddGelirTipi(int basvuruId, string gelirTip, decimal gelirMiktari)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = @"INSERT INTO GelirTipleri (basvuruId, gelirTip, gelirMiktari)
                       VALUES (@basvuruId, @gelirTip, @gelirMiktari)";
                using (var cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@basvuruId", basvuruId);
                    cmd.Parameters.AddWithValue("@gelirTip", gelirTip);
                    cmd.Parameters.AddWithValue("@gelirMiktari", gelirMiktari);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddGelirTipi(string referansNo, string gelirTip, decimal gelirMiktari)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Önce referansNo ile basvuruId'yi bul
                string getIdSql = "SELECT basvuruId FROM Basvurular WHERE referansNo = @referansNo";
                int? basvuruId = null;

                using (var cmdGetId = new SqlCommand(getIdSql, connection))
                {
                    cmdGetId.Parameters.AddWithValue("@referansNo", referansNo);

                    var result = cmdGetId.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        basvuruId = Convert.ToInt32(result);
                    }
                }

                // basvuruId bulunduysa ekle
                if (basvuruId.HasValue)
                {
                    string insertSql = @"INSERT INTO GelirTipleri (basvuruId, gelirTip, gelirMiktari)
                                 VALUES (@basvuruId, @gelirTip, @gelirMiktari)";

                    using (var cmdInsert = new SqlCommand(insertSql, connection))
                    {
                        cmdInsert.Parameters.AddWithValue("@basvuruId", basvuruId.Value);
                        cmdInsert.Parameters.AddWithValue("@gelirTip", gelirTip);
                        cmdInsert.Parameters.AddWithValue("@gelirMiktari", gelirMiktari);
                        cmdInsert.ExecuteNonQuery();
                    }
                }
                else
                {
                    // İsteğe bağlı: referansNo bulunamazsa uyarı
                    throw new Exception("Verilen referans numarasıyla bir başvuru bulunamadı.");
                }
            }
        }


        public List<GelirTipleri> GetGelirTipleriByBasvuruId(int basvuruId)
        {
            var list = new List<GelirTipleri>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT gelirTipId, basvuruId, gelirTip, gelirMiktari FROM GelirTipleri WHERE basvuruId = @basvuruId";
                using (var cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@basvuruId", basvuruId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new GelirTipleri
                            {
                                gelirTipId = reader.GetInt32(0),
                                basvuruId = reader.GetInt32(1),
                                gelirTip = reader.GetString(2),
                                gelirMiktari = reader.GetDecimal(3)
                            });
                        }
                    }
                }
            }
            return list;
        }

        public void AddOrUpdateGelirTipi(int basvuruId, string gelirTip, decimal gelirMiktari)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectSql = @"SELECT gelirMiktari FROM GelirTipleri 
                             WHERE basvuruId = @basvuruId AND gelirTip = @gelirTip";

                using (var cmdSelect = new SqlCommand(selectSql, connection))
                {
                    cmdSelect.Parameters.AddWithValue("@basvuruId", basvuruId);
                    cmdSelect.Parameters.AddWithValue("@gelirTip", gelirTip);

                    var existing = cmdSelect.ExecuteScalar();

                    if (existing == null)
                    {
                        // Kayıt yok → INSERT
                        string insertSql = @"INSERT INTO GelirTipleri (basvuruId, gelirTip, gelirMiktari)
                                     VALUES (@basvuruId, @gelirTip, @gelirMiktari)";
                        using (var cmdInsert = new SqlCommand(insertSql, connection))
                        {
                            cmdInsert.Parameters.AddWithValue("@basvuruId", basvuruId);
                            cmdInsert.Parameters.AddWithValue("@gelirTip", gelirTip);
                            cmdInsert.Parameters.AddWithValue("@gelirMiktari", gelirMiktari);
                            cmdInsert.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        decimal mevcutMiktar = Convert.ToDecimal(existing);
                        if (mevcutMiktar != gelirMiktari)
                        {
                            // Miktar değişmiş → UPDATE
                            string updateSql = @"UPDATE GelirTipleri
                                         SET gelirMiktari = @gelirMiktari
                                         WHERE basvuruId = @basvuruId AND gelirTip = @gelirTip";
                            using (var cmdUpdate = new SqlCommand(updateSql, connection))
                            {
                                cmdUpdate.Parameters.AddWithValue("@basvuruId", basvuruId);
                                cmdUpdate.Parameters.AddWithValue("@gelirTip", gelirTip);
                                cmdUpdate.Parameters.AddWithValue("@gelirMiktari", gelirMiktari);
                                cmdUpdate.ExecuteNonQuery();
                            }
                        }
                        // Miktar aynıysa işlem yapma
                    }
                }
            }
        }


    }
}
