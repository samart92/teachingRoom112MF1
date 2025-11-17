using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace teachingRoom112MF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            ////allForm.frmMain fm = new allForm.frmMain();
            ////fm.Show();
            ////this.Hide();
            ////
            //SqlConnection conn = new SqlConnection(Properties.Settings.Default.Dbconncetion);             
            //string sql = "INSERT INTO tbUser(FullName) VALUES('SAM ART')";
            //SqlCommand cmd = new SqlCommand(sql, conn);            
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();




            //connection string

            MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.MySQLConnction);
            string sql = "insert ...";
            MySqlCommand cm = new MySqlCommand(sql, conn);
            conn.Open();
            cm.ExecuteNonQuery();
            conn.Close();




        }
    }
}
