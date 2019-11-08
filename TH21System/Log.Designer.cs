namespace TH21System
{
    partial class LogMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogMan));
            this.head = new System.Windows.Forms.Panel();
            this.loglabel = new System.Windows.Forms.Label();
            this.logopic = new System.Windows.Forms.PictureBox();
            this.Log_SearchBox = new System.Windows.Forms.TextBox();
            this.Log_ReturnButton = new System.Windows.Forms.Button();
            this.Log_List = new System.Windows.Forms.DataGridView();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Log_List)).BeginInit();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.head.Controls.Add(this.loglabel);
            this.head.Controls.Add(this.logopic);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1080, 90);
            this.head.TabIndex = 6;
            // 
            // loglabel
            // 
            this.loglabel.AutoSize = true;
            this.loglabel.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.loglabel.Location = new System.Drawing.Point(543, 25);
            this.loglabel.Name = "loglabel";
            this.loglabel.Size = new System.Drawing.Size(100, 46);
            this.loglabel.TabIndex = 1;
            this.loglabel.Tag = "";
            this.loglabel.Text = "履歴";
            // 
            // logopic
            // 
            this.logopic.Image = ((System.Drawing.Image)(resources.GetObject("logopic.Image")));
            this.logopic.Location = new System.Drawing.Point(465, 3);
            this.logopic.Name = "logopic";
            this.logopic.Size = new System.Drawing.Size(72, 80);
            this.logopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logopic.TabIndex = 0;
            this.logopic.TabStop = false;
            // 
            // Log_SearchBox
            // 
            this.Log_SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Log_SearchBox.BackColor = System.Drawing.Color.White;
            this.Log_SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Log_SearchBox.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Log_SearchBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Log_SearchBox.Location = new System.Drawing.Point(828, 111);
            this.Log_SearchBox.Name = "Log_SearchBox";
            this.Log_SearchBox.Size = new System.Drawing.Size(240, 31);
            this.Log_SearchBox.TabIndex = 4;
            this.Log_SearchBox.Text = "検索";
            this.Log_SearchBox.Click += new System.EventHandler(this.Log_SearchBox_Click);
            this.Log_SearchBox.TextChanged += new System.EventHandler(this.Log_SearchBox_TextChanged);
            // 
            // Log_ReturnButton
            // 
            this.Log_ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Log_ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Log_ReturnButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Log_ReturnButton.FlatAppearance.BorderSize = 0;
            this.Log_ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log_ReturnButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.Log_ReturnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Log_ReturnButton.Location = new System.Drawing.Point(888, 551);
            this.Log_ReturnButton.Margin = new System.Windows.Forms.Padding(0);
            this.Log_ReturnButton.Name = "Log_ReturnButton";
            this.Log_ReturnButton.Size = new System.Drawing.Size(180, 80);
            this.Log_ReturnButton.TabIndex = 5;
            this.Log_ReturnButton.Text = "戻る";
            this.Log_ReturnButton.UseVisualStyleBackColor = false;
            this.Log_ReturnButton.Click += new System.EventHandler(this.Log_ReturnButton_Click);
            // 
            // Log_List
            // 
            this.Log_List.AllowUserToAddRows = false;
            this.Log_List.AllowUserToDeleteRows = false;
            this.Log_List.AllowUserToResizeColumns = false;
            this.Log_List.AllowUserToResizeRows = false;
            this.Log_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Log_List.BackgroundColor = System.Drawing.Color.White;
            this.Log_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Log_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Log_List.Location = new System.Drawing.Point(12, 146);
            this.Log_List.Margin = new System.Windows.Forms.Padding(0);
            this.Log_List.MultiSelect = false;
            this.Log_List.Name = "Log_List";
            this.Log_List.RowHeadersVisible = false;
            this.Log_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Log_List.Size = new System.Drawing.Size(1056, 402);
            this.Log_List.TabIndex = 0;
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
            "タイプ",
            "取引先",
            "担当名"});
            this.SearchCombo.Location = new System.Drawing.Point(701, 111);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(121, 32);
            this.SearchCombo.TabIndex = 4;
            this.SearchCombo.Text = "ID";
            // 
            // LogMan
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.Log_List);
            this.Controls.Add(this.Log_ReturnButton);
            this.Controls.Add(this.Log_SearchBox);
            this.Controls.Add(this.head);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LogMan_Load);
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Log_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logopic;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Label loglabel;
        private System.Windows.Forms.TextBox Log_SearchBox;
        private System.Windows.Forms.Button Log_ReturnButton;
        private System.Windows.Forms.DataGridView Log_List;
        private System.Windows.Forms.ComboBox SearchCombo;
    }
}

