namespace TH21System
{
    partial class OrderMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderMan));
            this.head = new System.Windows.Forms.Panel();
            this.orderlabel = new System.Windows.Forms.Label();
            this.logopic = new System.Windows.Forms.PictureBox();
            this.Order_SearchBox = new System.Windows.Forms.TextBox();
            this.Order_AddButton = new System.Windows.Forms.Button();
            this.Order_CancelButton = new System.Windows.Forms.Button();
            this.Order_ReturnButton = new System.Windows.Forms.Button();
            this.Order_List = new System.Windows.Forms.DataGridView();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_List)).BeginInit();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.head.Controls.Add(this.orderlabel);
            this.head.Controls.Add(this.logopic);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1080, 90);
            this.head.TabIndex = 6;
            // 
            // orderlabel
            // 
            this.orderlabel.AutoSize = true;
            this.orderlabel.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.orderlabel.Location = new System.Drawing.Point(476, 18);
            this.orderlabel.Name = "orderlabel";
            this.orderlabel.Size = new System.Drawing.Size(180, 46);
            this.orderlabel.TabIndex = 1;
            this.orderlabel.Text = "受注管理";
            // 
            // logopic
            // 
            this.logopic.Image = ((System.Drawing.Image)(resources.GetObject("logopic.Image")));
            this.logopic.Location = new System.Drawing.Point(398, 5);
            this.logopic.Name = "logopic";
            this.logopic.Size = new System.Drawing.Size(72, 80);
            this.logopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logopic.TabIndex = 0;
            this.logopic.TabStop = false;
            // 
            // Order_SearchBox
            // 
            this.Order_SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Order_SearchBox.BackColor = System.Drawing.Color.White;
            this.Order_SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Order_SearchBox.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Order_SearchBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Order_SearchBox.Location = new System.Drawing.Point(828, 111);
            this.Order_SearchBox.Name = "Order_SearchBox";
            this.Order_SearchBox.Size = new System.Drawing.Size(240, 31);
            this.Order_SearchBox.TabIndex = 4;
            this.Order_SearchBox.Text = "検索";
            this.Order_SearchBox.Click += new System.EventHandler(this.Order_SearchBox_Click);
            this.Order_SearchBox.TextChanged += new System.EventHandler(this.Order_SearchBox_TextChanged);
            // 
            // Order_AddButton
            // 
            this.Order_AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Order_AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Order_AddButton.FlatAppearance.BorderSize = 0;
            this.Order_AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order_AddButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.Order_AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Order_AddButton.Location = new System.Drawing.Point(431, 551);
            this.Order_AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.Order_AddButton.Name = "Order_AddButton";
            this.Order_AddButton.Size = new System.Drawing.Size(180, 80);
            this.Order_AddButton.TabIndex = 1;
            this.Order_AddButton.Text = "追加";
            this.Order_AddButton.UseVisualStyleBackColor = false;
            this.Order_AddButton.Click += new System.EventHandler(this.Order_AddButton_Click);
            // 
            // Order_CancelButton
            // 
            this.Order_CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Order_CancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Order_CancelButton.FlatAppearance.BorderSize = 0;
            this.Order_CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order_CancelButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.Order_CancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Order_CancelButton.Location = new System.Drawing.Point(638, 551);
            this.Order_CancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.Order_CancelButton.Name = "Order_CancelButton";
            this.Order_CancelButton.Size = new System.Drawing.Size(180, 80);
            this.Order_CancelButton.TabIndex = 2;
            this.Order_CancelButton.Text = "キャンセル";
            this.Order_CancelButton.UseVisualStyleBackColor = false;
            this.Order_CancelButton.Click += new System.EventHandler(this.Order_UpdateButton_Click);
            // 
            // Order_ReturnButton
            // 
            this.Order_ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Order_ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Order_ReturnButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Order_ReturnButton.FlatAppearance.BorderSize = 0;
            this.Order_ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order_ReturnButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.Order_ReturnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Order_ReturnButton.Location = new System.Drawing.Point(888, 551);
            this.Order_ReturnButton.Margin = new System.Windows.Forms.Padding(0);
            this.Order_ReturnButton.Name = "Order_ReturnButton";
            this.Order_ReturnButton.Size = new System.Drawing.Size(180, 80);
            this.Order_ReturnButton.TabIndex = 5;
            this.Order_ReturnButton.Text = "戻る";
            this.Order_ReturnButton.UseVisualStyleBackColor = false;
            this.Order_ReturnButton.Click += new System.EventHandler(this.Order_ReturnButton_Click);
            // 
            // Order_List
            // 
            this.Order_List.AllowUserToAddRows = false;
            this.Order_List.AllowUserToDeleteRows = false;
            this.Order_List.AllowUserToResizeColumns = false;
            this.Order_List.AllowUserToResizeRows = false;
            this.Order_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Order_List.BackgroundColor = System.Drawing.Color.White;
            this.Order_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Order_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Order_List.Location = new System.Drawing.Point(12, 160);
            this.Order_List.Margin = new System.Windows.Forms.Padding(0);
            this.Order_List.MultiSelect = false;
            this.Order_List.Name = "Order_List";
            this.Order_List.RowHeadersVisible = false;
            this.Order_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Order_List.Size = new System.Drawing.Size(1056, 388);
            this.Order_List.TabIndex = 0;
            // 
            // SearchCombo
            // 
            this.SearchCombo.AllowDrop = true;
            this.SearchCombo.BackColor = System.Drawing.Color.White;
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Items.AddRange(new object[] {
            "ID",
            "日付",
            "商品ID",
            "顧客ID",
            "状況"});
            this.SearchCombo.Location = new System.Drawing.Point(701, 111);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(121, 32);
            this.SearchCombo.TabIndex = 4;
            this.SearchCombo.Text = "ID";
            // 
            // OrderMan
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.Order_List);
            this.Controls.Add(this.Order_ReturnButton);
            this.Controls.Add(this.Order_CancelButton);
            this.Controls.Add(this.Order_AddButton);
            this.Controls.Add(this.Order_SearchBox);
            this.Controls.Add(this.head);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OrderMan_Load);
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logopic;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Label orderlabel;
        private System.Windows.Forms.TextBox Order_SearchBox;
        private System.Windows.Forms.Button Order_AddButton;
        private System.Windows.Forms.Button Order_CancelButton;
        private System.Windows.Forms.Button Order_ReturnButton;
        private System.Windows.Forms.DataGridView Order_List;
        private System.Windows.Forms.ComboBox SearchCombo;
    }
}

