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
using teachingRoom112MF.allForm;


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
             MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.MySQLConnction);
            string sql = $"SELECT * FROM tbuser WHERE fullName='{txtUserName.Text}' AND pinCode='{txtPassword.Text}'";
           MySqlCommand cm= new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
               frmMain fm = new frmMain();
                fm.lblUser.Text = txtUserName.Text;
                fm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("No user found");
            }
            conn.Close();

        }


        
    }
}
