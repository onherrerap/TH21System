namespace TH21System
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.head = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.logopicture = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Login_User = new System.Windows.Forms.TextBox();
            this.Login_Password = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.userlabel = new System.Windows.Forms.Label();
            this.useravailable = new System.Windows.Forms.DataGridView();
            this.useravailable2 = new System.Windows.Forms.DataGridView();
            this.head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useravailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useravailable2)).BeginInit();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.head.Controls.Add(this.button1);
            this.head.Controls.Add(this.logopicture);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1080, 200);
            this.head.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.button1.Location = new System.Drawing.Point(934, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "終了";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Close_Click);
            // 
            // logopicture
            // 
            this.logopicture.Image = global::TH21System.Properties.Resources.logo_transparent;
            this.logopicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("logopicture.InitialImage")));
            this.logopicture.Location = new System.Drawing.Point(380, -51);
            this.logopicture.Name = "logopicture";
            this.logopicture.Size = new System.Drawing.Size(321, 312);
            this.logopicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logopicture.TabIndex = 0;
            this.logopicture.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoginButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.LoginButton.Location = new System.Drawing.Point(423, 445);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(0);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(180, 80);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "ログイン";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Login_User
            // 
            this.Login_User.Location = new System.Drawing.Point(442, 298);
            this.Login_User.Name = "Login_User";
            this.Login_User.Size = new System.Drawing.Size(321, 31);
            this.Login_User.TabIndex = 0;
            this.Login_User.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_User_KeyPress);
            // 
            // Login_Password
            // 
            this.Login_Password.Location = new System.Drawing.Point(442, 354);
            this.Login_Password.Name = "Login_Password";
            this.Login_Password.PasswordChar = '●';
            this.Login_Password.Size = new System.Drawing.Size(321, 31);
            this.Login_Password.TabIndex = 1;
            this.Login_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_Password_KeyPress);
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(314, 357);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(96, 24);
            this.passwordlabel.TabIndex = 15;
            this.passwordlabel.Text = "パスワード";
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Location = new System.Drawing.Point(325, 301);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(85, 24);
            this.userlabel.TabIndex = 16;
            this.userlabel.Text = "ユーザー";
            // 
            // useravailable
            // 
            this.useravailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.useravailable.Location = new System.Drawing.Point(23, 217);
            this.useravailable.Name = "useravailable";
            this.useravailable.RowTemplate.Height = 24;
            this.useravailable.Size = new System.Drawing.Size(1041, 10);
            this.useravailable.TabIndex = 17;
            this.useravailable.Visible = false;
            // 
            // useravailable2
            // 
            this.useravailable2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.useravailable2.Location = new System.Drawing.Point(23, 233);
            this.useravailable2.Name = "useravailable2";
            this.useravailable2.RowTemplate.Height = 24;
            this.useravailable2.Size = new System.Drawing.Size(1042, 10);
            this.useravailable2.TabIndex = 18;
            this.useravailable2.Visible = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.useravailable2);
            this.Controls.Add(this.useravailable);
            this.Controls.Add(this.userlabel);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Login_Password);
            this.Controls.Add(this.Login_User);
            this.Controls.Add(this.head);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logopicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useravailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useravailable2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel head;
        public System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.PictureBox logopicture;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Login_User;
        private System.Windows.Forms.TextBox Login_Password;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.DataGridView useravailable;
        private System.Windows.Forms.DataGridView useravailable2;
    }
}

