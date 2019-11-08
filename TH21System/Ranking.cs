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
    public partial class RankingMan : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public RankingMan()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\TH21Database.accdb;
Persist Security Info=False;";
        }

        private void RankingMan_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void Ranking_SearchBox_Click(object sender, EventArgs e)
        {
            if (Ranking_SearchBox.Text == "検索")
                Ranking_SearchBox.Text = "";
        }

        private void GetData()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT P.Product_ID as 商品ID, P.Product_Brand as ブランド, P.Product_Name as 商品, COUNT(O.Product_ID) AS 購入数 FROM Order_Database AS O INNER JOIN Product_Database AS P ON O.Product_ID = P.Product_ID WHERE O.Order_State= '受領済' GROUP BY P.Product_ID, P.Product_Brand, P.Product_Name ORDER BY COUNT(O.Product_ID)";

                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Ranking_List.DataSource = dt;
                Ranking_List.Update();
                Ranking_List.Refresh();
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
                string query = "SELECT P.Product_ID as 商品ID, P.Product_Brand as ブランド, P.Product_Name as 商品, COUNT(O.Product_ID) AS 購入数 FROM Order_Database AS O INNER JOIN Product_Database AS P ON O.Product_ID = P.Product_ID WHERE O.Order_State= '受領済' GROUP BY P.Product_ID, P.Product_Brand, P.Product_Name ORDER BY COUNT(O.Product_ID)";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Ranking_List.DataSource = dt;
                Ranking_List.Update();
                Ranking_List.Refresh();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("エラー: " + ex);
            }
        }

        private void Ranking_ReturnButton_Click(object sender, EventArgs e)
        {
            User2Menu user2 = new User2Menu();
            user2.Show();
            this.Close();
        }

        private void Ranking_SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (Ranking_SearchBox.Text == "")
            {
                GetData();
            }
            else if (SearchCombo.Text == "ID")
                SearchData(Ranking_SearchBox.Text, "O.Product_ID");
            else if (SearchCombo.Text == "ブランド名")
                SearchData(Ranking_SearchBox.Text, "P.Product_Brand");
            else if (SearchCombo.Text == "商品名")
                SearchData(Ranking_SearchBox.Text, "Product_Name");
        }
    }
}