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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(string productid,
            string brand,
            string name,
            string category,
            int price,
            int stock)
        {
            InitializeComponent();
            ProductForm_ID.Text = productid;
            ProductForm_Brand.Text = brand;
            ProductForm_Name.Text = name;
            ProductForm_Category.Text = category;
            ProductForm_Price.Text = Convert.ToString(price);
            ProductForm_StockPrice.Text = Convert.ToString(stock);
        }

        private void ProductForm_Send_Click(object sender, EventArgs e)
        {
            int number;
            if (DialogResult == DialogResult.Cancel)
            {
            }
            else if (ProductForm_Brand.Text == "")
            {
                MessageBox.Show("ブランド名を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (ProductForm_Name.Text == "")
            {
                MessageBox.Show("商品名を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (ProductForm_Category.Text == "")
            {
                MessageBox.Show("分類を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (ProductForm_Price.Text == "")
            {
                MessageBox.Show("単価を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (Int32.TryParse(ProductForm_Price.Text, out number) == false)
            {
                MessageBox.Show("単価に数字を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (ProductForm_StockPrice.Text == "")
            {
                MessageBox.Show("仕入価格を入力してください");
                DialogResult = DialogResult.None;
            }
            else if (Int32.TryParse(ProductForm_StockPrice.Text, out number) == false)
            {
                MessageBox.Show("仕入価格に数字を入力してください");
                DialogResult = DialogResult.None;
            }

            else if (DialogResult != DialogResult.Cancel)
            {
                DialogResult res = MessageBox.Show(ProductForm_Name.Text + " のデータを送信します。よろしいですか", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    DialogResult = DialogResult.None;
            }
        }
    }
    }
