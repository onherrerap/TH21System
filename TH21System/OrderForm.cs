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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_ClientFill_Click(object sender, EventArgs e)
        {
            OrderForm_Client clientfrmItem = new OrderForm_Client();
            DialogResult drRet1 = clientfrmItem.ShowDialog();
            DialogResult = DialogResult.None;
            string orderclientid = clientfrmItem.Order_ClientID.Text;
            string orderclientname = clientfrmItem.Order_ClientName.Text;
            string orderclientaddress = clientfrmItem.Order_ClientAddress.Text;
            OrderForm_ClientID.Text = orderclientid;
            OrderForm_Client1.Text = orderclientname;
            OrderForm_Client2.Text = orderclientaddress;
        }

        private void OrderForm_ProductFill_Click(object sender, EventArgs e)
        {
            OrderForm_Product productfrmItem = new OrderForm_Product();
            DialogResult drRet2 = productfrmItem.ShowDialog();
            DialogResult = DialogResult.None;
            string orderproductid = productfrmItem.Order_ProductID.Text;
            string orderproductbrand = productfrmItem.Order_ProductBrand.Text;
            string orderproductname = productfrmItem.Order_ProductName.Text;
            OrderForm_Product1.Text = orderproductid;
            OrderForm_Product2.Text = orderproductbrand + " - " + orderproductname;
        }
        private void OrderForm_Send_Click(object sender, EventArgs e)
        {
            int number;
            if (DialogResult == DialogResult.Cancel)
            {

            }
            else if (OrderForm_Client1.Text == "" && OrderForm_Client2.Text == "")
            {
                MessageBox.Show("顧客を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (OrderForm_Product1.Text == "" && OrderForm_Product2.Text == "")
            {
                MessageBox.Show("商品を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (OrderForm_Amount.Text == "")
            {
                MessageBox.Show("数量を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (OrderForm_Resp.Text == "")
            {
                MessageBox.Show("担当名を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (Int32.TryParse(OrderForm_Amount.Text, out number) == false)
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
