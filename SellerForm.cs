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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TOSHIBA\Documents\supermarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            connect.Open();
            string query = "select * from Seller";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            SellerGDV.DataSource = dataset.Tables[0];
            connect.Close();
        }
        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string query = "insert into Seller values (" + IDSeller.Text + ",'" + NamaSeller.Text + "','" + AgeSeller.Text + "','"+ PhoneSeller.Text +"','"+ PassSeller.Text +"')";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully");
                connect.Close();
                populate();
                IDSeller.Text = "";
                NamaSeller.Text = "";
                AgeSeller.Text = "";
                PhoneSeller.Text = "";
                PassSeller.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SellerGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDSeller.Text = SellerGDV.SelectedRows[0].Cells[0].Value.ToString();
            NamaSeller.Text = SellerGDV.SelectedRows[0].Cells[1].Value.ToString();
            AgeSeller.Text = SellerGDV.SelectedRows[0].Cells[2].Value.ToString();
            PhoneSeller.Text = SellerGDV.SelectedRows[0].Cells[3].Value.ToString();
            PassSeller.Text = SellerGDV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDSeller.Text == "")
                {

                    MessageBox.Show("Select The Seller to Delete");
                }
                else
                {
                    connect.Open();
                    string query = "delete from Seller where IDSeller=" + IDSeller.Text + "";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");
                    connect.Close();
                    populate();
                    IDSeller.Text = "";
                    NamaSeller.Text = "";
                    AgeSeller.Text = "";
                    PhoneSeller.Text = "";
                    PassSeller.Text = "";
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
                if (IDSeller.Text == "" || NamaSeller.Text == "" || AgeSeller.Text == "" || PhoneSeller.Text == "" || PassSeller.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    connect.Open();
                    string query = "update Seller set NamaSeller='" + NamaSeller.Text + "',AgeSeller='" + AgeSeller.Text + "',PhoneSeller='" + PhoneSeller.Text + "',PassSeller='" + PassSeller.Text + "' where IDSeller=" + IDSeller.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Successfully Updated");
                    connect.Close();
                    populate();
                    IDSeller.Text = "";
                    NamaSeller.Text = "";
                    AgeSeller.Text = "";
                    PhoneSeller.Text = "";
                    PassSeller.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
