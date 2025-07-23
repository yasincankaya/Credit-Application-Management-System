using Forms.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Forms.Repositories
{
    public class MusteriRepository
    {
        private readonly string connectionString = "Data Source=YASIN\\SQLEXPRESS;Initial Catalog=halk;Integrated Security=True;Trust Server Certificate=True";

        public List<Musteri> GetClients()
        {
            var musteriler = new List<Musteri>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Musteriler ORDER BY musteriId DESC";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Musteri musteri = new Musteri
                                {
                                    musteriID = reader.GetInt32(0),
                                    tcKimlikNo = reader.GetString(1),
                                    ad = reader.GetString(2),
                                    soyad = reader.GetString(3),
                                    adres = reader.GetString(4),
                                    dogumTarihi = reader.GetDateTime(5),
                                    dogumYeri = reader.IsDBNull(6) ? null : reader.GetString(6),
                                    babaAdi = reader.IsDBNull(7) ? null : reader.GetString(7),
                                    anneAdi = reader.IsDBNull(8) ? null : reader.GetString(8),
                                    cinsiyet = reader.IsDBNull(9) ? null : reader.GetString(9),
                                    medeniHal = reader.IsDBNull(10) ? null : reader.GetString(10)
                                };

                                musteriler.Add(musteri);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return musteriler;
        }

        public Musteri GetClient(int musteriID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Musteriler WHERE musteriId=@musteriID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@musteriID", musteriID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Musteri musteri = new Musteri
                                {
                                    musteriID = reader.GetInt32(0),
                                    tcKimlikNo = reader.GetString(1),
                                    ad = reader.GetString(2),
                                    soyad = reader.GetString(3),
                                    adres = reader.GetString(4),
                                    dogumTarihi = reader.GetDateTime(5),
                                    dogumYeri = reader.IsDBNull(6) ? null : reader.GetString(6),
                                    babaAdi = reader.IsDBNull(7) ? null : reader.GetString(7),
                                    anneAdi = reader.IsDBNull(8) ? null : reader.GetString(8),
                                    cinsiyet = reader.IsDBNull(9) ? null : reader.GetString(9),
                                    medeniHal = reader.IsDBNull(10) ? null : reader.GetString(10)
                                };

                                return musteri;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return null;
        }

        public Musteri GetClientByTc(string tcKimlikNo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Musteriler WHERE tcKimlikNo=@tcKimlikNo";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@tcKimlikNo", tcKimlikNo);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Musteri musteri = new Musteri
                                {
                                    musteriID = reader.GetInt32(0),
                                    tcKimlikNo = reader.GetString(1),
                                    ad = reader.GetString(2),
                                    soyad = reader.GetString(3),
                                    adres = reader.GetString(4),
                                    dogumTarihi = reader.GetDateTime(5),
                                    dogumYeri = reader.IsDBNull(6) ? null : reader.GetString(6),
                                    babaAdi = reader.IsDBNull(7) ? null : reader.GetString(7),
                                    anneAdi = reader.IsDBNull(8) ? null : reader.GetString(8),
                                    cinsiyet = reader.IsDBNull(9) ? null : reader.GetString(9),
                                    medeniHal = reader.IsDBNull(10) ? null : reader.GetString(10)
                                };

                                return musteri;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return null;
        }
    }
}
