namespace TH21System
{
    partial class OrderForm_Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm_Product));
            this.head = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OrderForm_Cancel = new System.Windows.Forms.Button();
            this.OrderForm_Send = new System.Windows.Forms.Button();
            this.Order_ProductList = new System.Windows.Forms.DataGridView();
            this.Order_ProductID = new System.Windows.Forms.TextBox();
            this.Order_ProductForm_L0 = new System.Windows.Forms.Label();
            this.Order_ProductBrand = new System.Windows.Forms.TextBox();
            this.Order_ProductForm_L1 = new System.Windows.Forms.Label();
            this.Order_ProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Order_ProductCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Order_ProductPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_ProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.head.Controls.Add(this.pictureBox1);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1080, 90);
            this.head.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(517, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OrderForm_Cancel
            // 
            this.OrderForm_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.OrderForm_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OrderForm_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OrderForm_Cancel.FlatAppearance.BorderSize = 0;
            this.OrderForm_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderForm_Cancel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.OrderForm_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.OrderForm_Cancel.Location = new System.Drawing.Point(333, 535);
            this.OrderForm_Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.OrderForm_Cancel.Name = "OrderForm_Cancel";
            this.OrderForm_Cancel.Size = new System.Drawing.Size(180, 80);
            this.OrderForm_Cancel.TabIndex = 6;
            this.OrderForm_Cancel.Text = "戻る";
            this.OrderForm_Cancel.UseVisualStyleBackColor = false;
            // 
            // OrderForm_Send
            // 
            this.OrderForm_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.OrderForm_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OrderForm_Send.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OrderForm_Send.FlatAppearance.BorderSize = 0;
            this.OrderForm_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderForm_Send.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.OrderForm_Send.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.OrderForm_Send.Location = new System.Drawing.Point(67, 535);
            this.OrderForm_Send.Margin = new System.Windows.Forms.Padding(0);
            this.OrderForm_Send.Name = "OrderForm_Send";
            this.OrderForm_Send.Size = new System.Drawing.Size(180, 80);
            this.OrderForm_Send.TabIndex = 5;
            this.OrderForm_Send.Text = "追加";
            this.OrderForm_Send.UseVisualStyleBackColor = false;
            // 
            // Order_ProductList
            // 
            this.Order_ProductList.AllowUserToAddRows = false;
            this.Order_ProductList.AllowUserToDeleteRows = false;
            this.Order_ProductList.AllowUserToResizeColumns = false;
            this.Order_ProductList.AllowUserToResizeRows = false;
            this.Order_ProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Order_ProductList.BackgroundColor = System.Drawing.Color.White;
            this.Order_ProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Order_ProductList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Order_ProductList.Location = new System.Drawing.Point(552, 95);
            this.Order_ProductList.Margin = new System.Windows.Forms.Padding(0);
            this.Order_ProductList.MultiSelect = false;
            this.Order_ProductList.Name = "Order_ProductList";
            this.Order_ProductList.RowHeadersVisible = false;
            this.Order_ProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Order_ProductList.Size = new System.Drawing.Size(519, 520);
            this.Order_ProductList.TabIndex = 0;
            this.Order_ProductList.Click += new System.EventHandler(this.Order_ProductList_Click);
            // 
            // Order_ProductID
            // 
            this.Order_ProductID.Enabled = false;
            this.Order_ProductID.Location = new System.Drawing.Point(160, 148);
            this.Order_ProductID.Name = "Order_ProductID";
            this.Order_ProductID.Size = new System.Drawing.Size(112, 31);
            this.Order_ProductID.TabIndex = 19;
            // 
            // Order_ProductForm_L0
            // 
            this.Order_ProductForm_L0.AutoSize = true;
            this.Order_ProductForm_L0.Location = new System.Drawing.Point(113, 151);
            this.Order_ProductForm_L0.Name = "Order_ProductForm_L0";
            this.Order_ProductForm_L0.Size = new System.Drawing.Size(33, 24);
            this.Order_ProductForm_L0.TabIndex = 18;
            this.Order_ProductForm_L0.Text = "ID";
            // 
            // Order_ProductBrand
            // 
            this.Order_ProductBrand.Enabled = false;
            this.Order_ProductBrand.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Order_ProductBrand.Location = new System.Drawing.Point(160, 253);
            this.Order_ProductBrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Order_ProductBrand.Name = "Order_ProductBrand";
            this.Order_ProductBrand.Size = new System.Drawing.Size(313, 34);
            this.Order_ProductBrand.TabIndex = 16;
            // 
            // Order_ProductForm_L1
            // 
            this.Order_ProductForm_L1.AutoSize = true;
            this.Order_ProductForm_L1.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Order_ProductForm_L1.Location = new System.Drawing.Point(37, 255);
            this.Order_ProductForm_L1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Order_ProductForm_L1.Name = "Order_ProductForm_L1";
            this.Order_ProductForm_L1.Size = new System.Drawing.Size(115, 28);
            this.Order_ProductForm_L1.TabIndex = 17;
            this.Order_ProductForm_L1.Text = "ブランド名";
            // 
            // Order_ProductName
            // 
            this.Order_ProductName.Enabled = false;
            this.Order_ProductName.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Order_ProductName.Location = new System.Drawing.Point(160, 307);
            this.Order_ProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Order_ProductName.Name = "Order_ProductName";
            this.Order_ProductName.Size = new System.Drawing.Size(313, 34);
            this.Order_ProductName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(68, 309);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "商品名";
            // 
            // Order_ProductCategory
            // 
            this.Order_ProductCategory.Enabled = false;
            this.Order_ProductCategory.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Order_ProductCategory.Location = new System.Drawing.Point(160, 199);
            this.Order_ProductCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Order_ProductCategory.Name = "Order_ProductCategory";
            this.Order_ProductCategory.Size = new System.Drawing.Size(313, 34);
            this.Order_ProductCategory.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(86, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "分類";
            // 
            // Order_ProductPrice
            // 
            this.Order_ProductPrice.Enabled = false;
            this.Order_ProductPrice.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Order_ProductPrice.Location = new System.Drawing.Point(160, 363);
            this.Order_ProductPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Order_ProductPrice.Name = "Order_ProductPrice";
            this.Order_ProductPrice.Size = new System.Drawing.Size(313, 34);
            this.Order_ProductPrice.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(68, 365);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "単価";
            // 
            // OrderForm_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.Order_ProductPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Order_ProductCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Order_ProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Order_ProductID);
            this.Controls.Add(this.Order_ProductForm_L0);
            this.Controls.Add(this.Order_ProductBrand);
            this.Controls.Add(this.Order_ProductForm_L1);
            this.Controls.Add(this.Order_ProductList);
            this.Controls.Add(this.OrderForm_Cancel);
            this.Controls.Add(this.OrderForm_Send);
            this.Controls.Add(this.head);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderForm_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Product_Load);
            this.head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_ProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Button OrderForm_Cancel;
        public System.Windows.Forms.Button OrderForm_Send;
        public System.Windows.Forms.DataGridView Order_ProductList;
        public System.Windows.Forms.TextBox Order_ProductID;
        private System.Windows.Forms.Label Order_ProductForm_L0;
        public System.Windows.Forms.TextBox Order_ProductBrand;
        private System.Windows.Forms.Label Order_ProductForm_L1;
        public System.Windows.Forms.TextBox Order_ProductName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Order_ProductCategory;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Order_ProductPrice;
        private System.Windows.Forms.Label label3;
    }
}