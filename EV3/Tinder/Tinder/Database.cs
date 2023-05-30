using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;



namespace Tinder
{
    public class Database
    {
 

        public static ObservableCollection<User> Connect() 
        {
             ObservableCollection<User> users = new ObservableCollection<User>();
            try
            {
                using (SqlConnection connect = new SqlConnection("server = CONSTANPC\\SQLEXPRESS; database = TINDER; integrated security = true"))
                {
                    
                    connect.Open();
                    string user = "SELECT * FROM dbo.searchPerson(@pattern, @offset, @limit)";
                    using (SqlCommand cmd = new SqlCommand(user, connect))
                    {
                        //cmd.Parameters.AddWithValue("@iduser", "1");
                        cmd.Parameters.AddWithValue("@pattern", "");
                        cmd.Parameters.AddWithValue("@offset", "0");
                        cmd.Parameters.AddWithValue("@limit", "20");

                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {

                            while (rdr.Read())
                            {
                                users.Add(new User()
                                {
                                    Id = rdr.GetFieldValue<int>(0),
                                    name = rdr.GetFieldValue<string>(1),
                                    age = rdr.GetFieldValue<int>(2),
                                    description = rdr.GetFieldValue<string>(3),
                                    gender = rdr.GetFieldValue<string>(4),
                                    rating = rdr.GetFieldValue<int>(5),
                                    photo = rdr.GetFieldValue<string>(6)
                                });
                            }
                        }
                    }


                    //string insert = "INSERT INTO STUDENT(name, age) VALUES(@name, @age)";

                    //using (SqlCommand command = new SqlCommand(insert, connect))
                    //{
                    //    command.Parameters.AddWithValue("@name", "Juan");
                    //    command.Parameters.AddWithValue("@age", "17");
                    //}

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("NO FUNCIONA" + ex.Message);
            }

            return users;
        }

        public static void DeleteUser(int id)
        {
            try
            {
                using (SqlConnection c = new SqlConnection("server = CONSTANPC\\SQLEXPRESS; database = TINDER; integrated security = true"))
                {
                    c.Open();
                    SqlCommand cmd = new SqlCommand("dbo.removeUser", c);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idUser", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw new Exception("Error de borrar usuario :(");
            }
        }

        public static void AddUser(string name, string age, string description, string gender, string rating, string photo)
        {
            int Age = Int32.Parse(age);
            int Rating = Int32.Parse(rating);
            try
            {
                using (SqlConnection c = new SqlConnection("server = CONSTANPC\\SQLEXPRESS; database = TINDER; integrated security = true"))
                {
                    c.Open();
                    SqlCommand cmd = new SqlCommand("dbo.addUser", c);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@age", Age);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@rating", Rating);
                    cmd.Parameters.AddWithValue("@photo", photo);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw new Exception("Error de añadir usuario :(");
            }

        }

        public static ObservableCollection<User> Filter(string pattern, int offset, int limit)
        {
            ObservableCollection<User> users = new ObservableCollection<User>();
            try
            {
                using (SqlConnection connect = new SqlConnection("server = CONSTANPC\\SQLEXPRESS; database = TINDER; integrated security = true"))
                {

                    connect.Open();
                    string user = "SELECT * FROM dbo.searchPerson(@pattern, @offset, @limit)";
                    using (SqlCommand cmd = new SqlCommand(user, connect))
                    {
                        cmd.Parameters.AddWithValue("@pattern", pattern);
                        cmd.Parameters.AddWithValue("@offset", offset);
                        cmd.Parameters.AddWithValue("@limit", limit);

                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {

                            while (rdr.Read())
                            {
                                users.Add(new User()
                                {
                                    Id = rdr.GetFieldValue<int>(0),
                                    name = rdr.GetFieldValue<string>(1),
                                    age = rdr.GetFieldValue<int>(2),
                                    description = rdr.GetFieldValue<string>(3),
                                    gender = rdr.GetFieldValue<string>(4),
                                    rating = rdr.GetFieldValue<int>(5),
                                    photo = rdr.GetFieldValue<string>(6)
                                });
                            }
                        }
                    }

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("NO FUNCIONA" + ex.Message);
            }

            return users;
        }
    }
}
