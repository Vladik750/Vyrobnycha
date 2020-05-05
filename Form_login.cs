using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Laba1
{
    public partial class Form_login : Form
    {

        private int ExecuteSQLScalar(string command)
        {
            var cs = "Host=localhost;Username=postgres;Password=Vladislav24;Database=Base_C#";

            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = command;

            var cmd = new NpgsqlCommand(sql, con);

            var k = cmd.ExecuteScalar();

            con.Close();
            return Int32.Parse(k.ToString());
        }

        public Form_login()
        {
            InitializeComponent();

            Variables.Login = Login_input.Text;
            string Password = Password_input.Text;

        }

        private void LF_reg_but_Click(object sender, EventArgs e)
        {
            var Form_reg = new Form_registration();
            Form_reg.Show();
        }

        private void login_but_Click(object sender, EventArgs e)
        {
            Variables.Login = Login_input.Text;
            string Password = Password_input.Text;

            if (ExecuteSQLScalar($"select count(\"Login\") from public.\"Users\" where \"Login\" = '{Variables.Login}' and \"Password\" = '{Password}' ") == 0)
            {
                MessageBox.Show("Wrong Login or Password!");
                return;
            }
            else
            {
                MessageBox.Show("Access Granted.");
                if (Variables.Login == "admin")
                {
                    var Admin_form = new Admin();
                    Admin_form.Show();
                }
                else {
                    var Form_next = new Form1();
                    Form_next.Show();
                }
            }
           

        }
    }
}
