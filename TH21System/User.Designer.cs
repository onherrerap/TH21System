namespace TH21System
{
    partial class UserMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMan));
            this.head = new System.Windows.Forms.Panel();
            this.userlabel = new System.Windows.Forms.Label();
            this.logopic = new System.Windows.Forms.PictureBox();
            this.User_SearchBox = new System.Windows.Forms.TextBox();
            this.User_AddButton = new System.Windows.Forms.Button();
            this.User_UpdateButton = new System.Windows.Forms.Button();
            this.User_DeleteButton = new System.Windows.Forms.Button();
            this.User_ReturnButton = new System.Windows.Forms.Button();
            this.User_List = new System.Windows.Forms.DataGridView();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_List)).BeginInit();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.head.Controls.Add(this.userlabel);
            this.head.Controls.Add(this.logopic);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1080, 90);
            this.head.TabIndex = 6;
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.userlabel.Location = new System.Drawing.Point(476, 18);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(251, 46);
            this.userlabel.TabIndex = 1;
            this.userlabel.Text = "ユーザー管理";
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
            // User_SearchBox
            // 
            this.User_SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.User_SearchBox.BackColor = System.Drawing.Color.White;
            this.User_SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User_SearchBox.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.User_SearchBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.User_SearchBox.Location = new System.Drawing.Point(828, 111);
            this.User_SearchBox.Name = "User_SearchBox";
            this.User_SearchBox.Size = new System.Drawing.Size(240, 31);
            this.User_SearchBox.TabIndex = 4;
            this.User_SearchBox.Text = "検索";
            this.User_SearchBox.Click += new System.EventHandler(this.User_SearchBox_Click);
            this.User_SearchBox.TextChanged += new System.EventHandler(this.User_SearchBox_TextChanged);
            // 
            // User_AddButton
            // 
            this.User_AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.User_AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.User_AddButton.FlatAppearance.BorderSize = 0;
            this.User_AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_AddButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.User_AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.User_AddButton.Location = new System.Drawing.Point(231, 551);
            this.User_AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.User_AddButton.Name = "User_AddButton";
            this.User_AddButton.Size = new System.Drawing.Size(180, 80);
            this.User_AddButton.TabIndex = 1;
            this.User_AddButton.Text = "追加";
            this.User_AddButton.UseVisualStyleBackColor = false;
            this.User_AddButton.Click += new System.EventHandler(this.User_AddButton_Click);
            // 
            // User_UpdateButton
            // 
            this.User_UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.User_UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.User_UpdateButton.FlatAppearance.BorderSize = 0;
            this.User_UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_UpdateButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.User_UpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.User_UpdateButton.Location = new System.Drawing.Point(426, 551);
            this.User_UpdateButton.Margin = new System.Windows.Forms.Padding(0);
            this.User_UpdateButton.Name = "User_UpdateButton";
            this.User_UpdateButton.Size = new System.Drawing.Size(180, 80);
            this.User_UpdateButton.TabIndex = 2;
            this.User_UpdateButton.Text = "更新";
            this.User_UpdateButton.UseVisualStyleBackColor = false;
            this.User_UpdateButton.Click += new System.EventHandler(this.User_UpdateButton_Click);
            // 
            // User_DeleteButton
            // 
            this.User_DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.User_DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.User_DeleteButton.FlatAppearance.BorderSize = 0;
            this.User_DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_DeleteButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.User_DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.User_DeleteButton.Location = new System.Drawing.Point(621, 551);
            this.User_DeleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.User_DeleteButton.Name = "User_DeleteButton";
            this.User_DeleteButton.Size = new System.Drawing.Size(180, 80);
            this.User_DeleteButton.TabIndex = 3;
            this.User_DeleteButton.Text = "削除";
            this.User_DeleteButton.UseVisualStyleBackColor = false;
            this.User_DeleteButton.Click += new System.EventHandler(this.User_DeleteButton_Click);
            // 
            // User_ReturnButton
            // 
            this.User_ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.User_ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.User_ReturnButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.User_ReturnButton.FlatAppearance.BorderSize = 0;
            this.User_ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_ReturnButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.User_ReturnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.User_ReturnButton.Location = new System.Drawing.Point(888, 551);
            this.User_ReturnButton.Margin = new System.Windows.Forms.Padding(0);
            this.User_ReturnButton.Name = "User_ReturnButton";
            this.User_ReturnButton.Size = new System.Drawing.Size(180, 80);
            this.User_ReturnButton.TabIndex = 5;
            this.User_ReturnButton.Text = "戻る";
            this.User_ReturnButton.UseVisualStyleBackColor = false;
            this.User_ReturnButton.Click += new System.EventHandler(this.User_ReturnButton_Click);
            // 
            // User_List
            // 
            this.User_List.AllowUserToAddRows = false;
            this.User_List.AllowUserToDeleteRows = false;
            this.User_List.AllowUserToResizeColumns = false;
            this.User_List.AllowUserToResizeRows = false;
            this.User_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.User_List.BackgroundColor = System.Drawing.Color.White;
            this.User_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.User_List.Location = new System.Drawing.Point(12, 160);
            this.User_List.Margin = new System.Windows.Forms.Padding(0);
            this.User_List.MultiSelect = false;
            this.User_List.Name = "User_List";
            this.User_List.RowHeadersVisible = false;
            this.User_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.User_List.Size = new System.Drawing.Size(1056, 388);
            this.User_List.TabIndex = 0;
            // 
            // SearchCombo
            // 
            this.SearchCombo.AllowDrop = true;
            this.SearchCombo.BackColor = System.Drawing.Color.White;
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Items.AddRange(new object[] {
            "ID",
            "氏名",
            "役職"});
            this.SearchCombo.Location = new System.Drawing.Point(701, 111);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(121, 32);
            this.SearchCombo.TabIndex = 4;
            this.SearchCombo.Text = "ID";
            // 
            // UserMan
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.User_List);
            this.Controls.Add(this.User_ReturnButton);
            this.Controls.Add(this.User_DeleteButton);
            this.Controls.Add(this.User_UpdateButton);
            this.Controls.Add(this.User_AddButton);
            this.Controls.Add(this.User_SearchBox);
            this.Controls.Add(this.head);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserMan_Load);
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logopic;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.TextBox User_SearchBox;
        private System.Windows.Forms.Button User_AddButton;
        private System.Windows.Forms.Button User_UpdateButton;
        private System.Windows.Forms.Button User_DeleteButton;
        private System.Windows.Forms.Button User_ReturnButton;
        private System.Windows.Forms.DataGridView User_List;
        private System.Windows.Forms.ComboBox SearchCombo;
    }
}

