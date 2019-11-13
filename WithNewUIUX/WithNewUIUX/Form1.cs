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

namespace WithNewUIUX
{
    public partial class Form1 : Form
    {
        static SqlConnection koneksi()
        {
            string connection_string = @"Data Source=Gus\SQLEXPRESS;Initial Catalog=GondrongStore;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection_string);
            return conn;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_Panel.Controls.Clear();

            awakku form = new awakku();
            form.TopLevel = false;
            Home_Panel.Controls.Add(form);
            form.Show();
        }

        private void stokProdukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_Panel.Controls.Clear();

            setok form = new setok();
            form.TopLevel = false;
            Home_Panel.Controls.Add(form);
            form.Show();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_Panel.Controls.Clear();

            adminjual form = new adminjual();
            form.TopLevel = false;
            Home_Panel.Controls.Add(form);
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_Panel.Controls.Clear();

            adminbeli form = new adminbeli();
            form.TopLevel = false;
            Home_Panel.Controls.Add(form);
            form.Show();
        }

        private void katalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_Panel.Controls.Clear();

            katalok form = new katalok();
            form.TopLevel = false;
            Home_Panel.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home_Panel.Controls.Clear();

            omah form = new omah();
            form.TopLevel = false;
            Home_Panel.Controls.Add(form);
            form.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Home_Panel.Controls.Clear();

            buyforyou form = new buyforyou();
            form.TopLevel = false;
            Home_Panel.Controls.Add(form);
            form.Show();
        }

        private void btn_BuyForYourStore_Click(object sender, EventArgs e)
        {
            Home_Panel.Controls.Clear();

            buyforyourstore form = new buyforyourstore();
            form.TopLevel = false;
            Home_Panel.Controls.Add(form);
            form.Show();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
