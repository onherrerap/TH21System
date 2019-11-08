using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH21System
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        public UserForm(string clientid,
            string name,
            string type,
            string username,
            string password)
        {
            if (type == "main")
            {
                type = "本社";
            }
            else if (type == "sales")
            {
                type = "営業";
            }
            else if (type == "logistics")
            {
                type = "物流";
            }
            InitializeComponent();
            UserForm_ID.Text =clientid;
            UserForm_Name.Text = name;
            UserForm_Type.Text = type;
            UserForm_Username.Text = username;
            UserForm_Password.Text = password;
            UserForm_Password2.Text = password;
            UserForm_Password.PasswordChar = '●';
            UserForm_Password2.PasswordChar = '●';

        }

        private void UserForm_Send_Click(object sender, EventArgs e)
        {
            if (DialogResult == DialogResult.Cancel)
            {

            }
            else if (UserForm_Name.Text == "")
            {
                MessageBox.Show("氏名を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (UserForm_Username.Text == "")
            {
                MessageBox.Show("ユーザー名を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (UserForm_Type.Text == "")
            {
                MessageBox.Show("住所を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (UserForm_Password.Text == "")
            {
                MessageBox.Show("パスワードを入力してください");
                DialogResult = DialogResult.None;
            }
            else if (UserForm_Password2.Text == "")
            {
                MessageBox.Show("パスワード確認を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (UserForm_Password.Text != UserForm_Password2.Text)
            {
                MessageBox.Show("パスワードが一致してください");
                DialogResult = DialogResult.None;
            }

            else if (DialogResult != DialogResult.Cancel)
            {
                DialogResult res = MessageBox.Show(UserForm_Username.Text + " のデータを送信します。よろしいですか", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    DialogResult = DialogResult.None;
            }
        }
    }
    }
