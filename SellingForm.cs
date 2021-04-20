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
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ASUS\DOCUMENTS\SUPERMARKETDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            connect.Open();
            string query = "select NamaProduk,QuantProduk,PriceProduk from Produk";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            ProdukGDV1.DataSource = dataset.Tables[0];
            connect.Close();
        }
        private void populatebills()
        {
            connect.Open();
            string query = "select * from Transaksi";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            BillsGDV.DataSource = dataset.Tables[0];
            connect.Close();
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            SellerNamelbl.Text = Form1.NamaSeller;
        }
        
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void ProdukGDV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NamaProduk.Text = ProdukGDV1.SelectedRows[0].Cells[0].Value.ToString();
            PriceProduk.Text = ProdukGDV1.SelectedRows[0].Cells[2].Value.ToString();

        }
        int Grdtotal = 0, n = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if(NamaProduk.Text == "" || QuantProduk.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int total = Convert.ToInt32(PriceProduk.Text) * Convert.ToInt32(QuantProduk.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OrderGDV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = NamaProduk.Text;
                newRow.Cells[2].Value = PriceProduk.Text;
                newRow.Cells[3].Value = QuantProduk.Text;
                newRow.Cells[4].Value = Convert.ToInt32(PriceProduk.Text) * Convert.ToInt32(QuantProduk.Text);
                OrderGDV.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                Amountlbl.Text = "" + Grdtotal;
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(IDBill.Text == "")
            {
                MessageBox.Show("Missing Bill ID");
            }
            else
            {
                try
                {
                    connect.Open();
                    string query = "insert into Transaksi values (" + IDBill.Text + ",'" + SellerNamelbl.Text + "', '" + Datelabel.Text + "'," + Amountlbl.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully");
                    connect.Close();
                    populatebills();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void Amountlbl_Click(object sender, EventArgs e)
        {

        }

        private void NamaProduk_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void BillsGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Supermarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Teal, new Point(300));
            e.Graphics.DrawString("Bill ID : " +BillsGDV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Teal, new Point(100, 70));
            e.Graphics.DrawString("Seller Name : " + BillsGDV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Teal, new Point(100, 100));
            e.Graphics.DrawString("Date : " + BillsGDV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Teal, new Point(100, 130));
            e.Graphics.DrawString("Total Amount : " + BillsGDV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Teal, new Point(100, 160));
            //e.Graphics.DrawString("CodeSpace", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Teal, new Point(300));
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
