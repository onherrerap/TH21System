namespace TH21System
{
    partial class ProductMan
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductMan));
            this.head = new System.Windows.Forms.Panel();
            this.productlabel = new System.Windows.Forms.Label();
            this.logopic = new System.Windows.Forms.PictureBox();
            this.Product_SearchBox = new System.Windows.Forms.TextBox();
            this.Product_AddButton = new System.Windows.Forms.Button();
            this.Product_UpdateButton = new System.Windows.Forms.Button();
            this.Product_DeleteButton = new System.Windows.Forms.Button();
            this.Product_ReturnButton = new System.Windows.Forms.Button();
            this.Product_List = new System.Windows.Forms.DataGridView();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product_List)).BeginInit();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.head.Controls.Add(this.productlabel);
            this.head.Controls.Add(this.logopic);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1080, 90);
            this.head.TabIndex = 6;
            // 
            // productlabel
            // 
            this.productlabel.AutoSize = true;
            this.productlabel.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productlabel.Location = new System.Drawing.Point(494, 25);
            this.productlabel.Name = "productlabel";
            this.productlabel.Size = new System.Drawing.Size(180, 46);
            this.productlabel.TabIndex = 1;
            this.productlabel.Text = "商品管理";
            // 
            // logopic
            // 
            this.logopic.Image = ((System.Drawing.Image)(resources.GetObject("logopic.Image")));
            this.logopic.Location = new System.Drawing.Point(416, 5);
            this.logopic.Name = "logopic";
            this.logopic.Size = new System.Drawing.Size(72, 80);
            this.logopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logopic.TabIndex = 0;
            this.logopic.TabStop = false;
            // 
            // Product_SearchBox
            // 
            this.Product_SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Product_SearchBox.BackColor = System.Drawing.Color.White;
            this.Product_SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Product_SearchBox.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Product_SearchBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Product_SearchBox.Location = new System.Drawing.Point(828, 111);
            this.Product_SearchBox.Name = "Product_SearchBox";
            this.Product_SearchBox.Size = new System.Drawing.Size(240, 31);
            this.Product_SearchBox.TabIndex = 4;
            this.Product_SearchBox.Text = "検索";
            this.Product_SearchBox.Click += new System.EventHandler(this.Product_SearchBox_Click);
            this.Product_SearchBox.TextChanged += new System.EventHandler(this.Product_SearchBox_TextChanged);
            // 
            // Product_AddButton
            // 
            this.Product_AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Product_AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Product_AddButton.FlatAppearance.BorderSize = 0;
            this.Product_AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product_AddButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.Product_AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Product_AddButton.Location = new System.Drawing.Point(231, 551);
            this.Product_AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.Product_AddButton.Name = "Product_AddButton";
            this.Product_AddButton.Size = new System.Drawing.Size(180, 80);
            this.Product_AddButton.TabIndex = 1;
            this.Product_AddButton.Text = "追加";
            this.Product_AddButton.UseVisualStyleBackColor = false;
            this.Product_AddButton.Click += new System.EventHandler(this.Product_AddButton_Click);
            // 
            // Product_UpdateButton
            // 
            this.Product_UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Product_UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Product_UpdateButton.FlatAppearance.BorderSize = 0;
            this.Product_UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product_UpdateButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.Product_UpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Product_UpdateButton.Location = new System.Drawing.Point(426, 551);
            this.Product_UpdateButton.Margin = new System.Windows.Forms.Padding(0);
            this.Product_UpdateButton.Name = "Product_UpdateButton";
            this.Product_UpdateButton.Size = new System.Drawing.Size(180, 80);
            this.Product_UpdateButton.TabIndex = 2;
            this.Product_UpdateButton.Text = "更新";
            this.Product_UpdateButton.UseVisualStyleBackColor = false;
            this.Product_UpdateButton.Click += new System.EventHandler(this.Product_UpdateButton_Click);
            // 
            // Product_DeleteButton
            // 
            this.Product_DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Product_DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Product_DeleteButton.FlatAppearance.BorderSize = 0;
            this.Product_DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product_DeleteButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.Product_DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Product_DeleteButton.Location = new System.Drawing.Point(621, 551);
            this.Product_DeleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.Product_DeleteButton.Name = "Product_DeleteButton";
            this.Product_DeleteButton.Size = new System.Drawing.Size(180, 80);
            this.Product_DeleteButton.TabIndex = 3;
            this.Product_DeleteButton.Text = "削除";
            this.Product_DeleteButton.UseVisualStyleBackColor = false;
            this.Product_DeleteButton.Click += new System.EventHandler(this.Product_DeleteButton_Click);
            // 
            // Product_ReturnButton
            // 
            this.Product_ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Product_ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Product_ReturnButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Product_ReturnButton.FlatAppearance.BorderSize = 0;
            this.Product_ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product_ReturnButton.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Product_ReturnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Product_ReturnButton.Location = new System.Drawing.Point(888, 551);
            this.Product_ReturnButton.Margin = new System.Windows.Forms.Padding(0);
            this.Product_ReturnButton.Name = "Product_ReturnButton";
            this.Product_ReturnButton.Size = new System.Drawing.Size(180, 80);
            this.Product_ReturnButton.TabIndex = 5;
            this.Product_ReturnButton.Text = "戻る";
            this.Product_ReturnButton.UseVisualStyleBackColor = false;
            this.Product_ReturnButton.Click += new System.EventHandler(this.Product_ReturnButton_Click);
            // 
            // Product_List
            // 
            this.Product_List.AllowUserToAddRows = false;
            this.Product_List.AllowUserToDeleteRows = false;
            this.Product_List.AllowUserToResizeColumns = false;
            this.Product_List.AllowUserToResizeRows = false;
            this.Product_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Product_List.BackgroundColor = System.Drawing.Color.White;
            this.Product_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Product_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Product_List.Location = new System.Drawing.Point(12, 160);
            this.Product_List.Margin = new System.Windows.Forms.Padding(0);
            this.Product_List.MultiSelect = false;
            this.Product_List.Name = "Product_List";
            this.Product_List.RowHeadersVisible = false;
            this.Product_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Product_List.Size = new System.Drawing.Size(1056, 388);
            this.Product_List.TabIndex = 0;
            // 
            // SearchCombo
            // 
            this.SearchCombo.AllowDrop = true;
            this.SearchCombo.BackColor = System.Drawing.Color.White;
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Items.AddRange(new object[] {
            "ID",
            "ブランド名",
            "商品名",
            "分類"});
            this.SearchCombo.Location = new System.Drawing.Point(701, 111);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(121, 32);
            this.SearchCombo.TabIndex = 4;
            this.SearchCombo.Text = "ID";
            // 
            // ProductMan
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.Product_List);
            this.Controls.Add(this.Product_ReturnButton);
            this.Controls.Add(this.Product_DeleteButton);
            this.Controls.Add(this.Product_UpdateButton);
            this.Controls.Add(this.Product_AddButton);
            this.Controls.Add(this.Product_SearchBox);
            this.Controls.Add(this.head);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ProductMan_Load);
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logopic;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Label productlabel;
        private System.Windows.Forms.TextBox Product_SearchBox;
        private System.Windows.Forms.Button Product_AddButton;
        private System.Windows.Forms.Button Product_UpdateButton;
        private System.Windows.Forms.Button Product_DeleteButton;
        private System.Windows.Forms.Button Product_ReturnButton;
        private System.Windows.Forms.DataGridView Product_List;
        private System.Windows.Forms.ComboBox SearchCombo;
    }
}

