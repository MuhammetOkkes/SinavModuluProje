using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SınavModuluProje
{
    public class SinavSorumluDal 
    {
        SqlConnection connection = new SqlConnection(@"server=LAPTOP-UQBHP9TL;initial catalog=SınavModulu; integrated security=true");
        public SinavSorumlu GetSinavSorumlu(string id)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from SinavSorumlular where TcNo=" + id, connection);
            SqlDataReader reader = command.ExecuteReader();

            SinavSorumlu sinavSorumlu = new SinavSorumlu();
            while (reader.Read())
            {

                sinavSorumlu.SorumluId = Convert.ToInt32(reader["SorumluId"]);
                sinavSorumlu.TcNo = (reader["TcNo"]).ToString();
                sinavSorumlu.Sifre = (reader["Sifre"]).ToString();

            }
            reader.Close();
            connection.Close();
            return sinavSorumlu;

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
