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
    public partial class UserMan : Form
    {
        private DataTable detailTable;
        private OleDbConnection connection = new OleDbConnection();
        public UserMan()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\TH21Database.accdb;
Persist Security Info=False;";
        }

        private void UserMan_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void User_SearchBox_Click(object sender, EventArgs e)
        {
            if (User_SearchBox.Text == "検索")
                User_SearchBox.Text = "";
        }

        private void User_AddButton_Click(object sender, EventArgs e)
        {
            AddData();
        }
        private void User_UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void User_DeleteButton_Click(object sender, EventArgs e)
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
                string query = "SELECT User_ID as ID, User_Name as 氏名, User_Username as ユーザー名, User_Password, User_Type as 役職 FROM User_Database";

                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                User_List.DataSource = dt;
                User_List.Update();
                User_List.Refresh();
                User_List.Columns[3].Visible = false;
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
                string query = "SELECT User_ID as ID, User_Name as 氏名, User_Username as ユーザー名, User_Password, User_Type as 役職 FROM User_Database WHERE " + categoryvalue + " LIKE '%" + searchvalue + "%'";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                User_List.DataSource = dt;
                User_List.Update();
                User_List.Refresh();
                User_List.Columns[3].Visible = false;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("エラー: " + ex);
            }
        }
        private void AddData()
        {
            UserForm frmItem = new UserForm();
            DialogResult drRet = frmItem.ShowDialog();

            if (drRet == DialogResult.OK)
            {
                try
                {
                    string name = frmItem.UserForm_Name.Text;
                    string type = frmItem.UserForm_Type.Text;
                    string username = frmItem.UserForm_Username.Text;
                    string password = frmItem.UserForm_Password.Text;
                    if (type == "本社")
                    {
                        type = "main";
                    }
                    else if (type == "営業")
                    {
                        type = "sales";
                    }
                    else if (type == "物流")
                    {
                        type = "logistics";
                    }
                    connection.Open();
                    detailTable = new DataTable();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO User_Database (User_Name, User_Username, User_Password, User_Type) VALUES ('" + name + "','" + username + "','" + password + "','" + type + "')";

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
            if (User_List.RowCount == 0)
            {
                MessageBox.Show("ユーザーを入力してください");
                return;
            }
            int nowRow = User_List.CurrentRow.Index;
            string olduserid = User_List.Rows[nowRow].Cells[0].Value.ToString();
            string oldname = User_List.Rows[nowRow].Cells[1].Value.ToString();
            string oldusername = User_List.Rows[nowRow].Cells[2].Value.ToString();
            string oldpassword = User_List.Rows[nowRow].Cells[3].Value.ToString();
            string oldtype = User_List.Rows[nowRow].Cells[4].Value.ToString();

            UserForm frmItem = new UserForm(olduserid,oldname, oldtype, oldusername,  oldpassword);
            frmItem.UserForm_Send.Text = "更新";
            DialogResult drRet = frmItem.ShowDialog();

            if (drRet == DialogResult.OK)
            {

                try
                {
                    string userid = frmItem.UserForm_ID.Text;
                    string name = frmItem.UserForm_Name.Text;
                    string username = frmItem.UserForm_Username.Text;
                    string password = frmItem.UserForm_Password.Text;
                    string type = frmItem.UserForm_Type.Text;
                    if (type == "本社")
                    {
                        type = "main";
                    }
                    else if (type == "営業")
                    {
                        type = "sales";
                    }
                    else if (type == "物流")
                    {
                        type = "logistics";
                    }
                    connection.Open();
                    detailTable = new DataTable();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "UPDATE User_Database  SET User_Name= '" + name + "', User_Username= '" + username + "', User_Password= '" + password + "', User_Type= '" + type + "' WHERE User_ID= " + userid;

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
            if (User_List.RowCount == 0)
            {
                MessageBox.Show("ユーザーを入力してください");
                return;
            }
            try
                {
                string nowIndex = User_List.SelectedRows[0].Cells[0].Value.ToString();

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string delete = "DELETE FROM User_Database WHERE User_ID="+ nowIndex;
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
        

        private void User_ReturnButton_Click(object sender, EventArgs e)
        {
            User1Menu user1 = new User1Menu();
            user1.Show();
            this.Close();
        }

        private void User_SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (User_SearchBox.Text=="")
            {
                GetData();
            }
            else if (SearchCombo.Text == "ID")
                SearchData(User_SearchBox.Text, "User_ID");
            else if (SearchCombo.Text == "氏名")
                SearchData(User_SearchBox.Text, "User_Name");
            else if (SearchCombo.Text == "役職")
                SearchData(User_SearchBox.Text, "User_Type");
        }
    }
}