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
    public partial class ShippingForm : Form
    {
        public ShippingForm(int storeid, int productid)
        {
            InitializeComponent();
            ShippingForm_ID.Text = storeid.ToString(); ;
            ShippingForm_ProductID.Text = productid.ToString();
        }

        private void ShippingForm_ClientFill_Click(object sender, EventArgs e)
        {
            OrderForm_Client clientfrmItem = new OrderForm_Client();
            DialogResult drRet1 = clientfrmItem.ShowDialog();
            DialogResult = DialogResult.None;
            string orderclientid = clientfrmItem.Order_ClientID.Text;
            string orderclientname = clientfrmItem.Order_ClientName.Text;
            string orderclientaddress = clientfrmItem.Order_ClientAddress.Text;
            ShippingForm_ClientID.Text = orderclientid;
            ShippingForm_Client1.Text = orderclientname;
            ShippingForm_Client2.Text = orderclientaddress;
        }

        private void ShippingForm_Send_Click(object sender, EventArgs e)
        {
            int number;
            if (DialogResult == DialogResult.Cancel)
            {

            }
            else if (ShippingForm_Client1.Text == "" && ShippingForm_Client2.Text == "")
            {
                MessageBox.Show("顧客を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (ShippingForm_Amount.Text == "")
            {
                MessageBox.Show("数量を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (ShippingForm_Resp.Text == "")
            {
                MessageBox.Show("担当名を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (Int32.TryParse(ShippingForm_Amount.Text, out number) == false)
            {
                MessageBox.Show("数量に数字を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (DialogResult == DialogResult.OK)
            {
                DialogResult res = MessageBox.Show("データを送信します。よろしいですか", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    DialogResult = DialogResult.None;
            }
        }
    }
    }
