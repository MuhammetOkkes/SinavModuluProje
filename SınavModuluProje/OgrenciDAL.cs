using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SınavModuluProje
{
    public class OgrenciDAL
    {
        SqlConnection connection = new SqlConnection(@"server=LAPTOP-UQBHP9TL;initial catalog=SınavModulu; integrated security=true"); // veriyabanı bağlantı
        public List<Ogrenci> GetAll()
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Ogrenciler", connection); // ogrencilerin hepsini çeker
            SqlDataReader reader = command.ExecuteReader();

            List<Ogrenci> ogrencis = new List<Ogrenci>();
            while (reader.Read())
            {
                Ogrenci ogrenci = new Ogrenci
                {
                    OgrneciId = Convert.ToInt32(reader["OgrenciId"]),
                    OgrenciAdi   = reader["OgrenciAdi"].ToString(),
                    OgrenciSoyadi = reader["OgrenciSoyadi"].ToString(),
                     HavuzSorular= reader["HavuzSorular"].ToString(),
                    Sifre = reader["Sifre"].ToString(),
                    TcNo = (reader["TcNo"]).ToString(),
                    Sorular = (reader["Sorular"]).ToString(),
                };
                ogrencis.Add(ogrenci);
            }
            reader.Close();
            connection.Close();
            return ogrencis;

        }
        public void Add(Ogrenci ogrenci)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("Insert into Ogrenciler values(@OgrenciAdi,@OgrenciSoyadi,@Sorular,@HavuzSorular,@TcNo,@Sifre,@Sure)", connection); // ogrenci ekler
            // veritabanindaki sıranın aynısı yazılması zorunludur
            sqlCommand.Parameters.AddWithValue("@OgrenciAdi", ogrenci.OgrenciAdi);
            sqlCommand.Parameters.AddWithValue("@OgrenciSoyadi", ogrenci.OgrenciSoyadi);
            sqlCommand.Parameters.AddWithValue("@HavuzSorular", ogrenci.HavuzSorular);
            sqlCommand.Parameters.AddWithValue("@Sifre", ogrenci.Sifre);
            sqlCommand.Parameters.AddWithValue("@TcNo", ogrenci.TcNo);
            sqlCommand.Parameters.AddWithValue("@Sorular", ogrenci.Sorular);
            sqlCommand.Parameters.AddWithValue("@Sure", ogrenci.Sure);
            sqlCommand.ExecuteNonQuery();

            connection.Close();

        }
        public void Update(Ogrenci ogrenci)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("Update Ogrenciler set OgrenciAdi=@OgrenciAdi,OgrenciSoyadi=@OgrenciSoyadi,HavuzSorular=@HavuzSorular,Sifre=@Sifre,TcNo=@TcNo,Sorular=@Sorular,Sure=@Sure where OgrenciId=@OgrenciId", connection);
            // Öğrenci bilgileri günceller
            sqlCommand.Parameters.AddWithValue("@OgrenciAdi", ogrenci.OgrenciAdi);
            sqlCommand.Parameters.AddWithValue("@OgrenciSoyadi", ogrenci.OgrenciSoyadi);
            sqlCommand.Parameters.AddWithValue("@HavuzSorular", ogrenci.HavuzSorular);
            sqlCommand.Parameters.AddWithValue("@Sifre", ogrenci.Sifre);
            sqlCommand.Parameters.AddWithValue("@TcNo", ogrenci.TcNo);
            sqlCommand.Parameters.AddWithValue("@Sorular", ogrenci.Sorular);
            sqlCommand.Parameters.AddWithValue("@Sure", ogrenci.Sure);
            sqlCommand.Parameters.AddWithValue("@OgrenciId", ogrenci.OgrneciId);
            
            sqlCommand.ExecuteNonQuery();

            connection.Close();

        }
        public void Delete(int id)
        {
            // Öğrenci silme
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Ogrenciler whre OgrneciId=OgrneciId", connection);
            command.Parameters.AddWithValue("@OgrneciId", id);
            command.ExecuteNonQuery();

            connection.Close();
        }
        public Ogrenci GetOgrenci(string id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Ogrenciler where TcNo=" + id, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Ogrenci> ogrencis = new List<Ogrenci>();
            Ogrenci ogrenci = new Ogrenci();
            while (reader.Read())
            {
                ogrenci.OgrneciId = Convert.ToInt32(reader["OgrenciId"]);
                ogrenci.OgrenciAdi = reader["OgrenciAdi"].ToString();
                ogrenci.OgrenciSoyadi = reader["OgrenciSoyadi"].ToString();
                ogrenci.HavuzSorular = reader["HavuzSorular"].ToString();
                ogrenci.Sifre = reader["Sifre"].ToString();
                ogrenci.TcNo = (reader["TcNo"]).ToString();
                ogrenci.Sorular = (reader["Sorular"]).ToString();
                ogrenci.Sure = Convert.ToInt32(reader["Sure"]);
            }
            reader.Close();
            connection.Close();
            return ogrenci;
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
