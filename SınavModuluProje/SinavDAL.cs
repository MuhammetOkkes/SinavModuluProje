using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SınavModuluProje
{
   public class SinavDAL
    {
        SqlConnection connection = new SqlConnection(@"server=LAPTOP-UQBHP9TL;initial catalog=SınavModulu; integrated security=true");
        public List<Sinav> GetAll() // tüm sinavları çeker
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Sinavlar", connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Sinav> sinavs = new List<Sinav>();
            while (reader.Read())
            {
                Sinav sinav = new Sinav
                {
                    SinavId = Convert.ToInt32(reader["SinavId"]),
                    OgrenciAdi = reader["OgrenciAdi"].ToString(),
                    OgrenciSoyadi = reader["OgrenciSoyadi"].ToString(),
                    DogruCevaplar = reader["DogruCevaplar"].ToString(),
                    YanlisCevaplar = reader["YanlisCevaplar"].ToString(),
                    OgrenciId = Convert.ToInt32(reader["OgrenciId"]),
                    SinavBaslangic = Convert.ToDateTime(reader["SinavBaslangic"]),
                    SinavBitis = Convert.ToDateTime(reader["SinavBitis"]),
                };
                sinavs.Add(sinav);
            }
            reader.Close();
            connection.Close();
            return sinavs;

        }
        public void Add(Sinav sinav) // öğrencinin girdiği sınavı veritabanına ekler
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("Insert into Sinavlar values(@OgrenciId,@OgrenciAdi,@OgrenciSoyadi,@DogruCevaplar,@YanlisCevaplar,@SinavBaslangic,@SinavBitis)", connection);

            sqlCommand.Parameters.AddWithValue("@OgrenciAdi", sinav.OgrenciAdi);
            sqlCommand.Parameters.AddWithValue("@OgrenciSoyadi", sinav.OgrenciSoyadi);
            sqlCommand.Parameters.AddWithValue("@DogruCevaplar", sinav.DogruCevaplar);
            sqlCommand.Parameters.AddWithValue("@YanlisCevaplar", sinav.YanlisCevaplar);
            sqlCommand.Parameters.AddWithValue("@OgrenciId", sinav.OgrenciId);
            sqlCommand.Parameters.AddWithValue("@SinavBaslangic", sinav.SinavBaslangic);
            sqlCommand.Parameters.AddWithValue("@SinavBitis", sinav.SinavBitis);
            sqlCommand.ExecuteNonQuery();

            connection.Close();

        }
        public void Update(Sinav sinav) // sinavları günceller
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("Update Sinavlar set OgrenciAdi=@OgrenciAdi,OgrenciSoyadi=@OgrenciSoyadi,DogruCevaplar=@DogruCevaplar,YanlisCevaplar=@YanlisCevaplar,OgrenciId=@OgrenciId,SinavBaslangic=@SinavBaslangic,SinavBitis=@SinavBitis where SinavId=@SinavId", connection);

            sqlCommand.Parameters.AddWithValue("@OgrenciAdi", sinav.OgrenciAdi);
            sqlCommand.Parameters.AddWithValue("@OgrenciSoyadi", sinav.OgrenciSoyadi);
            sqlCommand.Parameters.AddWithValue("@DogruCevaplar", sinav.DogruCevaplar);
            sqlCommand.Parameters.AddWithValue("@YanlisCevaplar", sinav.YanlisCevaplar);
            sqlCommand.Parameters.AddWithValue("@OgrenciId", sinav.OgrenciId);
            sqlCommand.Parameters.AddWithValue("@SinavBaslangic", sinav.SinavBaslangic);
            sqlCommand.Parameters.AddWithValue("@SinavBitis", sinav.SinavBitis);
            sqlCommand.Parameters.AddWithValue("@SinavId", sinav.SinavId);
            sqlCommand.ExecuteNonQuery();

            connection.Close();

        }
        public void Delete(int id) // sinav siler
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Sinavlar whre SinavId=SinavId", connection);
            command.Parameters.AddWithValue("@SinavId", id);
            command.ExecuteNonQuery();

            connection.Close();
        }
        public List<Sinav> GetSinavByOgrenciId(int ogrenciId) // bir öğrencinin girdiği tüm sınavları döndürür
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Sinavlar where OgrenciId="+ogrenciId, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Sinav> sinavs = new List<Sinav>();
            while (reader.Read())
            {
                Sinav sinav = new Sinav
                {
                    SinavId = Convert.ToInt32(reader["SinavId"]),
                    OgrenciAdi = reader["OgrenciAdi"].ToString(),
                    OgrenciSoyadi = reader["OgrenciSoyadi"].ToString(),
                    DogruCevaplar = reader["DogruCevaplar"].ToString(),
                    YanlisCevaplar = reader["YanlisCevaplar"].ToString(),
                    OgrenciId = Convert.ToInt32(reader["OgrenciId"]),
                    SinavBaslangic = Convert.ToDateTime(reader["SinavBaslangic"]),
                    SinavBitis = Convert.ToDateTime(reader["SinavBitis"]),
                };
                sinavs.Add(sinav);
            }
            reader.Close();
            connection.Close();
            return sinavs;
        }
       
        public void ConnectionControl()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

    }
}
