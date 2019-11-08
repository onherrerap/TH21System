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
    public partial class LoginScreen : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public LoginScreen()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\TH21Database.accdb;
Persist Security Info=False;";
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT COUNT(*) FROM User_Database WHERE User_Username='" + Login_User.Text + "' AND User_Password='" + Login_Password.Text + "'";
                command.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                useravailable.DataSource = dt;
                useravailable.Update();
                useravailable.Refresh();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            if (useravailable.Rows[0].Cells[0].Value.ToString() == "0")
            {
                MessageBox.Show("アックセスない");
                return;
            }
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT User_Type, User_Name FROM User_Database WHERE User_Username='" + Login_User.Text + "' AND User_Password='" + Login_Password.Text + "'";
                command.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                useravailable2.DataSource = dt;
                useravailable2.Update();
                useravailable2.Refresh();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            string UName = useravailable2.Rows[0].Cells[1].Value.ToString();
            if (useravailable2.Rows[0].Cells[0].Value.ToString() == "main")
            {
                User1Menu user1 = new User1Menu();
                user1.Show();
                this.Hide();
            }
            else if (useravailable2.Rows[0].Cells[0].Value.ToString() == "sales")
            {
                User2Menu user2 = new User2Menu();
                user2.Show();
                this.Hide();
            }
            else if (useravailable2.Rows[0].Cells[0].Value.ToString() == "logistics")
            {
                User3Menu user3 = new User3Menu();
                user3.Show();
                this.Hide();
            }

        }
        private void Login_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LoginButton.PerformClick();
            }
        }

        private void Login_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LoginButton.PerformClick();
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
