using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleEmployeeRosterManagementApp
{
    public partial class Info : Form
    {
        Employee employee;
        public Info(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            idInput.Text = employee.id.ToString();
            usernameInput.Text = employee.username;
            firstnameInput.Text = employee.firstname;
            lastnameInput.Text = employee.lastname;
            middlenameInput.Text = employee.middlename;
            suffixInput.Text = employee.suffix;
            departmentInput.Text = employee.department;
            contactInput.Text = employee.contactnumber;
        }
    }
}
