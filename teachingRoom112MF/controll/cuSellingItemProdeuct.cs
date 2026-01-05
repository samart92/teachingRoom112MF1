using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teachingRoom112MF.allForm;

namespace teachingRoom112MF.controll
{
    
    public partial class cuSellingItemProdeuct : UserControl
    {
        int count = 1;
        string _price = "";
        public cuSellingItemProdeuct(string name, string price )
        {
            InitializeComponent();
            _price = price;
            lblPrices.Text = _price + " x " + count ;

            lblName.Text = name;
            lblTotal.Text = (Double.Parse(_price) * count).ToString("F2");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMain fm = (frmMain)Application.OpenForms["frmMain"];

            
            fm.flowLayoutPanel2.Controls.Remove(this);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count += 1;
            lblPrices.Text = _price + " x " + count;
            lblTotal.Text = (Double.Parse(_price) * count).ToString("F2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
            count += -1;
            if (count < 1)
            {
                btnClose_Click(sender, e);
            }
            lblPrices.Text = _price + " x " + count;
            lblTotal.Text = (Double.Parse(_price)*count).ToString("F2");
        }
    }
}
