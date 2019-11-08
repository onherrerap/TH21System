namespace TH21System
{
    partial class RankingMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankingMan));
            this.head = new System.Windows.Forms.Panel();
            this.loglabel = new System.Windows.Forms.Label();
            this.logopic = new System.Windows.Forms.PictureBox();
            this.Ranking_SearchBox = new System.Windows.Forms.TextBox();
            this.Ranking_ReturnButton = new System.Windows.Forms.Button();
            this.Ranking_List = new System.Windows.Forms.DataGridView();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ranking_List)).BeginInit();
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
            this.loglabel.Location = new System.Drawing.Point(473, 22);
            this.loglabel.Name = "loglabel";
            this.loglabel.Size = new System.Drawing.Size(191, 46);
            this.loglabel.TabIndex = 1;
            this.loglabel.Tag = "";
            this.loglabel.Text = "ランキング";
            // 
            // logopic
            // 
            this.logopic.Image = ((System.Drawing.Image)(resources.GetObject("logopic.Image")));
            this.logopic.Location = new System.Drawing.Point(395, 0);
            this.logopic.Name = "logopic";
            this.logopic.Size = new System.Drawing.Size(72, 80);
            this.logopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logopic.TabIndex = 0;
            this.logopic.TabStop = false;
            // 
            // Ranking_SearchBox
            // 
            this.Ranking_SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Ranking_SearchBox.BackColor = System.Drawing.Color.White;
            this.Ranking_SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ranking_SearchBox.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Ranking_SearchBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Ranking_SearchBox.Location = new System.Drawing.Point(828, 111);
            this.Ranking_SearchBox.Name = "Ranking_SearchBox";
            this.Ranking_SearchBox.Size = new System.Drawing.Size(240, 31);
            this.Ranking_SearchBox.TabIndex = 4;
            this.Ranking_SearchBox.Text = "検索";
            this.Ranking_SearchBox.Click += new System.EventHandler(this.Ranking_SearchBox_Click);
            this.Ranking_SearchBox.TextChanged += new System.EventHandler(this.Ranking_SearchBox_TextChanged);
            // 
            // Ranking_ReturnButton
            // 
            this.Ranking_ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Ranking_ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ranking_ReturnButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Ranking_ReturnButton.FlatAppearance.BorderSize = 0;
            this.Ranking_ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ranking_ReturnButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.Ranking_ReturnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Ranking_ReturnButton.Location = new System.Drawing.Point(888, 551);
            this.Ranking_ReturnButton.Margin = new System.Windows.Forms.Padding(0);
            this.Ranking_ReturnButton.Name = "Ranking_ReturnButton";
            this.Ranking_ReturnButton.Size = new System.Drawing.Size(180, 80);
            this.Ranking_ReturnButton.TabIndex = 5;
            this.Ranking_ReturnButton.Text = "戻る";
            this.Ranking_ReturnButton.UseVisualStyleBackColor = false;
            this.Ranking_ReturnButton.Click += new System.EventHandler(this.Ranking_ReturnButton_Click);
            // 
            // Ranking_List
            // 
            this.Ranking_List.AllowUserToAddRows = false;
            this.Ranking_List.AllowUserToDeleteRows = false;
            this.Ranking_List.AllowUserToResizeColumns = false;
            this.Ranking_List.AllowUserToResizeRows = false;
            this.Ranking_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Ranking_List.BackgroundColor = System.Drawing.Color.White;
            this.Ranking_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ranking_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Ranking_List.Location = new System.Drawing.Point(12, 146);
            this.Ranking_List.Margin = new System.Windows.Forms.Padding(0);
            this.Ranking_List.MultiSelect = false;
            this.Ranking_List.Name = "Ranking_List";
            this.Ranking_List.RowHeadersVisible = false;
            this.Ranking_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Ranking_List.Size = new System.Drawing.Size(1056, 402);
            this.Ranking_List.TabIndex = 0;
            // 
            // SearchCombo
            // 
            this.SearchCombo.AllowDrop = true;
            this.SearchCombo.BackColor = System.Drawing.Color.White;
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Items.AddRange(new object[] {
            "ID",
            "ブランド名",
            "商品名"});
            this.SearchCombo.Location = new System.Drawing.Point(701, 111);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(121, 32);
            this.SearchCombo.TabIndex = 4;
            this.SearchCombo.Text = "ID";
            // 
            // RankingMan
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.Ranking_List);
            this.Controls.Add(this.Ranking_ReturnButton);
            this.Controls.Add(this.Ranking_SearchBox);
            this.Controls.Add(this.head);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RankingMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RankingMan_Load);
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ranking_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logopic;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Label loglabel;
        private System.Windows.Forms.TextBox Ranking_SearchBox;
        private System.Windows.Forms.Button Ranking_ReturnButton;
        private System.Windows.Forms.DataGridView Ranking_List;
        private System.Windows.Forms.ComboBox SearchCombo;
    }
}

