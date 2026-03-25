using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace SimpleEmployeeRosterManagementApp
{
    internal class ADO
    {
        public bool Register(Employee employee) {
            using (var conn = DB.GetConnection()) { 
                conn.Open();

                string query = "INSERT INTO employee (username, password, first_name,last_name,middle_name,suffix,department,contact_number) VALUES (@user, @pass,@first, @last, @middle, @suffix, @dept, @contact)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", employee.username);
                cmd.Parameters.AddWithValue("@pass", employee.password);
                cmd.Parameters.AddWithValue("@first", employee.firstname);
                cmd.Parameters.AddWithValue("@last", employee.lastname);
                cmd.Parameters.AddWithValue("@middle", employee.middlename);
                cmd.Parameters.AddWithValue("@suffix", employee.suffix);
                cmd.Parameters.AddWithValue("@dept", employee.department);
                cmd.Parameters.AddWithValue("@contact", employee.contactnumber);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public Employee Login(string username, string password) {
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM employee WHERE username=@user AND password=@pass";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Employee
                        {
                            id = reader.GetInt32("id"),
                            username = reader.GetString("username"),
                            password = reader.GetString("password"),
                            firstname = reader.GetString("first_name"),
                            lastname = reader.GetString("last_name"),
                            middlename = reader.GetString("middle_name"),
                            suffix = reader.GetString("suffix"),
                            department = reader.GetString("department"),
                            contactnumber = reader.GetString("contact_number")
                        };
                    }
                }
            }
            return null;
        }
    }
}
