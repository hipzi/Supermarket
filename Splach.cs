using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Splach : Form
    {
        public Splach()
        {
            InitializeComponent();
        }

        private void guna2VProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            Myprogess.Value = startpoint;
            if(Myprogess.Value == 100)
            {
                Myprogess.Value = 0;
                timer1.Stop();
                Form1 login = new Form1();
                this.Hide();
                login.Show();
            }
        }

        private void Splach_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
