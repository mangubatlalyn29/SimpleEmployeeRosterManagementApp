using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEmployeeRosterManagementApp
{
    public class Employee
    {
        public int id {  get; set; }
        public string username { get; set;}
        public string password { get; set;}
        public string firstname { get; set;}
        public string lastname { get; set;}
        public string middlename { get; set;}
        public string suffix { get; set; }
        public string department {  get; set;}
        public string contactnumber { get; set;}
    }
}
