namespace SecBGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "hello Pcps";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Click Me";
            label1.Text = " ";
            button2.Text = "Date Time";

            textBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            textBox1.Text = DateTime.Now.ToString("ddd, dd MMMM yyyy hh:mm:ss");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString("ddd, dd MMMM yyyy hh:mm:ss");
        }
    }
}