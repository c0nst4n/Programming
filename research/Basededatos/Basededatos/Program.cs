using System;
using System.Data.SqlClient;

namespace Basededatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            try
            {
                using (SqlConnection connect = new SqlConnection("server = CONSTANPC\\SQLEXPRESS; database = PROGRAM; integrated security = true"))
                {
                    
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.GetUserName(@userid);", connect))
                    {
                        cmd.Parameters.AddWithValue("@userid", 1);
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {

                            while (rdr.Read())
                            {
                                Console.WriteLine(rdr[0]);
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("NO FUNCIONA" + ex.Message);
            }
        }
    }
}