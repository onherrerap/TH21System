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
    public partial class StoreForm : Form
    {
        public StoreForm()
        {
            InitializeComponent();
        }

        public StoreForm(int storeid, int productid)
        {
            InitializeComponent();
            OrderForm_ProductFill.Enabled = false;
            StoreForm_ID.Text = storeid.ToString();
            StoreForm_Product1.Text = productid.ToString();
            StoreForm_L3.Text = "数量";
        }
        private void OrderForm_ProductFill_Click(object sender, EventArgs e)
        {
            OrderForm_Product productfrmItem = new OrderForm_Product();
            DialogResult drRet2 = productfrmItem.ShowDialog();
            DialogResult = DialogResult.None;
            string orderproductid = productfrmItem.Order_ProductID.Text;
            string orderproductname = productfrmItem.Order_ProductName.Text;
            StoreForm_Product1.Text = orderproductid;
            StoreForm_Product2.Text = orderproductname;
        }

        private void StoreForm_Send_Click(object sender, EventArgs e)
        {
            int number;
            if (DialogResult == DialogResult.Cancel)
            {

            }
            else if (StoreForm_Product1.Text == "")
            {
                MessageBox.Show("商品名を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (StoreForm_Amount.Text == "")
            {
                MessageBox.Show("数量を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (Int32.TryParse(StoreForm_Amount.Text, out number) == false)
            {
                MessageBox.Show("数量に数字を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (StoreForm_Resp.Text == "")
            {
                MessageBox.Show("担当者を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (DialogResult != DialogResult.Cancel)
            {
                DialogResult res = MessageBox.Show(StoreForm_Product2.Text + " のデータを送信します。よろしいですか", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    DialogResult = DialogResult.None;
            }
        }
    }
}
