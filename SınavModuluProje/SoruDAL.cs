using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SınavModuluProje
{
   public  class SoruDAL
    {
        SqlConnection connection = new SqlConnection(@"server=LAPTOP-UQBHP9TL;initial catalog=SınavModulu; integrated security=true");
        public List<Soru> GetAll()
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Sorular", connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Soru> sorus = new List<Soru>();
            while (reader.Read())
            {
                Soru soru = new Soru
                {
                    SoruId = Convert.ToInt32(reader["SoruId"]),
                    SoruMetni = reader["SoruMetni"].ToString(),
                    SecenekA = reader["SecenekA"].ToString(),
                    SecenekB = reader["SecenekB"].ToString(),
                    SecenekC   = reader["SecenekC"].ToString(),
                    DogruCevap = (reader["DogruCevap"]).ToString(),
                    KategoriId = Convert.ToInt32(reader["KategoriId"]),
                    SoruNo = Convert.ToInt32(reader["SoruNo"]),
                };
                sorus.Add(soru);
            }
            reader.Close();
            connection.Close();
            return sorus;

        }
        public void Add(Soru soru)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("Insert into Sorular values(@SoruMetni,@SecenekA,@SecenekB,@SecenekC,@DogruCevap,@KategoriId,@SoruNo)", connection);

            sqlCommand.Parameters.AddWithValue("@SoruMetni", soru.SoruMetni);
            sqlCommand.Parameters.AddWithValue("@SecenekA", soru.SecenekA);
            sqlCommand.Parameters.AddWithValue("@SecenekB", soru.SecenekB);
            sqlCommand.Parameters.AddWithValue("@SecenekC", soru.SecenekC);
            sqlCommand.Parameters.AddWithValue("@KategoriId", soru.KategoriId);
            sqlCommand.Parameters.AddWithValue("@DogruCevap", soru.DogruCevap);
            sqlCommand.Parameters.AddWithValue("@SoruNo", soru.SoruNo);
            sqlCommand.ExecuteNonQuery();

            connection.Close();

        }
        public void Update(Soru soru)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("Update Sorular set SoruMetni=@SoruMetni,SecenekA=@SecenekA,SecenekB=@SecenekB,SecenekC=@SecenekC,DogruCevap=@DogruCevap,KategoriId=@KategoriId,SoruNo=@SoruNo where SoruId=@SoruId", connection);

            sqlCommand.Parameters.AddWithValue("@SoruMetni", soru.SoruMetni);
            sqlCommand.Parameters.AddWithValue("@SecenekA", soru.SecenekA);
            sqlCommand.Parameters.AddWithValue("@SecenekB", soru.SecenekB);
            sqlCommand.Parameters.AddWithValue("@SecenekC", soru.SecenekC);
            sqlCommand.Parameters.AddWithValue("@DogruCevap", soru.DogruCevap);
            sqlCommand.Parameters.AddWithValue("@KategoriId", soru.KategoriId);
            sqlCommand.Parameters.AddWithValue("@SoruNo", soru.SoruNo);
            sqlCommand.Parameters.AddWithValue("@SoruId", soru.SoruId);
            
            sqlCommand.ExecuteNonQuery();

            connection.Close();

        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Sorular where SoruId=SoruId", connection);
            command.Parameters.AddWithValue("@SoruId", id);
            command.ExecuteNonQuery();

            connection.Close();
        }
        public List<Soru> GetSoruByKategoriId(int kategoriId)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Sorular where KategoriId="+kategoriId, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Soru> sorus = new List<Soru>();
            while (reader.Read())
            {
                Soru soru = new Soru
                {
                    SoruId = Convert.ToInt32(reader["SoruId"]),
                    SoruMetni = reader["SoruMetni"].ToString(),
                    SecenekA = reader["SecenekA"].ToString(),
                    SecenekB = reader["SecenekB"].ToString(),
                    SecenekC = reader["SecenekC"].ToString(),
                    DogruCevap = (reader["DogruCevap"]).ToString(),
                    KategoriId = Convert.ToInt32(reader["KategoriId"]),
                    SoruNo= Convert.ToInt32(reader["SoruNo"]),
                };
                sorus.Add(soru);
            }
            reader.Close();
            connection.Close();
            return sorus;
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
