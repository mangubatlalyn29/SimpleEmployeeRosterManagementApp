using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SimpleEmployeeRosterManagementApp
{
    internal class DB
    {

        public static MySqlConnection GetConnection() {
            string connectString = "server=localhost;user=root;password=;database=Employee_Roster";
            return new MySqlConnection(connectString);
        }
    }
}
