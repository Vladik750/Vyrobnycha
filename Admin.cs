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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            loadUsers();
        }

        private void Admin_email_Click(object sender, EventArgs e)
        {

        }

        private void loadUsers()
        {
            string connString = "Host=localhost;Username=postgres;Password=Vladislav24;Database=Base_C#";
            string query = $"SELECT \"FirstName\", \"LastName\", \"Email\", \"Login\", \"Password\"FROM public.\"Users\" ";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            try
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        static bool ValidatePassword(string password)
        {

            const int MIN_LENGTH = 8;
            const int MAX_LENGTH = 15;

            if (password == null) return false;

            bool meetsLengthRequirements = password.Length >= MIN_LENGTH && password.Length <= MAX_LENGTH;
            bool hasUpperCaseLetter = false;
            bool hasLowerCaseLetter = false;
            bool hasDecimalDigit = false;

            if (meetsLengthRequirements)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpperCaseLetter = true;
                    else if (char.IsLower(c)) hasLowerCaseLetter = true;
                    else if (char.IsDigit(c)) hasDecimalDigit = true;
                }
            }

            bool isValid = meetsLengthRequirements
                        && hasUpperCaseLetter
                        && hasLowerCaseLetter
                        && hasDecimalDigit
                        ;
            return isValid;

        }

        private void ExecuteSQL(string command)
        {
            var cs = "Host=localhost;Username=postgres;Password=Vladislav24;Database=Base_C#";

            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = command;

            var cmd = new NpgsqlCommand(sql, con);

            cmd.ExecuteNonQuery();

            con.Close();
        }

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

        private void Create_but_Click(object sender, EventArgs e)
        {
            string FirstName = Ad_first_input.Text;
            string LastName = Ad_last_input.Text;
            string Email = Ad_email_input.Text;
            string Login = Ad_log_input.Text;
            string Password = Ad_pass_input.Text;

            if (ExecuteSQLScalar($"select count(\"Login\") from public.\"Users\" where \"Login\" = '{Login}'") != 0)
            {
                MessageBox.Show("This user already exists!");
                return;
            }

            if (IsValidEmail(Email) == false)
            {
                MessageBox.Show("Invalid Email!");
                return;
            }

            if (ValidatePassword(Password) == false)
            {
                MessageBox.Show("Password should not be less than 8 symbols! \n" +
                    "Password should contain numbers, lowercase and uppercase letters!");
                return;
            }

            ExecuteSQL($"insert into public.\"Users\" values('{FirstName}', '{LastName}', '{Email}', '{Login}','{Password}')");
            MessageBox.Show("Registered");

        }

        private void Logout_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
