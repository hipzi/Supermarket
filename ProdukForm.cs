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
    public partial class ProdukForm : Form
    {
        public ProdukForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SellerForm produk = new SellerForm();
            produk.Show();
            this.Hide();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ASUS\DOCUMENTS\SUPERMARKETDB.mdf;Integrated Security=True;Connect Timeout=30");
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TOSHIBA\Documents\supermarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void fillCombo()
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select NamaKategori from Kategori", connect);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("NamaKategori", typeof(string));
            dt.Load(rdr);
            KategoriCb.ValueMember = "NamaKategori";
            KategoriCb.DataSource = dt;
            connect.Close();
        }

        private void ProdukForm_Load(object sender, EventArgs e)
        {
            fillCombo();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string query = "insert into Produk values (" + IDProduk.Text + ",'" + NamaProduk.Text + "'," + QuantProduk.Text + ","+ priceProduk.Text +", '"+KategoriCb.SelectedValue.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                connect.Close();
                populate();
                IDProduk.Text = "";
                NamaProduk.Text = "";
                QuantProduk.Text = "";
                priceProduk.Text = "";
                KategoriCb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate()
        {
            connect.Open();
            string query = "select * from Produk";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            ProdukGDV.DataSource = dataset.Tables[0];
            connect.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDProduk.Text == "" || NamaProduk.Text == "" || QuantProduk.Text == "" || priceProduk.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    connect.Open();
                    string query = "update Produk set NamaProduk='" + NamaProduk.Text + "',QuantProduk='" + QuantProduk.Text + "', KategoriProduk='" + KategoriCb.SelectedValue.ToString() + "' where IDProduk=" + IDProduk.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Updated");
                    connect.Close();
                    populate();
                    IDProduk.Text = "";
                    NamaProduk.Text = "";
                    QuantProduk.Text = "";
                    priceProduk.Text = "";
                    KategoriCb.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProdukGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDProduk.Text = ProdukGDV.SelectedRows[0].Cells[0].Value.ToString();
            NamaProduk.Text = ProdukGDV.SelectedRows[0].Cells[1].Value.ToString();
            QuantProduk.Text = ProdukGDV.SelectedRows[0].Cells[2].Value.ToString();
            priceProduk.Text = ProdukGDV.SelectedRows[0].Cells[3].Value.ToString();
            KategoriCb.Text = ProdukGDV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDProduk.Text == "")
                {

                    MessageBox.Show("Select The Product to Delete");
                }
                else
                {
                    connect.Open();
                    string query = "delete from Produk where IDProduk=" + IDProduk.Text + "";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    connect.Close();
                    populate();
                    IDProduk.Text = "";
                    NamaProduk.Text = "";
                    QuantProduk.Text = "";
                    priceProduk.Text = "";
                    KategoriCb.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
