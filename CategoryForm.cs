using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Supermarket
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TOSHIBA\Documents\supermarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string query = "insert into Kategori values ("+IDKategori.Text+",'"+NamaKategori.Text+"','"+ DeskripsiKategori .Text+"')";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kategori Added Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate()
        {
            connect.Open();
            string query = "select * from Kategori";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            KategoriDGV.DataSource = dataset.Tables[0];
            connect.Close();
        }   

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            
        }

        private void KategoriDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void CategoryForm_Load_1(object sender, EventArgs e)
        {
            populate();
        }
    }
}
