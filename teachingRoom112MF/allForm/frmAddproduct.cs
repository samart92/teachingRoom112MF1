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
        string id;
        public frmAddproduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            product.Insert(1, txtSKU.Text, txtProName.Text, Double.Parse(txtPrice.Text),double.Parse(txtTexRate.Text),0);
            //product.Delete(int.Parse(txtSKU.Text));
            //product.Update(1, txtSKU.Text, txtProName.Text, double.Parse(txtPrice.Text), double.Parse(txtTexRate.Text),Convert.ToInt16(ckbStatus.Checked), 7);

            product.SelectAll(dataGridView1);
            ClearAllText();

            

            

        }

        private void frmAddproduct_Load(object sender, EventArgs e)
        {
            product.SelectAll(dataGridView1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            product.SelectByID(dataGridView1,txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0) { 
            product.SelectByID(dataGridView1, txtSearch.Text);
        }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) {
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSKU.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtProName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTexRate.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex == 0)
                {
                    var msg = MessageBox.Show("Do you want to Delete this recode?", "Delete", MessageBoxButtons.YesNo);

                    if (msg == DialogResult.Yes)
                    {
                        product.Delete(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));

                        product.SelectAll(dataGridView1);
                        ClearAllText();
                    }
                }
            }

            










        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            product.Update(1, txtSKU.Text, txtProName.Text, double.Parse(txtPrice.Text), double.Parse(txtTexRate.Text), Convert.ToInt16(ckbStatus.Checked),Convert.ToInt32(id));

            product.SelectAll(dataGridView1);
            ClearAllText();
        }


        private void ClearAllText()
        {
            txtPrice.Text = string.Empty;
            txtTexRate.Text = string.Empty; 
            txtSKU.Text = string.Empty; 
            txtProName.Text = string.Empty;
            ckbStatus.Checked = false;
            txtSKU.Focus();
            
        }

       
    }
}
