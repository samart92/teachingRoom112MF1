using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teachingRoom112MF.controll
{
    public partial class ucfilterByProduct : UserControl
    {
        public ucfilterByProduct()
        {
            InitializeComponent();
        }

        private void ucfilterByProduct_Load(object sender, EventArgs e)
        {
            MessageBox.Show("load");
            GetallCatagory();
            GetallProduct();

        }

        private void GetallProduct()
        {
            flowLayoutPanel2.Controls.Clear();
            MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.MySQLConnction);
            string sql = "SELECT * FROM `tbproducts`";
            var com = new MySqlCommand(sql, cnn);
            cnn.Open();
            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                ucProductItem product = new ucProductItem(dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString());
                flowLayoutPanel2.Controls.Add(product);
            }

            cnn.Close();
        }


        private void GetallCatagory()
        {
            flowLayoutPanel1.Controls.Clear();

            ucCatagoris btn = new ucCatagoris("All","1");
            flowLayoutPanel1.Controls.Add(btn);

            MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.MySQLConnction);
            string sql = "SELECT * FROM `tbcategories`";
            var com = new MySqlCommand(sql, cnn);
            cnn.Open();
            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                ucCatagoris btn1 = new ucCatagoris(dr.GetValue(1).ToString(), dr.GetValue(0).ToString());
                flowLayoutPanel1.Controls.Add(btn1);
            }

            cnn.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
