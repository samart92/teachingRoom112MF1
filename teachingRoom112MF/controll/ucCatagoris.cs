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
using teachingRoom112MF.allForm;

namespace teachingRoom112MF.controll
{
    public partial class ucCatagoris : UserControl
    {
        string ID = null;
        public ucCatagoris(string ctg,string id)
        {
            InitializeComponent();
            lblText.Text = ctg;
            ID = id;
        }


        private void lblText_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.btnSelling_Click(sender, e);
            frmMain.Show();

        }

        //private void GetallProduct(string catagoryID)
        //{
        //    ucfilterByProduct c = new ucfilterByProduct();
        //    c.flowLayoutPanel2.Controls.Clear();
        //    MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.MySQLConnction);
        //    string sql = $"SELECT * FROM `tbproducts` WHERE `categoryID`='{catagoryID}';";
        //    var com = new MySqlCommand(sql, cnn);
        //    cnn.Open();
        //    MySqlDataReader dr = com.ExecuteReader();

        //    while (dr.Read())
        //    {
        //        ucProductItem product = new ucProductItem(dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString());
        //        c.flowLayoutPanel2.Controls.Add(product);
        //    }

        //    cnn.Close();
        //}
    }
}
