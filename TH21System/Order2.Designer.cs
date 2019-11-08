namespace TH21System
{
    partial class OrderMan2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderMan2));
            this.head = new System.Windows.Forms.Panel();
            this.orderlabel = new System.Windows.Forms.Label();
            this.logopic = new System.Windows.Forms.PictureBox();
            this.Order_SearchBox = new System.Windows.Forms.TextBox();
            this.Order_CancelButton = new System.Windows.Forms.Button();
            this.Order_ReturnButton = new System.Windows.Forms.Button();
            this.Order_List = new System.Windows.Forms.DataGridView();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.Order_ConfirmButton = new System.Windows.Forms.Button();
            this.Order_SentButton = new System.Windows.Forms.Button();
            this.Order_LateButton = new System.Windows.Forms.Button();
            this.Order_CompleteButton = new System.Windows.Forms.Button();
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
            this.Order_SearchBox.Location = new System.Drawing.Point(631, 107);
            this.Order_SearchBox.Name = "Order_SearchBox";
            this.Order_SearchBox.Size = new System.Drawing.Size(240, 31);
            this.Order_SearchBox.TabIndex = 4;
            this.Order_SearchBox.Text = "検索";
            this.Order_SearchBox.Click += new System.EventHandler(this.Order_SearchBox_Click);
            this.Order_SearchBox.TextChanged += new System.EventHandler(this.Order_SearchBox_TextChanged);
            // 
            // Order_CancelButton
            // 
            this.Order_CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Order_CancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Order_CancelButton.FlatAppearance.BorderSize = 0;
            this.Order_CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order_CancelButton.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Order_CancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Order_CancelButton.Location = new System.Drawing.Point(910, 459);
            this.Order_CancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.Order_CancelButton.Name = "Order_CancelButton";
            this.Order_CancelButton.Size = new System.Drawing.Size(135, 46);
            this.Order_CancelButton.TabIndex = 2;
            this.Order_CancelButton.Text = "キャンセル";
            this.Order_CancelButton.UseVisualStyleBackColor = false;
            this.Order_CancelButton.Click += new System.EventHandler(this.Order_CancelButton_Click);
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
            this.Order_List.Location = new System.Drawing.Point(12, 153);
            this.Order_List.Margin = new System.Windows.Forms.Padding(0);
            this.Order_List.MultiSelect = false;
            this.Order_List.Name = "Order_List";
            this.Order_List.RowHeadersVisible = false;
            this.Order_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Order_List.Size = new System.Drawing.Size(859, 478);
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
            this.SearchCombo.Location = new System.Drawing.Point(504, 107);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(121, 32);
            this.SearchCombo.TabIndex = 4;
            this.SearchCombo.Text = "ID";
            // 
            // Order_ConfirmButton
            // 
            this.Order_ConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Order_ConfirmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Order_ConfirmButton.FlatAppearance.BorderSize = 0;
            this.Order_ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order_ConfirmButton.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Order_ConfirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Order_ConfirmButton.Location = new System.Drawing.Point(910, 107);
            this.Order_ConfirmButton.Margin = new System.Windows.Forms.Padding(0);
            this.Order_ConfirmButton.Name = "Order_ConfirmButton";
            this.Order_ConfirmButton.Size = new System.Drawing.Size(135, 46);
            this.Order_ConfirmButton.TabIndex = 7;
            this.Order_ConfirmButton.Text = "確認";
            this.Order_ConfirmButton.UseVisualStyleBackColor = false;
            this.Order_ConfirmButton.Click += new System.EventHandler(this.Order_ConfirmButton_Click);
            // 
            // Order_SentButton
            // 
            this.Order_SentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Order_SentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Order_SentButton.FlatAppearance.BorderSize = 0;
            this.Order_SentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order_SentButton.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Order_SentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Order_SentButton.Location = new System.Drawing.Point(910, 195);
            this.Order_SentButton.Margin = new System.Windows.Forms.Padding(0);
            this.Order_SentButton.Name = "Order_SentButton";
            this.Order_SentButton.Size = new System.Drawing.Size(135, 46);
            this.Order_SentButton.TabIndex = 8;
            this.Order_SentButton.Text = "配達";
            this.Order_SentButton.UseVisualStyleBackColor = false;
            this.Order_SentButton.Click += new System.EventHandler(this.Order_SentButton_Click);
            // 
            // Order_LateButton
            // 
            this.Order_LateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Order_LateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Order_LateButton.FlatAppearance.BorderSize = 0;
            this.Order_LateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order_LateButton.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Order_LateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Order_LateButton.Location = new System.Drawing.Point(910, 371);
            this.Order_LateButton.Margin = new System.Windows.Forms.Padding(0);
            this.Order_LateButton.Name = "Order_LateButton";
            this.Order_LateButton.Size = new System.Drawing.Size(135, 46);
            this.Order_LateButton.TabIndex = 9;
            this.Order_LateButton.Text = "遅延";
            this.Order_LateButton.UseVisualStyleBackColor = false;
            this.Order_LateButton.Click += new System.EventHandler(this.Order_LateButton_Click);
            // 
            // Order_CompleteButton
            // 
            this.Order_CompleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Order_CompleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Order_CompleteButton.FlatAppearance.BorderSize = 0;
            this.Order_CompleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order_CompleteButton.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Order_CompleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Order_CompleteButton.Location = new System.Drawing.Point(910, 283);
            this.Order_CompleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.Order_CompleteButton.Name = "Order_CompleteButton";
            this.Order_CompleteButton.Size = new System.Drawing.Size(135, 46);
            this.Order_CompleteButton.TabIndex = 11;
            this.Order_CompleteButton.Text = "受領";
            this.Order_CompleteButton.UseVisualStyleBackColor = false;
            this.Order_CompleteButton.Click += new System.EventHandler(this.Order_CompleteButton_Click);
            // 
            // OrderMan2
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.Order_CompleteButton);
            this.Controls.Add(this.Order_LateButton);
            this.Controls.Add(this.Order_SentButton);
            this.Controls.Add(this.Order_ConfirmButton);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.Order_List);
            this.Controls.Add(this.Order_ReturnButton);
            this.Controls.Add(this.Order_CancelButton);
            this.Controls.Add(this.Order_SearchBox);
            this.Controls.Add(this.head);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderMan2";
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
        private System.Windows.Forms.Button Order_CancelButton;
        private System.Windows.Forms.Button Order_ReturnButton;
        private System.Windows.Forms.DataGridView Order_List;
        private System.Windows.Forms.ComboBox SearchCombo;
        private System.Windows.Forms.Button Order_ConfirmButton;
        private System.Windows.Forms.Button Order_SentButton;
        private System.Windows.Forms.Button Order_LateButton;
        private System.Windows.Forms.Button Order_CompleteButton;
    }
}

