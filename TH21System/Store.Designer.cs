namespace TH21System
{
    partial class StoreMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreMan));
            this.head = new System.Windows.Forms.Panel();
            this.storelabel = new System.Windows.Forms.Label();
            this.logopic = new System.Windows.Forms.PictureBox();
            this.Store_SearchBox = new System.Windows.Forms.TextBox();
            this.Store_StoreNewButton = new System.Windows.Forms.Button();
            this.Store_ExistingButton = new System.Windows.Forms.Button();
            this.Store_DeleteButton = new System.Windows.Forms.Button();
            this.Store_ReturnButton = new System.Windows.Forms.Button();
            this.Store_List = new System.Windows.Forms.DataGridView();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Store_List)).BeginInit();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.head.Controls.Add(this.storelabel);
            this.head.Controls.Add(this.logopic);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1080, 90);
            this.head.TabIndex = 6;
            // 
            // storelabel
            // 
            this.storelabel.AutoSize = true;
            this.storelabel.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.storelabel.Location = new System.Drawing.Point(476, 18);
            this.storelabel.Name = "storelabel";
            this.storelabel.Size = new System.Drawing.Size(180, 46);
            this.storelabel.TabIndex = 1;
            this.storelabel.Text = "在庫管理";
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
            // Store_SearchBox
            // 
            this.Store_SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Store_SearchBox.BackColor = System.Drawing.Color.White;
            this.Store_SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Store_SearchBox.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Store_SearchBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Store_SearchBox.Location = new System.Drawing.Point(828, 111);
            this.Store_SearchBox.Name = "Store_SearchBox";
            this.Store_SearchBox.Size = new System.Drawing.Size(240, 31);
            this.Store_SearchBox.TabIndex = 4;
            this.Store_SearchBox.Text = "検索";
            this.Store_SearchBox.Click += new System.EventHandler(this.Store_SearchBox_Click);
            this.Store_SearchBox.TextChanged += new System.EventHandler(this.Store_SearchBox_TextChanged);
            // 
            // Store_StoreNewButton
            // 
            this.Store_StoreNewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Store_StoreNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Store_StoreNewButton.FlatAppearance.BorderSize = 0;
            this.Store_StoreNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Store_StoreNewButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.Store_StoreNewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Store_StoreNewButton.Location = new System.Drawing.Point(231, 551);
            this.Store_StoreNewButton.Margin = new System.Windows.Forms.Padding(0);
            this.Store_StoreNewButton.Name = "Store_StoreNewButton";
            this.Store_StoreNewButton.Size = new System.Drawing.Size(180, 80);
            this.Store_StoreNewButton.TabIndex = 1;
            this.Store_StoreNewButton.Text = "新商品";
            this.Store_StoreNewButton.UseVisualStyleBackColor = false;
            this.Store_StoreNewButton.Click += new System.EventHandler(this.Store_StoreNewButton_Click);
            // 
            // Store_ExistingButton
            // 
            this.Store_ExistingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Store_ExistingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Store_ExistingButton.FlatAppearance.BorderSize = 0;
            this.Store_ExistingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Store_ExistingButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.Store_ExistingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Store_ExistingButton.Location = new System.Drawing.Point(426, 551);
            this.Store_ExistingButton.Margin = new System.Windows.Forms.Padding(0);
            this.Store_ExistingButton.Name = "Store_ExistingButton";
            this.Store_ExistingButton.Size = new System.Drawing.Size(180, 80);
            this.Store_ExistingButton.TabIndex = 2;
            this.Store_ExistingButton.Text = "現行品";
            this.Store_ExistingButton.UseVisualStyleBackColor = false;
            this.Store_ExistingButton.Click += new System.EventHandler(this.Store_ExistingButton_Click);
            // 
            // Store_DeleteButton
            // 
            this.Store_DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Store_DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Store_DeleteButton.FlatAppearance.BorderSize = 0;
            this.Store_DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Store_DeleteButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.Store_DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Store_DeleteButton.Location = new System.Drawing.Point(621, 551);
            this.Store_DeleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.Store_DeleteButton.Name = "Store_DeleteButton";
            this.Store_DeleteButton.Size = new System.Drawing.Size(180, 80);
            this.Store_DeleteButton.TabIndex = 3;
            this.Store_DeleteButton.Text = "発送";
            this.Store_DeleteButton.UseVisualStyleBackColor = false;
            this.Store_DeleteButton.Click += new System.EventHandler(this.Store_DeleteButton_Click);
            // 
            // Store_ReturnButton
            // 
            this.Store_ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Store_ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Store_ReturnButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Store_ReturnButton.FlatAppearance.BorderSize = 0;
            this.Store_ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Store_ReturnButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.Store_ReturnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Store_ReturnButton.Location = new System.Drawing.Point(888, 551);
            this.Store_ReturnButton.Margin = new System.Windows.Forms.Padding(0);
            this.Store_ReturnButton.Name = "Store_ReturnButton";
            this.Store_ReturnButton.Size = new System.Drawing.Size(180, 80);
            this.Store_ReturnButton.TabIndex = 5;
            this.Store_ReturnButton.Text = "戻る";
            this.Store_ReturnButton.UseVisualStyleBackColor = false;
            this.Store_ReturnButton.Click += new System.EventHandler(this.Store_ReturnButton_Click);
            // 
            // Store_List
            // 
            this.Store_List.AllowUserToAddRows = false;
            this.Store_List.AllowUserToDeleteRows = false;
            this.Store_List.AllowUserToResizeColumns = false;
            this.Store_List.AllowUserToResizeRows = false;
            this.Store_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Store_List.BackgroundColor = System.Drawing.Color.White;
            this.Store_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Store_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Store_List.Location = new System.Drawing.Point(12, 160);
            this.Store_List.Margin = new System.Windows.Forms.Padding(0);
            this.Store_List.MultiSelect = false;
            this.Store_List.Name = "Store_List";
            this.Store_List.RowHeadersVisible = false;
            this.Store_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Store_List.Size = new System.Drawing.Size(1056, 388);
            this.Store_List.TabIndex = 0;
            // 
            // SearchCombo
            // 
            this.SearchCombo.AllowDrop = true;
            this.SearchCombo.BackColor = System.Drawing.Color.White;
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Items.AddRange(new object[] {
            "ID",
            "商品ID",
            "最終入庫日"});
            this.SearchCombo.Location = new System.Drawing.Point(701, 111);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(121, 32);
            this.SearchCombo.TabIndex = 4;
            this.SearchCombo.Text = "ID";
            // 
            // StoreMan
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.Store_List);
            this.Controls.Add(this.Store_ReturnButton);
            this.Controls.Add(this.Store_DeleteButton);
            this.Controls.Add(this.Store_ExistingButton);
            this.Controls.Add(this.Store_StoreNewButton);
            this.Controls.Add(this.Store_SearchBox);
            this.Controls.Add(this.head);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StoreMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StoreMan_Load);
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Store_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logopic;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Label storelabel;
        private System.Windows.Forms.TextBox Store_SearchBox;
        private System.Windows.Forms.Button Store_StoreNewButton;
        private System.Windows.Forms.Button Store_ExistingButton;
        private System.Windows.Forms.Button Store_DeleteButton;
        private System.Windows.Forms.Button Store_ReturnButton;
        private System.Windows.Forms.DataGridView Store_List;
        private System.Windows.Forms.ComboBox SearchCombo;
    }
}

