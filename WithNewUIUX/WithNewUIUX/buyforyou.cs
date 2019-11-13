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
using System.Linq;

namespace WithNewUIUX
{
    public partial class buyforyou : Form
    {
        private GondrongStoreDataSet db;
        public buyforyou()
        {
            InitializeComponent();
            db = new GondrongStoreDataSet();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buyforyou_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gondrongStoreDataSet.stok' table. You can move, or remove it, as needed.
            this.stokTableAdapter.Fill(this.gondrongStoreDataSet.stok);
            // TODO: This line of code loads data into the 'gondrongStoreDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.gondrongStoreDataSet.user);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id_user = (int)comboBox1.SelectedValue;
            var id_stok = (int)comboBox2.SelectedValue;
            var jumlah_jual = Convert.ToInt32(textBox1.Text);
            var jumlah_retur = Convert.ToInt32(textBox2.Text);
            var harga_satuan = Convert.ToInt32(textBox3.Text);
            var tgl_transaksi = dateTimePicker1.Value;

            // var stok = (from a in db.stok select a).SingleOrDefault();

            SqlConnection conn = koneksi.getDB();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM stok where id_stok = " + id_stok;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            List<DataRow> stok = dt.AsEnumerable().ToList();
            int stok_harga = Convert.ToInt32(stok[0]["harga_stok"]);
            double labarugi = ((harga_satuan - stok_harga) * jumlah_jual) - (harga_satuan * jumlah_retur); 
            Console.WriteLine(labarugi.ToString());



            koneksi.fromDBqueryExecute("INSERT into penjualan (id_user, id_stok, jumlah_jual, jumlah_retur, harga_satuan, tgl_transaksi, laba_rugi)" +
                "VALUES ('" + id_user + "', '" + id_stok + "', '" + jumlah_jual + "', '" + jumlah_retur + "', '" + harga_satuan + "', '" + tgl_transaksi + "', '" + labarugi + "');");

            this.update_Data();
        }

        private void update_Data()
        {
            SqlConnection conn = koneksi.getDB();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM penjualan";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
        }
    }
}
