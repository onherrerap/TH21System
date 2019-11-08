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
    public partial class StoreMan : Form
    {
        private DataTable detailTable;
        private OleDbConnection connection = new OleDbConnection();
        public StoreMan()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\TH21Database.accdb;
Persist Security Info=False;";
        }

        private void StoreMan_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void Store_SearchBox_Click(object sender, EventArgs e)
        {
            if (Store_SearchBox.Text == "検索")
                Store_SearchBox.Text = "";
        }
        private void Store_StoreNewButton_Click(object sender, EventArgs e)
        {
            StoreNew();
        }
        private void Store_ExistingButton_Click(object sender, EventArgs e)
        {
            StoreExisting();
        }
        private void Store_DeleteButton_Click(object sender, EventArgs e)
        {
            ShippingProduct();
        }
        private void GetData()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT S.Store_ID as ID, S.Product_ID as 商品ID, P.Product_Name, S.Store_LastDay as 最終入庫日, S.Store_CurrentAmount as 数量 FROM Store_Database AS S INNER JOIN Product_Database AS P ON S.Product_ID = P.Product_ID";

                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Store_List.DataSource = dt;
                Store_List.Update();
                Store_List.Refresh();
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
                string query = "SELECT S.Store_ID as ID, S.Product_ID as 商品ID, P.Product_Name, S.Store_LastDay as 最終入庫日, S.Store_CurrentAmount as 数量 FROM Store_Database AS S INNER JOIN Product_Database AS S ON S.Product_ID = P.Product_ID  WHERE " + categoryvalue + " LIKE '%" + searchvalue + "%'";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Store_List.DataSource = dt;
                Store_List.Update();
                Store_List.Refresh();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("エラー: " + ex);
            }
        }
        private void StoreNew()
        {
            StoreForm frmItem = new StoreForm();
            DialogResult drRet = frmItem.ShowDialog();

            if (drRet == DialogResult.OK)
            {
                try
                {
                    int productid = int.Parse(frmItem.StoreForm_Product1.Text);
                    string orderday = DateTime.Today.ToString("yyyy/MM/dd");
                    int amount = int.Parse(frmItem.StoreForm_Amount.Text);
                    string resp = frmItem.StoreForm_Resp.Text;
                    connection.Open();
                    detailTable = new DataTable();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Store_Database (Product_ID, Store_LastDay, Store_CurrentAmount) VALUES (" + productid + ",Date()," + amount + ")";
                    command.ExecuteNonQuery();
                    OleDbCommand log = new OleDbCommand();
                    log.Connection = connection;
                    log.CommandText = "INSERT INTO Log_Database (Log_Day, Log_Type, Product_ID, Log_Amount, Log_Resp) VALUES (Date(), '入庫'," + productid + "," + amount+ ",'" + resp + "')";
                    log.ExecuteNonQuery();
                    connection.Close();
                    GetData();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }

            }
        }
        private void StoreExisting()
        {
            if (Store_List.RowCount == 0)
            {
                MessageBox.Show("商品を入力してください");
                return;
            }
            int nowRow = Store_List.CurrentRow.Index;
            int oldstoreid = Int32.Parse(Store_List.Rows[nowRow].Cells[0].Value.ToString());
            int oldproductid = Int32.Parse(Store_List.Rows[nowRow].Cells[1].Value.ToString());
            int oldamount = Int32.Parse(Store_List.Rows[nowRow].Cells[4].Value.ToString());

            StoreForm frmItem = new StoreForm(oldstoreid,oldproductid);
            frmItem.StoreForm_Send.Text = "追加";
            DialogResult drRet = frmItem.ShowDialog();

            if (drRet == DialogResult.OK)
            {

                try
                {
                    int storeid = int.Parse(frmItem.StoreForm_ID.Text);
                    int amount = int.Parse(frmItem.StoreForm_Amount.Text);
                    string resp = frmItem.StoreForm_Resp.Text;
                    connection.Open();
                    detailTable = new DataTable();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "UPDATE Store_Database  SET Store_CurrentAmount=" + (amount+oldamount) + " WHERE Store_ID= " + storeid;
                    command.ExecuteNonQuery();
                    OleDbCommand log = new OleDbCommand();
                    log.Connection = connection;
                    log.CommandText = "INSERT INTO Log_Database (Log_Day, Log_Type, Product_ID, Log_Amount, Log_Resp) VALUES (Date(), '入庫'," + oldproductid + "," + amount + ",'" + resp + "')";
                    log.ExecuteNonQuery();
                    connection.Close();
                    GetData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }

            }
        }

        private void ShippingProduct()
        {
            if (Store_List.RowCount == 0)
            {
                MessageBox.Show("商品を入力してください");
                return;
            }
            int nowRow = Store_List.CurrentRow.Index;
            int oldstoreid = Int32.Parse(Store_List.Rows[nowRow].Cells[0].Value.ToString());
            int oldproductid = Int32.Parse(Store_List.Rows[nowRow].Cells[1].Value.ToString());
            int oldamount = Int32.Parse(Store_List.Rows[nowRow].Cells[4].Value.ToString());

            ShippingForm frmItem = new ShippingForm(oldstoreid, oldproductid);
            frmItem.ShippingForm_Send.Text = "出庫";
            DialogResult drRet = frmItem.ShowDialog();

            if (drRet == DialogResult.OK)
            {

                try
                {
                    string storeid = frmItem.ShippingForm_ID.Text;
                    int amount = int.Parse(frmItem.ShippingForm_Amount.Text);
                    string client = frmItem.ShippingForm_Client1.Text;
                    string resp = frmItem.ShippingForm_Resp.Text;
                    connection.Open();
                    detailTable = new DataTable();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "UPDATE Store_Database  SET Store_CurrentAmount=" + (oldamount-amount) + " WHERE Store_ID= " + storeid;
                    command.ExecuteNonQuery();
                    OleDbCommand log = new OleDbCommand();
                    log.Connection = connection;
                    log.CommandText = "INSERT INTO Log_Database (Log_Day, Log_Type, Product_ID, Log_Amount, Log_Subject, Log_Resp) VALUES (Date(), '出庫'," + oldproductid + "," + amount + ",'" + client + "','" + resp + "')";
                    log.ExecuteNonQuery();
                    connection.Close();
                    GetData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }

            }
        }

        private void Store_ReturnButton_Click(object sender, EventArgs e)
        {
            User3Menu user3 = new User3Menu();
            user3.Show();
            this.Close();
        }

        private void Store_SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (Store_SearchBox.Text=="")
            {
                GetData();
            }
            else if (SearchCombo.Text == "ID")
                SearchData(Store_SearchBox.Text, "Store_ID");
            else if (SearchCombo.Text == "ブランド名")
                SearchData(Store_SearchBox.Text, "Store_Brand");
            else if (SearchCombo.Text == "商品名")
                SearchData(Store_SearchBox.Text, "Store_Name");
            else if (SearchCombo.Text == "分類")
                SearchData(Store_SearchBox.Text, "Store_Category");
        }

    }
}