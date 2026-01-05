using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using teachingRoom112MF.allForm;

namespace teachingRoom112MF.controll
{
    public partial class ucProductItem : UserControl
    {
        public ucProductItem()
        {
            InitializeComponent();
            
        }
        

        public ucProductItem( string sku,string productName, string price)
        {
            InitializeComponent();
            lblSKU.Text = sku;
            lblProName.Text = productName;
            lblPrices.Text = price;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //frmMain fm = new frmMain();
            frmMain fm = (frmMain) Application.OpenForms["frmMain"];
            
            cuSellingItemProdeuct pr = new cuSellingItemProdeuct(lblProName.Text, lblPrices.Text);
           fm.flowLayoutPanel2.Controls.Add(pr);
            fm.Show();

            //MessageBox.Show(lblProName.Text);

        }

        private void ucProductItem_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }



        
    }
}
