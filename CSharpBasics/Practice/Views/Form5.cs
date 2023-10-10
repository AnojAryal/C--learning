using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e) { 

         Models.Person person = new Models.Person();
            person.ID = int.Parse(textBox1.Text);
            person.FirstName = textBox2.Text;
            person.Address = textBox3.Text;
            person.AgeGroup = comboBox1.SelectedItem.ToString();
            if (radioButton1.Checked == true)
            {
                person.Gender = "Male";
            }
            else
            {
                person.Gender = "Female";
            }

            string hobbies = "";
            if (checkBox1.Checked == true)
            {
                hobbies += "Reading, ";
            }
            if (checkBox2.Checked == true)
            {
                hobbies += "Playing, ";

            }
            if (checkBox3.Checked == true)
            {
                hobbies += "Others, ";
            }
            MessageBox.Show(person.ToString());

      
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
