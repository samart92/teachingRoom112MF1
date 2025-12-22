using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teachingRoom112MF.controll;
using MySql.Data.MySqlClient;

namespace teachingRoom112MF.allForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExite_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Close();


        }

        public void btnSelling_Click(object sender, EventArgs e)
        {
            ucfilterByProduct fpro = new ucfilterByProduct();
            flowLayoutPanel1.Controls.Add(fpro);

            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
