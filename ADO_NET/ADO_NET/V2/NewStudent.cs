using ADO_NETv1.V2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADO_NET.V2
{
    public partial class NewStudent : Form
    {
        public NewStudent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get values
            Student student = new Student();
            student.SID = int.Parse(IDForm.Text);
            student.FullName = FullNameForm.Text;
            student.Level = this.comboBox1.SelectedItem.ToString();
            student.Section = this.comboBox2.SelectedItem.ToString();
            student.Sub1 = double.Parse(MADForm.Text);
            student.Sub2 = double.Parse(OOPForm.Text);

            //process
            StudentManager studentManager = new StudentManager(student);
            studentManager.Calculatetotal();
            studentManager.CalculateAverage();
            studentManager.CalculateResult();


            //display
            student = studentManager.STUDENT;
            this.textBox1.Text = student.Total.ToString();
            this.textBox2.Text = student.Average.ToString();
            this.textBox3.Text = student.Result;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void NewStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
