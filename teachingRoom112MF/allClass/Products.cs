using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace teachingRoom112MF.allClass
{
    public class Products
    {
        //public int catagoryID;
        //public string sku;
        //public string productName;
        //public double price;
        //public double taxRate;
        //public bool status;
        MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.MySQLConnction);




        public void Insert(int catagoryID, string sku, string productName, double price, double taxRate, int status) {            
            string sql = $"INSERT INTO `tbproducts`( `categoryID`, `sku`, `name`, `price`, `taxRate`, `isActive`, `CreateAt`) VALUES ('{catagoryID}','{sku}','{productName}','{price}','{taxRate}','{status}','{DateTime.Today.ToString("yyyy/MM/dd")}')";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cnn.Open();
           cmd.ExecuteNonQuery();
            cnn.Close();
           
        
        }
        public void Delete(int id)
        {
            string sql = $"DELETE FROM `tbproducts` WHERE id='{id}'";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void Update(int catagoryID, string sku, string productName, double price, double taxRate, int status,int id)
        {
            string sql = $"UPDATE `tbproducts` SET `categoryID`='{catagoryID}',`sku`='{sku}',`name`='{productName}',`price`='{price}',`taxRate`='{taxRate}',`isActive`='{status}' WHERE id='{id}'";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void SelectAll( DataGridView dg)
        {
            string sql = "SELECT * FROM tbproducts";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            dg.DataSource = dt;

        }
        public void SelectByID(DataGridView dg,string search)
        {
            string sql = $"SELECT * FROM tbproducts WHERE name like '{search}%'";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            dg.DataSource = dt;
        }

        public void SelectCatagory(ComboBox cobo)
        {
            string sql = "SELECT * FROM tbcategories";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            cobo.DataSource = dt;
            cobo.DisplayMember = "category";
            cobo.ValueMember = "id";
           

        }


    }
}
