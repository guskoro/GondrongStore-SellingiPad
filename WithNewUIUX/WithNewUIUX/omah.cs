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
    public partial class omah : Form
    {
        public omah()
        {
            InitializeComponent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_BuyForYourStore_Click_1(object sender, EventArgs e)
        {
            Form_Omah_Panel.Controls.Clear();

            buyforyourstore form = new buyforyourstore();
            form.TopLevel = false;
            Form_Omah_Panel.Controls.Add(form);
            form.Show();
        }

        private void btn_BuyForYou_Click_1(object sender, EventArgs e)
        {
            Form_Omah_Panel.Controls.Clear();

            buyforyou form = new buyforyou();
            form.TopLevel = false;
            Form_Omah_Panel.Controls.Add(form);
            form.Show();
        }
    }
}
