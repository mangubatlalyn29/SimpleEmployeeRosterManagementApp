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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password)) {
                MessageBox.Show("All fields should not be empty");
            }
            else {
                ADO ado = new ADO();
                Employee emp = ado.Login(username, password);

                if (emp != null)
                {
                    Info info = new Info(emp);
                    info.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Invalid Credentials");
                }
            }
            
        }
    }
}
