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
    public partial class adminjual : Form
    {
        public adminjual()
        {
            InitializeComponent();
        }

        private void penjualanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.penjualanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gondrongStoreDataSet);

        }

        private void adminjual_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gondrongStoreDataSet.penjualan' table. You can move, or remove it, as needed.
            this.penjualanTableAdapter.Fill(this.gondrongStoreDataSet.penjualan);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
        }
    }
}
