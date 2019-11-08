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
    public partial class ProductMan : Form
    {
        private DataTable detailTable;
        private OleDbConnection connection = new OleDbConnection();
        public ProductMan()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\TH21Database.accdb;
Persist Security Info=False;";
        }

        private void ProductMan_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void Product_SearchBox_Click(object sender, EventArgs e)
        {
            if (Product_SearchBox.Text == "検索")
                Product_SearchBox.Text = "";
        }

        private void Product_AddButton_Click(object sender, EventArgs e)
        {
            AddData();
        }
        private void Product_UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void Product_DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteData();
        }
        private void GetData()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT Product_ID as ID, Product_Brand as ブランド名, Product_Name as 商品名, Product_Category as 分類, Product_Price as 単価, Product_StockPrice as 仕入価格 FROM Product_Database";

                command.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Product_List.DataSource = dt;
                Product_List.Update();
                Product_List.Refresh();
                Product_List.Columns[0].Width = 50;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void SearchData(string searchvalue, string categoryvalue)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT Product_ID as ID, Product_Brand as ブランド名, Product_Name as 商品名, Product_Category as 分類, Product_Price as 単価, Product_StockPrice as 仕入価格 FROM Product_Database WHERE " + categoryvalue + " LIKE '%" + searchvalue + "%'";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Product_List.DataSource = dt;
                Product_List.Update();
                Product_List.Refresh();
                Product_List.Columns[0].Width = 50;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("エラー: " + ex);
            }
        }
        private void AddData()
        {
            ProductForm frmItem = new ProductForm();
            DialogResult drRet = frmItem.ShowDialog();

            if (drRet == DialogResult.OK)
            {
                try
                {
                    string brand = frmItem.ProductForm_Brand.Text;
                    string name = frmItem.ProductForm_Name.Text;
                    string category = frmItem.ProductForm_Category.Text;
                    int price = int.Parse(frmItem.ProductForm_Price.Text);
                    int stock = int.Parse(frmItem.ProductForm_StockPrice.Text);
                    connection.Open();
                    detailTable = new DataTable();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Product_Database (Product_Brand,Product_Name,Product_Category,Product_Price,Product_StockPrice) VALUES ('"+ brand + "','" + name + "','" + category + "'," + price + "," + stock + ")";
                    command.ExecuteNonQuery();
                    connection.Close();
                    GetData();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }

            }
        }
        private void UpdateData()
        {
            if (Product_List.RowCount == 0)
            {
                MessageBox.Show("商品を入力してください");
                return;
            }
            int nowRow = Product_List.CurrentRow.Index;
            string oldproductid = Product_List.Rows[nowRow].Cells[0].Value.ToString();
            string oldbrand = Product_List.Rows[nowRow].Cells[1].Value.ToString();
            string oldname = Product_List.Rows[nowRow].Cells[2].Value.ToString();
            string oldcategory = Product_List.Rows[nowRow].Cells[3].Value.ToString();
            int oldprice = int.Parse(Product_List.Rows[nowRow].Cells[4].Value.ToString());
            int oldstock = int.Parse(Product_List.Rows[nowRow].Cells[5].Value.ToString());
            
            ProductForm frmItem = new ProductForm(oldproductid,oldbrand, oldname, oldcategory, oldprice, oldstock);
            frmItem.ProductForm_Send.Text = "更新";
            DialogResult drRet = frmItem.ShowDialog();

            if (drRet == DialogResult.OK)
            {
                string productid = frmItem.ProductForm_ID.Text;
                string brand = frmItem.ProductForm_Brand.Text;
                string name = frmItem.ProductForm_Name.Text;
                string category = frmItem.ProductForm_Category.Text;
                int price = int.Parse(frmItem.ProductForm_Price.Text);
                int stock = int.Parse(frmItem.ProductForm_StockPrice.Text);
                try
                {
                    connection.Open();
                    detailTable = new DataTable();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "UPDATE Product_Database  SET Product_Brand= '"+ brand + "', Product_Name= '"+ name + "', Product_Category= '" + category + "', Product_Price=" +price+ ", Product_StockPrice=" + stock + " WHERE Product_ID= " + productid;

                    command.ExecuteNonQuery();
                    connection.Close();
                    GetData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }

            }
        }
        private void DeleteData()
        {
            if (Product_List.RowCount == 0)
            {
                MessageBox.Show("商品を入力してください");
                return;
            }
            try
                {
                string nowIndex = Product_List.SelectedRows[0].Cells[0].Value.ToString();

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string delete = "DELETE FROM Product_Database WHERE Product_ID="+ nowIndex;
                command.CommandText = delete;
                command.ExecuteNonQuery();
                connection.Close();
                GetData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            
            }
        
        private void Product_ReturnButton_Click(object sender, EventArgs e)
        {
            User1Menu user1 = new User1Menu();
            user1.Show();
            this.Close();
        }

        private void Product_SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (Product_SearchBox.Text=="")
            {
                GetData();
            }
            else if (SearchCombo.Text == "ID")
                SearchData(Product_SearchBox.Text, "Product_ID");
            else if (SearchCombo.Text == "ブランド名")
                SearchData(Product_SearchBox.Text, "Product_Brand");
            else if (SearchCombo.Text == "商品名")
                SearchData(Product_SearchBox.Text, "Product_Name");
            else if (SearchCombo.Text == "分類")
                SearchData(Product_SearchBox.Text, "Product_Category");
        }
    }
}