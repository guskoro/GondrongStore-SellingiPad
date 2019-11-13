using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithNewUIUX
{
    public partial class adminbeli : Form
    {
        public adminbeli()
        {
            InitializeComponent();
        }

        private void pembelianBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pembelianBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gondrongStoreDataSet);

        }

        private void adminbeli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gondrongStoreDataSet.pembelian' table. You can move, or remove it, as needed.
            this.pembelianTableAdapter.Fill(this.gondrongStoreDataSet.pembelian);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
