using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WithNewUIUX
{
    class koneksi
    {
        public static SqlConnection getDB()
        {
            string connection_string = @"Data Source=Gus\SQLEXPRESS;Initial Catalog=GondrongStore;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection_string);

            return conn;
        }

        public static void fromDBqueryExecute(String sql_query)
        {
            string connection_string = @"Data Source=Gus\SQLEXPRESS;Initial Catalog=GondrongStore;Integrated Security=True ";
            SqlConnection conn = new SqlConnection(connection_string);

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql_query;
            var result = cmd.ExecuteNonQuery();
            conn.Close();

            if (Convert.ToBoolean(result))
            {
                MessageBox.Show("Berhasil Menambahkan Data !");
            }
            else
            {
                MessageBox.Show("Gagal Menambahkan Data !");
            }
        }
    }
}
