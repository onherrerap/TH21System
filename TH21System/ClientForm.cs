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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        public ClientForm(string clientid,
            string name,
            string tel,
            string postal,
            string address1,
            string address2)
        {
            InitializeComponent();
            ClientForm_ID.Text =clientid;
            ClientForm_Name.Text = name;
            ClientForm_Tel.Text = tel;
            ClientForm_PostalCode.Text = postal;
            ClientForm_Address.Text = address1;
            ClientForm_Address2.Text = address2;
        }

        private void ClientForm_Send_Click(object sender, EventArgs e)
        {
            if (DialogResult == DialogResult.Cancel)
            {

            }
            else if (ClientForm_Name.Text == "")
            {
                MessageBox.Show("氏名を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (ClientForm_Tel.Text == "")
            {
                MessageBox.Show("電話番号を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (ClientForm_PostalCode.Text == "")
            {
                MessageBox.Show("郵便番号を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (ClientForm_Address.Text == "")
            {
                MessageBox.Show("住所を入力してください");
                DialogResult = DialogResult.None;
            }

            else if (DialogResult != DialogResult.Cancel)
            {
                DialogResult res = MessageBox.Show(ClientForm_Name.Text + " のデータを送信します。よろしいですか", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    DialogResult = DialogResult.None;
            }
        }
    }
    }
