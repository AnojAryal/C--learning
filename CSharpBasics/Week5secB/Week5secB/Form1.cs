namespace Week5secB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();
            connect.MdiParent = this;
            connect.Show();
        }

        private void insertRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertRecord insertRecord = new InsertRecord();
            insertRecord.MdiParent = this;
            insertRecord.Show();
        }
    }
}