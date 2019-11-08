using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TH21System
{
    public partial class OrderForm_Product : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public OrderForm_Product()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\TH21Database.accdb;
Persist Security Info=False;";
        }
        private void OrderForm_Product_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT Product_ID as ID, Product_Brand as ブランド名, Product_Name as 商品名, Product_Category as 分類, Product_Price as 単価  FROM Product_Database";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Order_ProductList.DataSource = dt;

                Order_ProductList.Update();
                Order_ProductList.Refresh();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("エラー: " + ex);
            }
        }

        private void Order_ProductList_Click(object sender, EventArgs e)
        {
            if (Order_ProductList.RowCount == 0)
            {
                MessageBox.Show("商品を入力してください");
                return;
            }
            int nowRow = Order_ProductList.CurrentRow.Index;
            Order_ProductID.Text= Order_ProductList.Rows[nowRow].Cells[0].Value.ToString();
            Order_ProductBrand.Text = Order_ProductList.Rows[nowRow].Cells[1].Value.ToString();
            Order_ProductName.Text = Order_ProductList.Rows[nowRow].Cells[2].Value.ToString();
            Order_ProductCategory.Text = Order_ProductList.Rows[nowRow].Cells[3].Value.ToString();
            Order_ProductPrice.Text = Order_ProductList.Rows[nowRow].Cells[4].Value.ToString();
        }
    }
    }
