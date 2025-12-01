using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teachingRoom112MF.allClass;

namespace teachingRoom112MF.allForm
{
    public partial class frmAddproduct : Form
    {

        Products product = new Products();
        public frmAddproduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //product.Insert(1, txtSKU.Text, txtProName.Text, Double.Parse(txtPrice.Text),double.Parse(txtTexRate.Text),0);
            //product.Delete(int.Parse(txtSKU.Text));
            product.Update(1, txtSKU.Text, txtProName.Text, double.Parse(txtPrice.Text), double.Parse(txtTexRate.Text),Convert.ToInt16(ckbStatus.Checked), 7);

            

            

        }
    }
}
