using MySqlConnector;
using System.Data;

namespace ADO_NETv1
{
    public partial class DiaplayAll : Form
    {
        public DiaplayAll()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "datasource=localhost; Database=Week5secB; port=3306; User=root; Password=fastrack";
            string sql = "SELECT * FROM persons";
            MySqlConnection conn = null;
            MySqlCommand command = null;
            MySqlDataAdapter adapter = null;
            DataTable table = null;
            try
            {
                conn = new MySqlConnection(url);
                conn.Open();
                command = new MySqlCommand(sql, conn);
                adapter = new MySqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ExportToPdf(object sender, EventArgs e)
        {
           
            
        }


        private void DiaplayAll_Load(object sender, EventArgs e)
        {

        }
    }
}
