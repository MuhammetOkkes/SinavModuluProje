using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SınavModuluProje
{
    public class AdminDAL
    {
        SqlConnection connection = new SqlConnection(@"server=LAPTOP-UQBHP9TL;initial catalog=SınavModulu; integrated security=true"); // veritabanı bağlantısı kuruldı
        public Admin GetAdmin(string tc)
        {

            ConnectionControl(); // veritabanı bağlantısı açıldı
            SqlCommand command = new SqlCommand("Select * from Adminler where TcNo=" +tc, connection); // Adminler tablosundan tc si parametreyle aynı olan admini çektik
            SqlDataReader reader = command.ExecuteReader(); // sql readeri execute ederek çalıştırdık
            
            Admin admin =  new Admin();
            while (reader.Read()) // veritabanında koşula uyan tüm satırları geziyoruz
            {

                admin.AdminId = Convert.ToInt32(reader["AdminId"]);
                admin.KullaniciAdi = (reader["TcNo"]).ToString();
                admin.Sifre = (reader["Sifre"]).ToString();
               
            }
            reader.Close(); 
            connection.Close(); // veritabanı bağlantısı kapatıldı
            return admin;

        }
        public void ConnectionControl()
        {
            if (connection.State == ConnectionState.Closed) // veritabanı bağlantısı zaten açıksa işlem yapmaz
            {
                connection.Open();
            }
        }
    }
}
