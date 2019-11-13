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
    public partial class awakku : Form
    {
        public awakku()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gondrongStoreDataSet);

        }

        private void awakku_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gondrongStoreDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.gondrongStoreDataSet.user);

        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nama_user = nama_userTextBox.Text;
            var alamat_user = alamat_userTextBox.Text;
            var telp_user = telp_userTextBox.Text;

            koneksi.fromDBqueryExecute("INSERT into user (nama_user, alamat_user, telp_user)" +
                "VALUES ('" + nama_user + "', '" + alamat_user + "', '" + telp_user + "');");

            this.update_Data();
        }

        private void update_Data()
        {
            SqlConnection conn = koneksi.getDB();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM user";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            userDataGridView.DataSource = dt;
            conn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
