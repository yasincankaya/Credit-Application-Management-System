using Forms.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Forms.Repositories
{
    public class BasvuruRepository
    {
        private readonly string connectionString = "Data Source=YASIN\\SQLEXPRESS;Initial Catalog=halk;Integrated Security=True;Trust Server Certificate=True";

        public List<Basvuru> GetBasvurularByMusteriID(int musteriID)
        {
            var basvurular = new List<Basvuru>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Basvurular WHERE musteriID = @musteriID ORDER BY basvuruId DESC";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@musteriID", musteriID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                basvurular.Add(MapBasvuru(reader));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetBasvurularByMusteriID Exception: " + ex.ToString());
            }

            return basvurular;
        }

        public Basvuru GetBasvuruByReferansNo(string referansNo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Basvurular WHERE referansNo = @referansNo";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@referansNo", referansNo);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                                return MapBasvuru(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetBasvuruByReferansNo Exception: " + ex.ToString());
            }

            return null;
        }

        public int CreateBasvuru(Basvuru basvuru)
        {
            int newId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = @"INSERT INTO Basvurular 
                (musteriID, urunID, referansNo, tutar, vade, basvuruTarihi, onayDurumu)
                VALUES
                (@musteriID, @urunID, @referansNo, @tutar, @vade, @basvuruTarihi, @onayDurumu);
                SELECT CAST(scope_identity() AS int);";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@musteriID", basvuru.musteriID);
                    command.Parameters.AddWithValue("@urunID", basvuru.urunID);
                    command.Parameters.AddWithValue("@referansNo", (object)basvuru.referansNo ?? DBNull.Value);
                    command.Parameters.AddWithValue("@tutar", basvuru.tutar);
                    command.Parameters.AddWithValue("@vade", basvuru.vade);
                    command.Parameters.AddWithValue("@basvuruTarihi", basvuru.basvuruTarihi);
                    command.Parameters.AddWithValue("@onayDurumu", (object)basvuru.onayDurumu ?? DBNull.Value);

                    newId = (int)command.ExecuteScalar();
                }
            }

            return newId;
        }

        public void UpdateBasvuru(Basvuru basvuru)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"UPDATE Basvurular SET
                        musteriID = @musteriID,
                        urunID = @urunID,
                        referansNo = @referansNo,
                        tutar = @tutar,
                        vade = @vade,
                        basvuruTarihi = @basvuruTarihi,
                        ikametSuresi = @ikametSuresi,
                        konutuVarMi = @konutuVarMi,
                        tasitiVarMi = @tasitiVarMi,
                        telefonNo = @telefonNo,
                        oturulanEv = @oturulanEv,
                        odemeGunu = @odemeGunu,
                        maasGunu = @maasGunu,
                        teminatId = @teminatId,
                        geriOdemeTercihi = @geriOdemeTercihi,
                        satisKaynagi = @satisKaynagi,
                        maasDurumu = @maasDurumu,
                        kullanimAmaci = @kullanimAmaci,
                        onayDurumu = @onayDurumu
                    WHERE basvuruId = @basvuruId";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@musteriID", basvuru.musteriID);
                        command.Parameters.AddWithValue("@urunID", basvuru.urunID);
                        command.Parameters.AddWithValue("@referansNo", (object)basvuru.referansNo ?? DBNull.Value);
                        command.Parameters.AddWithValue("@tutar", basvuru.tutar);
                        command.Parameters.AddWithValue("@vade", basvuru.vade);
                        command.Parameters.AddWithValue("@basvuruTarihi", basvuru.basvuruTarihi);
                        command.Parameters.AddWithValue("@ikametSuresi", (object)basvuru.ikametSuresi ?? DBNull.Value);
                        command.Parameters.AddWithValue("@konutuVarMi", (object)basvuru.konutuVarMi ?? DBNull.Value);
                        command.Parameters.AddWithValue("@tasitiVarMi", (object)basvuru.tasitiVarMi ?? DBNull.Value);
                        command.Parameters.AddWithValue("@telefonNo", (object)basvuru.telefonNo ?? DBNull.Value);
                        command.Parameters.AddWithValue("@oturulanEv", (object)basvuru.oturulanEv ?? DBNull.Value);
                        command.Parameters.AddWithValue("@odemeGunu", (object)basvuru.odemeGunu ?? DBNull.Value);
                        command.Parameters.AddWithValue("@maasGunu", (object)basvuru.maasGunu ?? DBNull.Value);
                        command.Parameters.AddWithValue("@teminatId", (object)basvuru.teminatId ?? DBNull.Value);
                        command.Parameters.AddWithValue("@geriOdemeTercihi", (object)basvuru.geriOdemeTercihi ?? DBNull.Value);
                        command.Parameters.AddWithValue("@satisKaynagi", (object)basvuru.satisKaynagi ?? DBNull.Value);
                        command.Parameters.AddWithValue("@maasDurumu", (object)basvuru.maasDurumu ?? DBNull.Value);
                        command.Parameters.AddWithValue("@kullanimAmaci", (object)basvuru.kullanimAmaci ?? DBNull.Value);
                        command.Parameters.AddWithValue("@onayDurumu", (object)basvuru.onayDurumu ?? DBNull.Value);
                        command.Parameters.AddWithValue("@basvuruId", basvuru.basvuruId);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("UpdateBasvuru Exception: " + ex.ToString());
                throw;
            }
        }

        private Basvuru MapBasvuru(SqlDataReader reader)
        {
            return new Basvuru
            {
                basvuruId = reader.GetInt32(reader.GetOrdinal("basvuruId")),
                musteriID = reader.GetInt32(reader.GetOrdinal("musteriID")),
                urunID = reader.GetInt32(reader.GetOrdinal("urunID")),
                referansNo = reader["referansNo"] as string,
                tutar = reader.GetDecimal(reader.GetOrdinal("tutar")),
                vade = reader.GetInt32(reader.GetOrdinal("vade")),
                basvuruTarihi = reader.GetDateTime(reader.GetOrdinal("basvuruTarihi")),
                ikametSuresi = reader["ikametSuresi"] as int?,
                konutuVarMi = reader["konutuVarMi"] as bool?,
                tasitiVarMi = reader["tasitiVarMi"] as bool?,
                telefonNo = reader["telefonNo"] as string,
                oturulanEv = reader["oturulanEv"] as string,
                odemeGunu = reader["odemeGunu"] as int?,
                maasGunu = reader["maasGunu"] as int?,
                teminatId = reader["teminatId"] as int?,
                geriOdemeTercihi = reader["geriOdemeTercihi"] as string,
                satisKaynagi = reader["satisKaynagi"] as string,
                maasDurumu = reader["maasDurumu"] as string,
                kullanimAmaci = reader["kullanimAmaci"] as string,
                onayDurumu = reader["onayDurumu"] as int?
            };
        }
    }
}
