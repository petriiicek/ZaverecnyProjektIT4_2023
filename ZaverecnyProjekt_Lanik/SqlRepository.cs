using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ZaverecnyProjekt_Lanik
{
    public class SqlRepository
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ZaverecnyProjekt;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public User? LoginUser(string nickname)
        {
            User? user = null;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM [User] WHERE Nickname=@nickname";
                    cmd.Parameters.AddWithValue("nickname", nickname);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User((int)reader["Id"], reader["Nickname"].ToString(), (byte[])reader["PasswordHash"], (byte[])reader["PasswordSalt"], reader["Role"].ToString());
                        }
                    }
                }
                sqlConnection.Close();
            }
            return user;
        }

        public List<User> GetUsers(string nickname)
        {
            List<User> users = new List<User>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM [User] WHERE Nickname LIKE @nickname";
                    cmd.Parameters.AddWithValue("nickname", "%" + nickname + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var user = new User((int)reader["Id"], reader["Nickname"].ToString()
                                             , (byte[])reader["PasswordHash"]
                                             , (byte[])reader["PasswordSalt"]
                                             , (string)reader["Role"]);
                            users.Add(user);
                        }
                    }
                }
                sqlConnection.Close();
            }
            return users;
        }

        public void AddUser(string nickname, string password, string role)
        {
            byte[] salt;
            byte[] hash;
            HMACSHA512 hmac = new HMACSHA512();

            hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            salt = hmac.Key;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO [User] (Nickname, PasswordHash, PasswordSalt, Role) VALUES (@nickname,@hash,@salt,@role)";
                    cmd.Parameters.AddWithValue("nickname", nickname);
                    cmd.Parameters.AddWithValue("hash", hash);
                    cmd.Parameters.AddWithValue("salt", salt);
                    cmd.Parameters.AddWithValue("role", role);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
        public void DeleteUser(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM [User] WHERE Id=@id";
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
        public void AddEmployee(string job, string firstname, string lastname, string date, string email, string phone)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO [Employee] (AssignedJob,Firstname, Lastname, BirthDate, Email, Phone) values(@job,@firstname,@lastname,@date,@email,@phone)";
                    cmd.Parameters.AddWithValue("job", job);
                    cmd.Parameters.AddWithValue("firstname", firstname);
                    cmd.Parameters.AddWithValue("lastname", lastname);
                    cmd.Parameters.AddWithValue("date", Convert.ToDateTime(date));
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("phone", phone);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
        public List<Employee> GetEmployees(string firstname)
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM [Employee] WHERE FirstName LIKE @firstname";
                    cmd.Parameters.AddWithValue("firstname", "%" + firstname + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var employee = new Employee((int)reader["EmployeeId"], (string)reader["AssignedJob"], (string)reader
                                                            ["FirstName"], (string)reader["LastName"], DateTime.Parse(reader["BirthDate"].ToString()),
                                                            (string)reader["Email"], (string)reader["Phone"]);
                            employees.Add(employee);
                        }
                    }
                }
                sqlConnection.Close();
            }
            return employees;
        }

        public void DeleteEmployee(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM [Employee] WHERE EmployeeId=@employeeId";
                    cmd.Parameters.AddWithValue("employeeId", id);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
    }
}


