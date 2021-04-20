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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string NamaSeller = "";
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ASUS\DOCUMENTS\SUPERMARKETDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {

                MessageBox.Show("Enter The Username and Password");
            }
            else
            {
                if (RoleCat.SelectedIndex > -1)
                {
                    if (RoleCat.SelectedItem.ToString() == "ADMIN")
                    {
                        if (username.Text == "Admin" && password.Text == "Admin")
                        {
                            ProdukForm produk = new ProdukForm();
                            produk.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If You are The Admin Enter The Correct Username and Password");
                        }
                    }
                    else
                    {
                        //MessageBox.Show("You are in Seller Section");
                        connect.Open();
                        string query = "select count(2) from Seller where NamaSeller='" + username.Text + "' and PassSeller='" + password.Text + "' ";
                        SqlDataAdapter sda = new SqlDataAdapter(query, connect);
                        DataTable dataset = new DataTable();
                        sda.Fill(dataset);
                        if(dataset.Rows[0][0].ToString() == "1")
                        {
                            NamaSeller = username.Text;
                            SellingForm sell = new SellingForm();
                            sell.Show();
                            this.Hide();
                            connect.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username or Password");
                        }
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Select a Role");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
        }
    }
}
