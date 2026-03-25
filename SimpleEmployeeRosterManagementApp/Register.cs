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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee user = new Employee()
            {
                username = usernameInput.Text,
                password = passwordInput.Text,
                firstname = firstnameInput.Text,
                middlename = middlenameInput.Text,
                lastname = lastnameInput.Text,
                suffix = suffixInput.Text,
                department = departmentInput.Text,
                contactnumber = contactInput.Text
            };
            ADO ado = new ADO();
            if (ado.Register(user)) { 
            MessageBox.Show("Registered Successfully!");
                Login login = new Login();
                login.Show();
            this.Hide();
            }
            else{
                MessageBox.Show("Registration Failed!");
            }
        }
    }
}
