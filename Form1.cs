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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
        {

            loadCountries();
        }

        private void Add_but_Click(object sender, EventArgs e)
        {
            string Name = Name_input.Text;
            string President = President_input.Text;
            string Square = Square_input.Text;
            string Amount = Amount_input.Text;
            string Time_zone = Time_zone_input.Text;

            
            var ins =$"INSERT INTO public.\"Country\"(  \"Name\", \"Square\", \"Amount\", \"Login\", \"President\", \"Time_zone\")VALUES('{Name}' ,'{Square}', '{Amount}', '{Variables.Login}', '{President}', '{Time_zone}');";
            ExecuteSQL(ins);
            loadCountries();
        }

        private void Edit_but_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            
            Class_country valid = new Class_country(Name_input.Text, President_input.Text, Int32.Parse(Square_input.Text), Int32.Parse(Amount_input.Text), Time_zone_input.Text);
            string id = row.Cells[0].Value.ToString();
            if (id == "")
                return;
            string ed = ($"UPDATE public.\"Country\" set \"Name\"='{Name_input.Text}', \"Square\"='{Square_input.Text}', \"Amount\"='{Amount_input.Text}', \"President\"='{President_input.Text}', \"Time_zone\"='{Time_zone_input.Text}' where \"CountryID\" ='{id}'");
            ExecuteSQL(ed);
            loadCountries();
        }

        private void Delete_but_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }else{
                var del = $"delete from public.\"Country\" where \"CountryID\" = '{dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}'";
                ExecuteSQL(del);
                loadCountries();
            }
        }

        private void Logout_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadCountries()
        {
            string connString = "Host=localhost;Username=postgres;Password=Vladislav24;Database=Base_C#";
            string query = $"SELECT \"CountryID\", \"Name\",  \"Square\", \"Amount\",\"President\",  \"Time_zone\"FROM public.\"Country\" where \"Login\" = '{Variables.Login}'";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            Name_input.Text = row.Cells[1].Value.ToString();
            Square_input.Text = row.Cells[2].Value.ToString();
            Amount_input.Text = row.Cells[3].Value.ToString();
            President_input.Text = row.Cells[4].Value.ToString();
            Time_zone_input.Text = row.Cells[5].Value.ToString();
        }
    }
}
