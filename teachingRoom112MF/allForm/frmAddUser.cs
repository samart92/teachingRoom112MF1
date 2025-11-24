using MySql.Data.MySqlClient;
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

namespace teachingRoom112MF.allForm
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.MySQLConnction);
            string sql = $"INSERT INTO `tbuser`( `fullName`, `role`, `pinCode`, `isActive`, `createAt`) VALUES ('{txtUserName.Text}','{cbbRole.SelectedItem}','{txtPassword.Text}','0','{DateTime.Today.ToString("yyyy-MM-dd")}')";
            MySqlCommand cm = new MySqlCommand(sql, conn);
            conn.Open();
            cm.ExecuteNonQuery();
            conn.Close();

               ///celling function show user
            ShowAllUsers();
        }

        /// create function show all user
        
        private void ShowAllUsers()
        {
            var con = new MySqlConnection(Properties.Settings.Default.MySQLConnction);
            var sql = "SELECT * FROM tbuser";
            var com = new MySqlCommand(sql, con);
            var da = new MySqlDataAdapter(com);
            var dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            dgvAllUser.DataSource = dt;

        }


    }
}
