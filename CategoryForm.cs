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
                MessageBox.Show("Category Added Successfully");
                connect.Close();
                populate();
                IDKategori.Text = "";
                NamaKategori.Text = "";
                DeskripsiKategori.Text = "";
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
            KategoriGDV.DataSource = dataset.Tables[0];
            connect.Close();
        }   

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KategoriGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDKategori.Text = KategoriGDV.SelectedRows[0].Cells[0].Value.ToString();
            NamaKategori.Text = KategoriGDV.SelectedRows[0].Cells[1].Value.ToString();
            DeskripsiKategori.Text = KategoriGDV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void CategoryForm_Load_2(object sender, EventArgs e)
        {
            populate();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if(IDKategori.Text == "")
                {

                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    connect.Open();
                    string query = "delete from Kategori where IDKategori=" + IDKategori.Text + "";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    connect.Close();
                    populate();
                    IDKategori.Text = "";
                    NamaKategori.Text = "";
                    DeskripsiKategori.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDKategori.Text == "" || NamaKategori.Text == "" || DeskripsiKategori.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    connect.Open();
                    string query = "update Kategori set NamaKategori='" + NamaKategori.Text + "',DeskripsiKategori='" + DeskripsiKategori.Text + "' where IDKategori=" + IDKategori.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Updated");
                    connect.Close();
                    populate();
                    IDKategori.Text = "";
                    NamaKategori.Text = "";
                    DeskripsiKategori.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProdukForm produk = new ProdukForm();
            produk.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellerForm produk = new SellerForm();
            produk.Show();
            this.Hide();
        }
    }
}
