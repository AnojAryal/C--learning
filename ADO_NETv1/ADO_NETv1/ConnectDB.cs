namespace ADO_NETv1
{
    public partial class ConnectDB : Form
    {
        public ConnectDB()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void connectDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Assuming Form2 is the name of your second form class
            Form2 form2 = new Form2();
            form2.Show(); // This will show Form2
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void insertRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchRecord search = new SearchRecord();
            search.Show();
        }

        private void displayAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiaplayAll formdis = new DiaplayAll();
            formdis.Show();
        }
    }
}