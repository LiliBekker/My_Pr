using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

           
        public Form1()
        {
            InitializeComponent();
        }

        public MySqlConnection mycon;
        public MySqlCommand mycom;
        public string connect = "Server=Localhost;Database=photocenter;Uid=root;pwd=root;";
        public System.Data.DataSet ds;


        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MessageBox.Show("База данных фотоцентра успешно подключена");
                mycon.Close();
            }
            catch { MessageBox.Show("База данных фотоцентра не подключена"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                string script = "SELECT * FROM photocenter.клиенты;";
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
                System.Data.DataTable table = new System.Data.DataTable();
                ms_data.Fill(table);
                dataGridView1.DataSource = table;
                mycon.Close();
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                string script = "SELECT * FROM photocenter.поставщики;";
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
                System.Data.DataTable table = new System.Data.DataTable();
                ms_data.Fill(table);
                dataGridView1.DataSource = table;
                mycon.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string script = "SELECT count(*) FROM photocenter.поставщики;";
            mycon = new MySqlConnection(connect);
            mycon.Open();
            MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
            System.Data.DataTable table = new System.Data.DataTable();
            ms_data.Fill(table);
            dataGridView1.DataSource = table;
            mycon.Close();
        }
    }
}
