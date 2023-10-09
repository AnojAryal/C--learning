using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ADO_NETv1
{
    public partial class SearchRecord : Form
    {
        public SearchRecord()
        {
            InitializeComponent();
        }

        private void SearchRecord_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string url = "datasource=localhost; Database=Week5secB; port=3306; User=root; Password=fastrack";
            string sql = "SELECT * FROM persons WHERE pid=" + int.Parse(this.textBox1.Text);
            MySqlConnection conn = null;
            MySqlCommand command = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(url);
                conn.Open();
                command = new MySqlCommand(sql, conn);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    this.textBox2.Text = reader.GetString("fullname");
                    this.textBox3.Text = reader.GetString("address");
                }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    MessageBox.Show("Error : Record not found!");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "datasource=localhost;port=3306;username=root;password=fastrack;";
            int pid = int.Parse(this.textBox1.Text); // The ID of the record to update
            string newFullname = this.textBox2.Text; // New fullname
            string newAddress = this.textBox3.Text; // New address

            string sql = $"UPDATE Week5secB.persons SET fullname = '{newFullname}', address = '{newAddress}' WHERE pid = {pid}";

            try
            {
                MySqlConnection conn = new MySqlConnection(url);
                conn.Open();
                MySqlCommand command = new MySqlCommand(sql, conn);
                int res = command.ExecuteNonQuery();
                MessageBox.Show("Result : " + res + " rows updated.");
                command.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string url = "datasource=localhost;port=3306;username=root;password=fastrack;";
            int pid = int.Parse(this.textBox1.Text); // The ID of the record to delete

            string sql = $"DELETE FROM Week5secB.persons WHERE pid = {pid}";

            try
            {
                MySqlConnection conn = new MySqlConnection(url);
                conn.Open();
                MySqlCommand command = new MySqlCommand(sql, conn);
                int res = command.ExecuteNonQuery();
                MessageBox.Show("Result : " + res + " rows deleted.");
                command.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

    }
}

