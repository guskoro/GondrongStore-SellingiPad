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
    public partial class setok : Form
    {
        public setok()
        {
            InitializeComponent();
        }

        private void stokBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stokBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gondrongStoreDataSet);

        }

        private void setok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gondrongStoreDataSet.stok' table. You can move, or remove it, as needed.
            this.stokTableAdapter.Fill(this.gondrongStoreDataSet.stok);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nama_stok = nama_stokTextBox.Text;
            var keterangan_stok = keterangan_stokTextBox.Text;
            var harga_stok = harga_stokTextBox.Text;
            var jumlah_stok = jumlah_stokTextBox.Text;

            koneksi.fromDBqueryExecute("INSERT into stok (nama_stok, keterangan_stok, harga_stok, jumlah_stok)" + 
                "VALUES ('" + nama_stok + "', '" + keterangan_stok + "','" + harga_stok +"', '" + jumlah_stok + "');");

            this.update_Data();
        }

        private void update_Data()
        {
            SqlConnection conn = koneksi.getDB();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM stok";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            stokDataGridView.DataSource = dt;
            conn.Close();
        }

        private void nama_stokTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
