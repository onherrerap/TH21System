namespace TH21System
{
    partial class User1Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User1Menu));
            this.head = new System.Windows.Forms.Panel();
            this.logopicture = new System.Windows.Forms.PictureBox();
            this.ProductButton = new System.Windows.Forms.Button();
            this.ClientButton = new System.Windows.Forms.Button();
            this.UserButton = new System.Windows.Forms.Button();
            this.Logout_Button = new System.Windows.Forms.Button();
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
            this.logopicture.Location = new System.Drawing.Point(449, -35);
            this.logopicture.Name = "logopicture";
            this.logopicture.Size = new System.Drawing.Size(230, 235);
            this.logopicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logopicture.TabIndex = 0;
            this.logopicture.TabStop = false;
            // 
            // ProductButton
            // 
            this.ProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.ProductButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProductButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductButton.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.ProductButton.Location = new System.Drawing.Point(92, 254);
            this.ProductButton.Margin = new System.Windows.Forms.Padding(0);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(257, 139);
            this.ProductButton.TabIndex = 14;
            this.ProductButton.Text = "商品管理";
            this.ProductButton.UseVisualStyleBackColor = false;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // ClientButton
            // 
            this.ClientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.ClientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientButton.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ClientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.ClientButton.Location = new System.Drawing.Point(418, 254);
            this.ClientButton.Margin = new System.Windows.Forms.Padding(0);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(257, 139);
            this.ClientButton.TabIndex = 15;
            this.ClientButton.Text = "顧客管理";
            this.ClientButton.UseVisualStyleBackColor = false;
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click);
            // 
            // UserButton
            // 
            this.UserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.UserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UserButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserButton.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.UserButton.Location = new System.Drawing.Point(744, 254);
            this.UserButton.Margin = new System.Windows.Forms.Padding(0);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(257, 139);
            this.UserButton.TabIndex = 16;
            this.UserButton.Text = "ユーザー管理";
            this.UserButton.UseVisualStyleBackColor = false;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
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
            // User1Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.Logout_Button);
            this.Controls.Add(this.UserButton);
            this.Controls.Add(this.ClientButton);
            this.Controls.Add(this.ProductButton);
            this.Controls.Add(this.head);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "User1Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel head;
        public System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.PictureBox logopicture;
        public System.Windows.Forms.Button ClientButton;
        public System.Windows.Forms.Button UserButton;
        public System.Windows.Forms.Button Logout_Button;
    }
}

