using Forms.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Forms.Repositories
{
    public class TeminatRepository
    {
        private readonly string connectionString = "Data Source=YASIN\\SQLEXPRESS;Initial Catalog=halk;Integrated Security=True;Trust Server Certificate=True";

        public void Create(Teminat teminat)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(@"
                    INSERT INTO Teminatlar 
                    (basvuruId, cinsId, teminatTutar, dovizCinsi, kaskoDegeri, aracModelYili, aracSasiNo, aracModel, ekspertizSekli, enerjiKimlik, satisTarihi, aracSatisTutar, konutTipi, ipotekDerecesi) 
                    VALUES 
                    (@basvuruId, @cinsId, @teminatTutar, @dovizCinsi, @kaskoDegeri, @aracModelYili, @aracSasiNo, @aracModel, @ekspertizSekli, @enerjiKimlik, @satisTarihi, @aracSatisTutar, @konutTipi, @ipotekDerecesi)", connection);

                command.Parameters.AddWithValue("@basvuruId", teminat.basvuruId);
                command.Parameters.AddWithValue("@cinsId", teminat.cinsId);
                command.Parameters.AddWithValue("@teminatTutar", (object?)teminat.teminatTutar ?? DBNull.Value);
                command.Parameters.AddWithValue("@dovizCinsi", (object?)teminat.dovizCinsi ?? DBNull.Value);
                command.Parameters.AddWithValue("@kaskoDegeri", (object?)teminat.kaskoDegeri ?? DBNull.Value);
                command.Parameters.AddWithValue("@aracModelYili", (object?)teminat.aracModelYili ?? DBNull.Value);
                command.Parameters.AddWithValue("@aracSasiNo", (object?)teminat.aracSasiNo ?? DBNull.Value);
                command.Parameters.AddWithValue("@aracModel", (object?)teminat.aracModel ?? DBNull.Value);
                command.Parameters.AddWithValue("@ekspertizSekli", (object?)teminat.ekspertizSekli ?? DBNull.Value);
                command.Parameters.AddWithValue("@enerjiKimlik", (object?)teminat.enerjiKimlik ?? DBNull.Value);
                command.Parameters.AddWithValue("@satisTarihi", (object?)teminat.satisTarihi ?? DBNull.Value);
                command.Parameters.AddWithValue("@aracSatisTutar", (object?)teminat.aracSatisTutar ?? DBNull.Value);
                command.Parameters.AddWithValue("@konutTipi", (object?)teminat.konutTipi ?? DBNull.Value);
                command.Parameters.AddWithValue("@ipotekDerecesi", (object?)teminat.ipotekDerecesi ?? DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Teminat GetById(int teminatId)
        {
            Teminat? teminat = null;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Teminatlar WHERE teminatId = @teminatId", connection);
                command.Parameters.AddWithValue("@teminatId", teminatId);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        teminat = ReadTeminat(reader);
                    }
                }
            }
            return teminat!;
        }

        public List<Teminat> GetAll()
        {
            var teminatlar = new List<Teminat>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Teminatlar", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        teminatlar.Add(ReadTeminat(reader));
                    }
                }
            }
            return teminatlar;
        }

        public List<Teminat> GetTeminatlarByBasvuruId(int basvuruId)
        {
            var teminatList = new List<Teminat>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Teminatlar WHERE basvuruId = @basvuruId", connection);
                command.Parameters.AddWithValue("@basvuruId", basvuruId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        teminatList.Add(ReadTeminat(reader));
                    }
                }
            }
            return teminatList;
        }

        public void Update(Teminat teminat)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(@"
                    UPDATE Teminatlar SET
                        basvuruId = @basvuruId,
                        cinsId = @cinsId,
                        teminatTutar = @teminatTutar,
                        dovizCinsi = @dovizCinsi,
                        kaskoDegeri = @kaskoDegeri,
                        aracModelYili = @aracModelYili,
                        aracSasiNo = @aracSasiNo,
                        aracModel = @aracModel,
                        ekspertizSekli = @ekspertizSekli,
                        enerjiKimlik = @enerjiKimlik,
                        satisTarihi = @satisTarihi,
                        aracSatisTutar = @aracSatisTutar,
                        konutTipi = @konutTipi,
                        ipotekDerecesi = @ipotekDerecesi
                    WHERE teminatId = @teminatId", connection);

                command.Parameters.AddWithValue("@teminatId", teminat.teminatId);
                command.Parameters.AddWithValue("@basvuruId", teminat.basvuruId);
                command.Parameters.AddWithValue("@cinsId", teminat.cinsId);
                command.Parameters.AddWithValue("@teminatTutar", (object?)teminat.teminatTutar ?? DBNull.Value);
                command.Parameters.AddWithValue("@dovizCinsi", (object?)teminat.dovizCinsi ?? DBNull.Value);
                command.Parameters.AddWithValue("@kaskoDegeri", (object?)teminat.kaskoDegeri ?? DBNull.Value);
                command.Parameters.AddWithValue("@aracModelYili", (object?)teminat.aracModelYili ?? DBNull.Value);
                command.Parameters.AddWithValue("@aracSasiNo", (object?)teminat.aracSasiNo ?? DBNull.Value);
                command.Parameters.AddWithValue("@aracModel", (object?)teminat.aracModel ?? DBNull.Value);
                command.Parameters.AddWithValue("@ekspertizSekli", (object?)teminat.ekspertizSekli ?? DBNull.Value);
                command.Parameters.AddWithValue("@enerjiKimlik", (object?)teminat.enerjiKimlik ?? DBNull.Value);
                command.Parameters.AddWithValue("@satisTarihi", (object?)teminat.satisTarihi ?? DBNull.Value);
                command.Parameters.AddWithValue("@aracSatisTutar", (object?)teminat.aracSatisTutar ?? DBNull.Value);
                command.Parameters.AddWithValue("@konutTipi", (object?)teminat.konutTipi ?? DBNull.Value);
                command.Parameters.AddWithValue("@ipotekDerecesi", (object?)teminat.ipotekDerecesi ?? DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int teminatId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("DELETE FROM Teminatlar WHERE teminatId = @teminatId", connection);
                command.Parameters.AddWithValue("@teminatId", teminatId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private Teminat ReadTeminat(SqlDataReader reader)
        {
            return new Teminat
            {
                teminatId = reader["teminatId"] == DBNull.Value ? 0 : Convert.ToInt32(reader["teminatId"]),
                basvuruId = reader["basvuruId"] == DBNull.Value ? 0 : Convert.ToInt32(reader["basvuruId"]),
                cinsId = reader["cinsId"] == DBNull.Value ? 0 : Convert.ToInt32(reader["cinsId"]),
                teminatTutar = reader["teminatTutar"] == DBNull.Value ? null : (decimal?)reader["teminatTutar"],
                dovizCinsi = reader["dovizCinsi"] == DBNull.Value ? null : reader["dovizCinsi"].ToString(),
                kaskoDegeri = reader["kaskoDegeri"] == DBNull.Value ? null : (decimal?)reader["kaskoDegeri"],
                aracModelYili = reader["aracModelYili"] == DBNull.Value ? null : (int?)reader["aracModelYili"],
                aracSasiNo = reader["aracSasiNo"] == DBNull.Value ? null : reader["aracSasiNo"].ToString(),
                aracModel = reader["aracModel"] == DBNull.Value ? null : reader["aracModel"].ToString(),
                ekspertizSekli = reader["ekspertizSekli"] == DBNull.Value ? null : reader["ekspertizSekli"].ToString(),
                enerjiKimlik = reader["enerjiKimlik"] == DBNull.Value ? null : reader["enerjiKimlik"].ToString(),
                satisTarihi = reader["satisTarihi"] == DBNull.Value ? null : (DateTime?)reader["satisTarihi"],
                aracSatisTutar = reader["aracSatisTutar"] == DBNull.Value ? null : (decimal?)reader["aracSatisTutar"],
                konutTipi = reader["konutTipi"] == DBNull.Value ? null : reader["konutTipi"].ToString(),
                ipotekDerecesi = reader["ipotekDerecesi"] == DBNull.Value ? null : (int?)reader["ipotekDerecesi"]
            };
        }

    }
}
