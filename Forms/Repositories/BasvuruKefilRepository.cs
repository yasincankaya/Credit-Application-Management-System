using Forms.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Forms.Repositories
{
    public class BasvuruKefilRepository
    {
        private readonly string connectionString = "Data Source=YASIN\\SQLEXPRESS;Initial Catalog=halk;Integrated Security=True;Trust Server Certificate=True";

        public List<BasvuruKefil> GetByBasvuruId(int basvuruId)
        {
            var kefiller = new List<BasvuruKefil>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM BasvuruKefiller WHERE basvuruId = @basvuruId";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@basvuruId", basvuruId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                BasvuruKefil kefil = new BasvuruKefil
                                {
                                    kefilId = reader.GetInt32(0),
                                    basvuruId = reader.GetInt32(1),
                                    musteriId = reader.GetInt32(2),
                                    kefilGelirTip = reader.GetString(3),
                                    kefilGelirMiktari = reader.GetDecimal(4),
                                    yakinlikDurumu = reader.GetString(5)
                                };

                                kefiller.Add(kefil);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata (GetByBasvuruId): " + ex.Message);
            }

            return kefiller;
        }

        public BasvuruKefil GetById(int kefilId)
        {
            BasvuruKefil kefil = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM BasvuruKefiller WHERE kefilId = @kefilId";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@kefilId", kefilId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                kefil = new BasvuruKefil
                                {
                                    kefilId = reader.GetInt32(0),
                                    basvuruId = reader.GetInt32(1),
                                    musteriId = reader.GetInt32(2),
                                    kefilGelirTip = reader.GetString(3),
                                    kefilGelirMiktari = reader.GetDecimal(4),
                                    yakinlikDurumu = reader.GetString(5)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata (GetById): " + ex.Message);
            }

            return kefil;
        }

        public int Create(BasvuruKefil kefil)
        {
            int newId = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"
                        INSERT INTO BasvuruKefiller
                        (basvuruId, musteriId, kefilGelirTip, kefilGelirMiktari, yakinlikDurumu)
                        VALUES
                        (@basvuruId, @musteriId, @kefilGelirTip, @kefilGelirMiktari, @yakinlikDurumu);
                        SELECT CAST(scope_identity() AS int);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@basvuruId", kefil.basvuruId);
                        command.Parameters.AddWithValue("@musteriId", kefil.musteriId);
                        command.Parameters.AddWithValue("@kefilGelirTip", kefil.kefilGelirTip);
                        command.Parameters.AddWithValue("@kefilGelirMiktari", kefil.kefilGelirMiktari);
                        command.Parameters.AddWithValue("@yakinlikDurumu", kefil.yakinlikDurumu);

                        newId = (int)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata (Create): " + ex.Message);
            }

            return newId;
        }
    }
}
