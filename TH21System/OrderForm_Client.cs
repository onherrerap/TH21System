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
    public partial class OrderForm_Client : Form
    {
        private DataTable detailTable;
        private OleDbConnection connection = new OleDbConnection();
        public OrderForm_Client()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\TH21Database.accdb;
Persist Security Info=False;";
        }
        private void OrderForm_Client_Load(object sender, EventArgs e)
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
                string query = "SELECT Client_ID as ID, Client_Name as 顧客名, Client_Address1 as 住所1, Client_Address2 as 住所2  FROM Client_Database";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Order_ClientList.DataSource = dt;

                Order_ClientList.Update();
                Order_ClientList.Refresh();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("エラー: " + ex);
            }
        }


        private void Order_ClientList_Click(object sender, EventArgs e)
        {
            if (Order_ClientList.RowCount == 0)
            {
                MessageBox.Show("顧客を入力してください");
                return;
            }
            int nowRow = Order_ClientList.CurrentRow.Index;
            Order_ClientID.Text= Order_ClientList.Rows[nowRow].Cells[0].Value.ToString();
            Order_ClientName.Text = Order_ClientList.Rows[nowRow].Cells[1].Value.ToString();
            Order_ClientAddress.Text = Order_ClientList.Rows[nowRow].Cells[2].Value.ToString() +" - "+ Order_ClientList.Rows[nowRow].Cells[3].Value.ToString();
        }
    }
    }
