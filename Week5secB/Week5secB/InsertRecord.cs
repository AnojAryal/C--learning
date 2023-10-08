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

namespace Week5secB
{
    public partial class InsertRecord : Form
    {
        public InsertRecord()
        {
            InitializeComponent();
        }

        private void InsertRecord_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connect with database
            string url = "datasource=localhost;port=3306;username=root;password=fastrack;";
            int pid = int.Parse(this.textBox1.Text);
            string fullname = this.textBox2.Text;
            string address = this.textBox3.Text;
            string sql = "INSERT INTO Week5secB.persons(pid,fullname,address) VALUES(" + pid + ",'" + fullname + "', '" + address + "')";
            try
            {
                //try to connect
                MySqlConnection conn = new MySqlConnection(url);
                conn.Open();
                //insert record
                MySqlCommand command = new MySqlCommand(sql, conn);
                int res = command.ExecuteNonQuery();
                MessageBox.Show("Result : " + res);
                command.Dispose();
                conn.Close();
                //close connection
                MessageBox.Show("Connect with MYSQL Server Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

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