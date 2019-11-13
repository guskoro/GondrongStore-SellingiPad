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
    public partial class buyforyourstore : Form
    {
        public buyforyourstore()
        {
            InitializeComponent();
        }

        private void buyforyourstore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gondrongStoreDataSet.stok' table. You can move, or remove it, as needed.
            this.stokTableAdapter.Fill(this.gondrongStoreDataSet.stok);
            // TODO: This line of code loads data into the 'gondrongStoreDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.gondrongStoreDataSet.user);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id_stok = (int)comboBox2.SelectedValue;
            var jumlah_beli = Convert.ToInt32(textBox1.Text);
            var harga_satuan = Convert.ToInt32(textBox3.Text);
            var tgl_transaksi = dateTimePicker1.Value;

            koneksi.fromDBqueryExecute("INSERT into pembelian (id_stok, jumlah_beli, harga_satuan, tgl_transaksi)" +
                "VALUES ('" + id_stok + "', '" + jumlah_beli + "', '" + harga_satuan + "', '" + tgl_transaksi + "');");

            this.update_Data();
        }

        private void update_Data()
        {
            SqlConnection conn = koneksi.getDB();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM pembelian";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
        }
    }
}
