using Forms.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Repositories
{
    public class UrunRepository
    {
        private readonly string connectionString = "Data Source=YASIN\\SQLEXPRESS;Initial Catalog=halk;Integrated Security=True;Trust Server Certificate=True";


        public List<Urun> GetUrunler()
        {
            var urunler = new List<Urun>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM urunler ORDER BY urunId ASC";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Urun urun = new Urun();
                                
                                urun.urunId = reader.GetInt32(0);
                                urun.urunAd = reader.GetString(1);
                                urun.tip = reader.GetString(2);
                                urun.tipKod = reader.GetString(3);

                                urunler.Add(urun);
                                
                            }

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return urunler;
        }

        public List<Urun> GetUrunler(string tip)
        {
            var urunler = new List<Urun>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM urunler ORDER BY urunId ASC";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Urun urun = new Urun();
                                
                                urun.urunId = reader.GetInt32(0);
                                urun.urunAd = reader.GetString(1);
                                urun.tip = reader.GetString(2);
                                urun.tipKod = reader.GetString(3);

                                if (urun.tip == tip)
                                {
                                    urunler.Add(urun);
                                }
                            }

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return urunler;
        }

        public Urun GetUrunById(int urunId)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM urunler WHERE urunId=@urunID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("urunId", urunId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Urun urun = new Urun();
                                urun.urunId = reader.GetInt32(0);
                                urun.urunAd = reader.GetString(1);
                                urun.tip = reader.GetString(2);
                                urun.tipKod = reader.GetString(3);

                                return urun;
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
