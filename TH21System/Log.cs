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
    public partial class LogMan : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public LogMan()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\TH21Database.accdb;
Persist Security Info=False;";
        }

        private void LogMan_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void Log_SearchBox_Click(object sender, EventArgs e)
        {
            if (Log_SearchBox.Text == "検索")
                Log_SearchBox.Text = "";
        }

        private void GetData()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT L.Log_ID as ID, L.Log_Day as 日付, L.Log_Type as タイプ, P.Product_ID as 商品ID, P.Product_Brand & ' - ' & P.Product_Name as 商品, L.Log_Amount as 数量, L.Log_Subject as 顧客名, Log_Resp as 担当者 FROM Log_Database AS L INNER JOIN Product_Database AS P ON L.Product_ID = P.Product_ID";

                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Log_List.DataSource = dt;
                Log_List.Update();
                Log_List.Refresh();
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
                string query = "SELECT Log_ID as ID, Log_Day as 日付, Log_Type as タイプ, Product_ID as 商品ID, Log_Type as タイプ, Log_Amount as 数量 FROM Log_Database WHERE " + categoryvalue + " LIKE '%" + searchvalue + "%'";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Log_List.DataSource = dt;
                Log_List.Update();
                Log_List.Refresh();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("エラー: " + ex);
            }
        }

        private void Log_ReturnButton_Click(object sender, EventArgs e)
        {
            User3Menu user3 = new User3Menu();
            user3.Show();
            this.Close();
        }

        private void Log_SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (Log_SearchBox.Text == "")
            {
                GetData();
            }
            else if (SearchCombo.Text == "ID")
                SearchData(Log_SearchBox.Text, "Log_ID");
            else if (SearchCombo.Text == "日付")
                SearchData(Log_SearchBox.Text, "Log_Day");
            else if (SearchCombo.Text == "商品ID")
                SearchData(Log_SearchBox.Text, "Product_ID");
            else if (SearchCombo.Text == "タイプ")
                SearchData(Log_SearchBox.Text, "Log_Type");
            else if (SearchCombo.Text == "引取先")
                SearchData(Log_SearchBox.Text, "Log_Subject");
            else if (SearchCombo.Text == "担当名")
                SearchData(Log_SearchBox.Text, "Log_Resp");
        }
    }
}