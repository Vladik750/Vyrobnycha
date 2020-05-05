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
    public partial class Form_registration : Form
    {
        public Form_registration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void RF_reg_but_Click(object sender, EventArgs e)
        {
            string FirstName = FirstName_input.Text;
            string LastName = LastName_input.Text;
            string Email = Email_input.Text;
            string Login = Login_input.Text;
            string Password = Password_input.Text;

            if(ExecuteSQLScalar($"select count(\"Login\") from public.\"Users\" where \"Login\" = '{Login}'") != 0)
            {
                MessageBox.Show("This user already exists!");
                return;
            }

            if(IsValidEmail(Email) == false)
            {
                MessageBox.Show("Invalid Email!");
                return;
            } 
            
            if(ValidatePassword(Password) == false)
            {
                MessageBox.Show("Password should not be less than 8 symbols! \n" +
                    "Password should contain numbers, lowercase and uppercase letters!");
                return;
            }

            ExecuteSQL($"insert into public.\"Users\" values('{FirstName}', '{LastName}', '{Email}', '{Login}','{Password}')");
            MessageBox.Show("Registered");
        }

        private void Form_registration_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
