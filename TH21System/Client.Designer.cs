namespace TH21System
{
    partial class ClientMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientMan));
            this.head = new System.Windows.Forms.Panel();
            this.clientlabel = new System.Windows.Forms.Label();
            this.logopic = new System.Windows.Forms.PictureBox();
            this.Client_SearchBox = new System.Windows.Forms.TextBox();
            this.Client_AddButton = new System.Windows.Forms.Button();
            this.Client_UpdateButton = new System.Windows.Forms.Button();
            this.Client_DeleteButton = new System.Windows.Forms.Button();
            this.Client_ReturnButton = new System.Windows.Forms.Button();
            this.Client_List = new System.Windows.Forms.DataGridView();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Client_List)).BeginInit();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.head.Controls.Add(this.clientlabel);
            this.head.Controls.Add(this.logopic);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1080, 90);
            this.head.TabIndex = 6;
            // 
            // clientlabel
            // 
            this.clientlabel.AutoSize = true;
            this.clientlabel.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clientlabel.Location = new System.Drawing.Point(476, 18);
            this.clientlabel.Name = "clientlabel";
            this.clientlabel.Size = new System.Drawing.Size(180, 46);
            this.clientlabel.TabIndex = 1;
            this.clientlabel.Text = "顧客管理";
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
            // Client_SearchBox
            // 
            this.Client_SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Client_SearchBox.BackColor = System.Drawing.Color.White;
            this.Client_SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Client_SearchBox.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Client_SearchBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Client_SearchBox.Location = new System.Drawing.Point(828, 111);
            this.Client_SearchBox.Name = "Client_SearchBox";
            this.Client_SearchBox.Size = new System.Drawing.Size(240, 31);
            this.Client_SearchBox.TabIndex = 4;
            this.Client_SearchBox.Text = "検索";
            this.Client_SearchBox.Click += new System.EventHandler(this.Client_SearchBox_Click);
            this.Client_SearchBox.TextChanged += new System.EventHandler(this.Client_SearchBox_TextChanged);
            // 
            // Client_AddButton
            // 
            this.Client_AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Client_AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Client_AddButton.FlatAppearance.BorderSize = 0;
            this.Client_AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Client_AddButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.Client_AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Client_AddButton.Location = new System.Drawing.Point(231, 551);
            this.Client_AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.Client_AddButton.Name = "Client_AddButton";
            this.Client_AddButton.Size = new System.Drawing.Size(180, 80);
            this.Client_AddButton.TabIndex = 1;
            this.Client_AddButton.Text = "追加";
            this.Client_AddButton.UseVisualStyleBackColor = false;
            this.Client_AddButton.Click += new System.EventHandler(this.Client_AddButton_Click);
            // 
            // Client_UpdateButton
            // 
            this.Client_UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Client_UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Client_UpdateButton.FlatAppearance.BorderSize = 0;
            this.Client_UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Client_UpdateButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.Client_UpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Client_UpdateButton.Location = new System.Drawing.Point(426, 551);
            this.Client_UpdateButton.Margin = new System.Windows.Forms.Padding(0);
            this.Client_UpdateButton.Name = "Client_UpdateButton";
            this.Client_UpdateButton.Size = new System.Drawing.Size(180, 80);
            this.Client_UpdateButton.TabIndex = 2;
            this.Client_UpdateButton.Text = "更新";
            this.Client_UpdateButton.UseVisualStyleBackColor = false;
            this.Client_UpdateButton.Click += new System.EventHandler(this.Client_UpdateButton_Click);
            // 
            // Client_DeleteButton
            // 
            this.Client_DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Client_DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Client_DeleteButton.FlatAppearance.BorderSize = 0;
            this.Client_DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Client_DeleteButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.Client_DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Client_DeleteButton.Location = new System.Drawing.Point(621, 551);
            this.Client_DeleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.Client_DeleteButton.Name = "Client_DeleteButton";
            this.Client_DeleteButton.Size = new System.Drawing.Size(180, 80);
            this.Client_DeleteButton.TabIndex = 3;
            this.Client_DeleteButton.Text = "削除";
            this.Client_DeleteButton.UseVisualStyleBackColor = false;
            this.Client_DeleteButton.Click += new System.EventHandler(this.Client_DeleteButton_Click);
            // 
            // Client_ReturnButton
            // 
            this.Client_ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Client_ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Client_ReturnButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Client_ReturnButton.FlatAppearance.BorderSize = 0;
            this.Client_ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Client_ReturnButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.Client_ReturnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Client_ReturnButton.Location = new System.Drawing.Point(888, 551);
            this.Client_ReturnButton.Margin = new System.Windows.Forms.Padding(0);
            this.Client_ReturnButton.Name = "Client_ReturnButton";
            this.Client_ReturnButton.Size = new System.Drawing.Size(180, 80);
            this.Client_ReturnButton.TabIndex = 5;
            this.Client_ReturnButton.Text = "戻る";
            this.Client_ReturnButton.UseVisualStyleBackColor = false;
            this.Client_ReturnButton.Click += new System.EventHandler(this.Client_ReturnButton_Click);
            // 
            // Client_List
            // 
            this.Client_List.AllowUserToAddRows = false;
            this.Client_List.AllowUserToDeleteRows = false;
            this.Client_List.AllowUserToResizeColumns = false;
            this.Client_List.AllowUserToResizeRows = false;
            this.Client_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Client_List.BackgroundColor = System.Drawing.Color.White;
            this.Client_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Client_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Client_List.Location = new System.Drawing.Point(15, 145);
            this.Client_List.Margin = new System.Windows.Forms.Padding(0);
            this.Client_List.MultiSelect = false;
            this.Client_List.Name = "Client_List";
            this.Client_List.RowHeadersVisible = false;
            this.Client_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Client_List.Size = new System.Drawing.Size(1056, 388);
            this.Client_List.TabIndex = 7;
            // 
            // SearchCombo
            // 
            this.SearchCombo.AllowDrop = true;
            this.SearchCombo.BackColor = System.Drawing.Color.White;
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Items.AddRange(new object[] {
            "ID",
            "顧客名"});
            this.SearchCombo.Location = new System.Drawing.Point(701, 111);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(121, 32);
            this.SearchCombo.TabIndex = 4;
            this.SearchCombo.Text = "ID";
            // 
            // ClientMan
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.Client_List);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.Client_ReturnButton);
            this.Controls.Add(this.Client_DeleteButton);
            this.Controls.Add(this.Client_UpdateButton);
            this.Controls.Add(this.Client_AddButton);
            this.Controls.Add(this.Client_SearchBox);
            this.Controls.Add(this.head);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ClientMan_Load);
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Client_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logopic;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Label clientlabel;
        private System.Windows.Forms.TextBox Client_SearchBox;
        private System.Windows.Forms.Button Client_AddButton;
        private System.Windows.Forms.Button Client_UpdateButton;
        private System.Windows.Forms.Button Client_DeleteButton;
        private System.Windows.Forms.Button Client_ReturnButton;
        private System.Windows.Forms.ComboBox SearchCombo;
        private System.Windows.Forms.DataGridView Client_List;
    }
}

