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
    public partial class katalok : Form
    {
        public katalok()
        {
            InitializeComponent();
        }

        private void katalogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.katalogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gondrongStoreDataSet);

        }

        private void katalok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gondrongStoreDataSet.katalog' table. You can move, or remove it, as needed.
            this.katalogTableAdapter.Fill(this.gondrongStoreDataSet.katalog);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nama_katalog = nama_katalogTextBox.Text;
            var harga_katalog = harga_katalogTextBox.Text;

            koneksi.fromDBqueryExecute("INSERT into katalog (nama_katalog, harga_katalog)" +
                "VALUES ('" + nama_katalog + "', '" + harga_katalog + "');");

            this.update_Data();
        }

        private void update_Data()
        {
            SqlConnection conn = koneksi.getDB();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM katalog";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            katalogDataGridView.DataSource = dt;
            conn.Close();
        }
    }
}
