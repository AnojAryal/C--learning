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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "datasource=localhost; Database=Week5secB; port=3306; User=root; Password=fastrack";
            string sql = "INSERT INTO persons(pid, fullname, address) VALUES(" + int.Parse(textBox1.Text) + ", '" + textBox2.Text + "', '" + textBox3.Text + "')";
            MySqlConnection conn = null;
            MySqlCommand command = null;
            try
            {
                conn = new MySqlConnection(url);
                conn.Open();
                command = new MySqlCommand(sql, conn);
                int result = command.ExecuteNonQuery();
                conn.Close();
                if (result == 1)
                {
                    MessageBox.Show("Insert record successfully");
                }
                else
                {
                    MessageBox.Show("Error to insert record");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
