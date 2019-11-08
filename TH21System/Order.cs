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
    public partial class OrderMan : Form
    {
        private DataTable detailTable;
        private OleDbConnection connection = new OleDbConnection();
        public OrderMan()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\TH21Database.accdb;
Persist Security Info=False;";
        }

        private void OrderMan_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void Order_SearchBox_Click(object sender, EventArgs e)
        {
            if (Order_SearchBox.Text == "検索")
                Order_SearchBox.Text = "";
        }

        private void Order_AddButton_Click(object sender, EventArgs e)
        {
            AddData();
        }
        private void Order_UpdateButton_Click(object sender, EventArgs e)
        {
            CancelOrder();
        }
        private void GetData()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT O.Order_ID as ID, O.Order_Day as 日付, O.Client_ID as 顧客ID, O.Product_ID as 商品ID, P.Product_Name as 商品, O.Order_Amount as 量, O.Order_Resp as 担当名, O.Order_State as 受注状況 FROM Order_Database AS O INNER JOIN Product_Database AS P ON O.Product_ID = P.Product_ID";

                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Order_List.DataSource = dt;
                Order_List.Update();
                Order_List.Refresh();

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
                string query = "SELECT O.Order_ID as ID, O.Order_Day as 日付, O.Client_ID as 顧客ID, O.Product_ID as 商品ID, P.Product_Name as 商品, O.Order_Amount as 量, O.Order_Resp as 担当名, O.Order_State as 受注状況 FROM Order_Database AS O INNER JOIN Product_Database AS P ON O.Product_ID = P.Product_ID WHERE " + categoryvalue + " LIKE '%" + searchvalue + "%'";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Order_List.DataSource = dt;
                Order_List.Update();
                Order_List.Refresh();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("エラー: " + ex);
            }
        }
        private void AddData()
        {
            OrderForm frmItem = new OrderForm();
            DialogResult drRet = frmItem.ShowDialog();

            if (drRet == DialogResult.OK)
            {
                try
                {
                    string orderday = DateTime.Today.ToString("yyyy/MM/dd");
                    int productid = Int32.Parse(frmItem.OrderForm_Product1.Text);
                    int clientid = Int32.Parse(frmItem.OrderForm_ClientID.Text);
                    int amount = Int32.Parse(frmItem.OrderForm_Amount.Text);
                    string resp = frmItem.OrderForm_Resp.Text;
                    connection.Open();
                    detailTable = new DataTable();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Order_Database (Order_Day,Product_ID,Client_ID,Order_Amount,Order_Resp, Order_State) VALUES (Date()," + productid + "," + clientid + "," + amount + ",'" + resp +"', '受注')";

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
        private void CancelOrder()
        {
            if (Order_List.RowCount == 0)
            {
                MessageBox.Show("受注を入力してください");
                return;
            }
            int nowRow = Order_List.CurrentRow.Index;
            string orderid = Order_List.Rows[nowRow].Cells[0].Value.ToString();
            try
                {
                connection.Open();
                detailTable = new DataTable();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE Order_Database  SET Order_State= 'キャンセル' WHERE Order_ID= " + orderid;
                command.ExecuteNonQuery();
                connection.Close();
                GetData();
            }
            catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
        }
        private void Order_ReturnButton_Click(object sender, EventArgs e)
        {
            User2Menu user2 = new User2Menu();
            user2.Show();
            this.Close();
        }

        private void Order_SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (Order_SearchBox.Text=="")
            {
                GetData();
            }
            else if (SearchCombo.Text == "ID")
                SearchData(Order_SearchBox.Text, "O.Order_ID");
            else if (SearchCombo.Text == "日付")
                SearchData(Order_SearchBox.Text, "O.Order_Day");
            else if (SearchCombo.Text == "商品ID")
                SearchData(Order_SearchBox.Text, "O.Product_ID");
            else if (SearchCombo.Text == "顧客ID")
                SearchData(Order_SearchBox.Text, "O.Client_ID");
            else if (SearchCombo.Text == "状況")
                SearchData(Order_SearchBox.Text, "O.Order_Status");
        }
    }
}