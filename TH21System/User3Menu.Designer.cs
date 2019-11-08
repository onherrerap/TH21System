namespace TH21System
{
    partial class User3Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User3Menu));
            this.head = new System.Windows.Forms.Panel();
            this.logopicture = new System.Windows.Forms.PictureBox();
            this.StoreButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.LogButton = new System.Windows.Forms.Button();
            this.head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopicture)).BeginInit();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.head.Controls.Add(this.logopicture);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1080, 160);
            this.head.TabIndex = 7;
            // 
            // logopicture
            // 
            this.logopicture.Image = global::TH21System.Properties.Resources.logo_transparent;
            this.logopicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("logopicture.InitialImage")));
            this.logopicture.Location = new System.Drawing.Point(445, -35);
            this.logopicture.Name = "logopicture";
            this.logopicture.Size = new System.Drawing.Size(230, 235);
            this.logopicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logopicture.TabIndex = 0;
            this.logopicture.TabStop = false;
            // 
            // StoreButton
            // 
            this.StoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.StoreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StoreButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.StoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoreButton.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.StoreButton.Location = new System.Drawing.Point(92, 254);
            this.StoreButton.Margin = new System.Windows.Forms.Padding(0);
            this.StoreButton.Name = "StoreButton";
            this.StoreButton.Size = new System.Drawing.Size(257, 139);
            this.StoreButton.TabIndex = 14;
            this.StoreButton.Text = "倉庫管理";
            this.StoreButton.UseVisualStyleBackColor = false;
            this.StoreButton.Click += new System.EventHandler(this.StoreButton_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.OrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OrderButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderButton.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.OrderButton.Location = new System.Drawing.Point(418, 254);
            this.OrderButton.Margin = new System.Windows.Forms.Padding(0);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(257, 139);
            this.OrderButton.TabIndex = 15;
            this.OrderButton.Text = "受注管理";
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // Logout_Button
            // 
            this.Logout_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.Logout_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Logout_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Logout_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_Button.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Logout_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.Logout_Button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Logout_Button.Location = new System.Drawing.Point(912, 581);
            this.Logout_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(135, 36);
            this.Logout_Button.TabIndex = 15;
            this.Logout_Button.Text = "ログアウト";
            this.Logout_Button.UseVisualStyleBackColor = false;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // LogButton
            // 
            this.LogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.LogButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.LogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogButton.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LogButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.LogButton.Location = new System.Drawing.Point(744, 254);
            this.LogButton.Margin = new System.Windows.Forms.Padding(0);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(257, 139);
            this.LogButton.TabIndex = 16;
            this.LogButton.Text = "履歴";
            this.LogButton.UseVisualStyleBackColor = false;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // User3Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.Logout_Button);
            this.Controls.Add(this.LogButton);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.StoreButton);
            this.Controls.Add(this.head);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "User3Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logopicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel head;
        public System.Windows.Forms.Button StoreButton;
        private System.Windows.Forms.PictureBox logopicture;
        public System.Windows.Forms.Button OrderButton;
        public System.Windows.Forms.Button Logout_Button;
        public System.Windows.Forms.Button LogButton;
    }
}

