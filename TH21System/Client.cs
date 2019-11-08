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
    public partial class ClientMan : Form
    {
        private DataTable detailTable;
        private OleDbConnection connection = new OleDbConnection();
        public ClientMan()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\TH21Database.accdb;
Persist Security Info=False;";
        }

        private void ClientMan_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void Client_SearchBox_Click(object sender, EventArgs e)
        {
            if (Client_SearchBox.Text == "検索")
                Client_SearchBox.Text = "";
        }

        private void Client_AddButton_Click(object sender, EventArgs e)
        {
            AddData();
        }
        private void Client_UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void Client_DeleteButton_Click(object sender, EventArgs e)
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
                string query = "SELECT Client_ID as ID, Client_Name as 顧客名, Client_Tel as 電話番号, Client_PostalCode as 郵便番号, Client_Address1 as 住所1, Client_Address2 as 住所2 FROM Client_Database";

                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Client_List.DataSource = dt;
                Client_List.Update();
                Client_List.Refresh();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("エラー: " + ex);
            }
        }
        private void SearchData(string searchvalue, string categoryvalue)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT Client_ID as ID, Client_Name as 顧客名, Client_Tel as 電話番号, Client_PostalCode as 郵便番号, Client_Address1 as 住所1, Client_Address2 as 住所2 FROM Client_Database WHERE " + categoryvalue + " LIKE '%" + searchvalue + "%'";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Client_List.DataSource = dt;
                Client_List.Update();
                Client_List.Refresh();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("エラー: " + ex);
            }
        }
        private void AddData()
        {
            ClientForm frmItem = new ClientForm();
            DialogResult drRet = frmItem.ShowDialog();

            if (drRet == DialogResult.OK)
            {
                try
                {
                    string name = frmItem.ClientForm_Name.Text;
                    string tel = frmItem.ClientForm_Tel.Text;
                    string postal = frmItem.ClientForm_PostalCode.Text;
                    string address1 = frmItem.ClientForm_Address.Text;
                    string address2 = frmItem.ClientForm_Address2.Text;
                    connection.Open();
                    detailTable = new DataTable();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Client_Database (Client_Name, Client_Tel, Client_PostalCode, Client_Address1, Client_Address2) VALUES ('" + name + "','" + tel + "','" + postal + "','" + address1 + "','" + address2 + "')";

                    command.ExecuteNonQuery();
                    connection.Close();
                    GetData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("エラー: " + ex);
                }

            }
        }
        private void UpdateData()
        {
            if (Client_List.RowCount == 0)
            {
                MessageBox.Show("顧客を入力してください");
                return;
            }
            int nowRow = Client_List.CurrentRow.Index;
            string oldclientid = Client_List.Rows[nowRow].Cells[0].Value.ToString();
            string oldname = Client_List.Rows[nowRow].Cells[1].Value.ToString();
            string oldtel = Client_List.Rows[nowRow].Cells[2].Value.ToString();
            string oldpostal = Client_List.Rows[nowRow].Cells[3].Value.ToString();
            string oldaddress1 = Client_List.Rows[nowRow].Cells[4].Value.ToString();
            string oldaddress2 = Client_List.Rows[nowRow].Cells[5].Value.ToString();

            ClientForm frmItem = new ClientForm(oldclientid,oldname, oldtel, oldpostal, oldaddress1, oldaddress2);
            frmItem.ClientForm_Send.Text = "更新";
            DialogResult drRet = frmItem.ShowDialog();

            if (drRet == DialogResult.OK)
            {
                string clientid = frmItem.ClientForm_ID.Text;
                string name = frmItem.ClientForm_Name.Text;
                string tel = frmItem.ClientForm_Tel.Text;
                string postal = frmItem.ClientForm_PostalCode.Text;
                string address1 = frmItem.ClientForm_Address.Text;
                string address2 = frmItem.ClientForm_Address2.Text;
                try
                {
                    connection.Open();
                    detailTable = new DataTable();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "UPDATE Client_Database  SET Client_Name= '" + name + "', Client_Tel= '" + tel + "', Client_PostalCode= '" + postal + "', Client_Address1= '" + address1 + "', Client_Address2= '" + address2 + "' WHERE Client_ID= " + clientid;

                    command.ExecuteNonQuery();
                    connection.Close();
                    GetData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("エラー: " + ex);
                }

            }
        }
        private void DeleteData()
        {
            if (Client_List.RowCount == 0)
            {
                MessageBox.Show("顧客を入力してください");
                return;
            }
            try
                {
                string nowIndex = Client_List.SelectedRows[0].Cells[0].Value.ToString();

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string delete = "DELETE FROM Client_Database WHERE Client_ID="+ nowIndex;
                command.CommandText = delete;
                command.ExecuteNonQuery();
                connection.Close();
                GetData();

                }
            catch (Exception ex)
            {
                MessageBox.Show("エラー: " + ex);
            }

        }
        

        private void Client_ReturnButton_Click(object sender, EventArgs e)
        {
            User1Menu user1 = new User1Menu();
            user1.Show();
            this.Close();
        }

        private void Client_SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (Client_SearchBox.Text=="")
            {
                GetData();
            }
            else if (SearchCombo.Text == "ID")
                SearchData(Client_SearchBox.Text, "Client_ID");
            else if (SearchCombo.Text == "顧客名")
                SearchData(Client_SearchBox.Text, "Client_Name");
        }
    }
}