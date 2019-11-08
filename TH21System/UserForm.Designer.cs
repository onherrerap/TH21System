namespace TH21System
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.head = new System.Windows.Forms.Panel();
            this.UserForm_L1 = new System.Windows.Forms.Label();
            this.UserForm_Username = new System.Windows.Forms.TextBox();
            this.UserForm_Password = new System.Windows.Forms.TextBox();
            this.UserForm_L2 = new System.Windows.Forms.Label();
            this.UserForm_L3 = new System.Windows.Forms.Label();
            this.UserForm_Cancel = new System.Windows.Forms.Button();
            this.UserForm_Send = new System.Windows.Forms.Button();
            this.UserForm_Password2 = new System.Windows.Forms.TextBox();
            this.UserForm_ID = new System.Windows.Forms.TextBox();
            this.UserForm_L0 = new System.Windows.Forms.Label();
            this.UserForm_L4 = new System.Windows.Forms.Label();
            this.UserForm_Name = new System.Windows.Forms.TextBox();
            this.UserForm_Type = new System.Windows.Forms.ComboBox();
            this.UserForm_L5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.head.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(235, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.head.Controls.Add(this.pictureBox1);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(540, 90);
            this.head.TabIndex = 2;
            // 
            // UserForm_L1
            // 
            this.UserForm_L1.AutoSize = true;
            this.UserForm_L1.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UserForm_L1.Location = new System.Drawing.Point(49, 341);
            this.UserForm_L1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserForm_L1.Name = "UserForm_L1";
            this.UserForm_L1.Size = new System.Drawing.Size(127, 28);
            this.UserForm_L1.TabIndex = 3;
            this.UserForm_L1.Text = "ユーザー名";
            // 
            // UserForm_Username
            // 
            this.UserForm_Username.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UserForm_Username.Location = new System.Drawing.Point(184, 340);
            this.UserForm_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserForm_Username.Name = "UserForm_Username";
            this.UserForm_Username.Size = new System.Drawing.Size(313, 34);
            this.UserForm_Username.TabIndex = 3;
            // 
            // UserForm_Password
            // 
            this.UserForm_Password.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UserForm_Password.Location = new System.Drawing.Point(184, 405);
            this.UserForm_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserForm_Password.Name = "UserForm_Password";
            this.UserForm_Password.PasswordChar = '●';
            this.UserForm_Password.Size = new System.Drawing.Size(313, 34);
            this.UserForm_Password.TabIndex = 4;
            // 
            // UserForm_L2
            // 
            this.UserForm_L2.AutoSize = true;
            this.UserForm_L2.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UserForm_L2.Location = new System.Drawing.Point(60, 405);
            this.UserForm_L2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserForm_L2.Name = "UserForm_L2";
            this.UserForm_L2.Size = new System.Drawing.Size(116, 28);
            this.UserForm_L2.TabIndex = 5;
            this.UserForm_L2.Text = "パスワード";
            // 
            // UserForm_L3
            // 
            this.UserForm_L3.AutoSize = true;
            this.UserForm_L3.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UserForm_L3.Location = new System.Drawing.Point(23, 473);
            this.UserForm_L3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserForm_L3.Name = "UserForm_L3";
            this.UserForm_L3.Size = new System.Drawing.Size(164, 28);
            this.UserForm_L3.TabIndex = 7;
            this.UserForm_L3.Text = "パスワード確認";
            // 
            // UserForm_Cancel
            // 
            this.UserForm_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.UserForm_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UserForm_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.UserForm_Cancel.FlatAppearance.BorderSize = 0;
            this.UserForm_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserForm_Cancel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.UserForm_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.UserForm_Cancel.Location = new System.Drawing.Point(321, 535);
            this.UserForm_Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.UserForm_Cancel.Name = "UserForm_Cancel";
            this.UserForm_Cancel.Size = new System.Drawing.Size(180, 80);
            this.UserForm_Cancel.TabIndex = 7;
            this.UserForm_Cancel.Text = "戻る";
            this.UserForm_Cancel.UseVisualStyleBackColor = false;
            // 
            // UserForm_Send
            // 
            this.UserForm_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.UserForm_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UserForm_Send.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UserForm_Send.FlatAppearance.BorderSize = 0;
            this.UserForm_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserForm_Send.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.UserForm_Send.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.UserForm_Send.Location = new System.Drawing.Point(43, 535);
            this.UserForm_Send.Margin = new System.Windows.Forms.Padding(0);
            this.UserForm_Send.Name = "UserForm_Send";
            this.UserForm_Send.Size = new System.Drawing.Size(180, 80);
            this.UserForm_Send.TabIndex = 6;
            this.UserForm_Send.Text = "追加";
            this.UserForm_Send.UseVisualStyleBackColor = false;
            this.UserForm_Send.Click += new System.EventHandler(this.UserForm_Send_Click);
            // 
            // UserForm_Password2
            // 
            this.UserForm_Password2.Location = new System.Drawing.Point(184, 470);
            this.UserForm_Password2.Name = "UserForm_Password2";
            this.UserForm_Password2.PasswordChar = '●';
            this.UserForm_Password2.Size = new System.Drawing.Size(313, 31);
            this.UserForm_Password2.TabIndex = 5;
            // 
            // UserForm_ID
            // 
            this.UserForm_ID.Enabled = false;
            this.UserForm_ID.Location = new System.Drawing.Point(184, 150);
            this.UserForm_ID.Name = "UserForm_ID";
            this.UserForm_ID.Size = new System.Drawing.Size(94, 31);
            this.UserForm_ID.TabIndex = 0;
            // 
            // UserForm_L0
            // 
            this.UserForm_L0.AutoSize = true;
            this.UserForm_L0.Location = new System.Drawing.Point(138, 153);
            this.UserForm_L0.Name = "UserForm_L0";
            this.UserForm_L0.Size = new System.Drawing.Size(33, 24);
            this.UserForm_L0.TabIndex = 14;
            this.UserForm_L0.Text = "ID";
            // 
            // UserForm_L4
            // 
            this.UserForm_L4.AutoSize = true;
            this.UserForm_L4.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UserForm_L4.Location = new System.Drawing.Point(111, 213);
            this.UserForm_L4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserForm_L4.Name = "UserForm_L4";
            this.UserForm_L4.Size = new System.Drawing.Size(60, 28);
            this.UserForm_L4.TabIndex = 16;
            this.UserForm_L4.Text = "氏名";
            // 
            // UserForm_Name
            // 
            this.UserForm_Name.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UserForm_Name.Location = new System.Drawing.Point(184, 212);
            this.UserForm_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserForm_Name.Name = "UserForm_Name";
            this.UserForm_Name.Size = new System.Drawing.Size(313, 34);
            this.UserForm_Name.TabIndex = 1;
            // 
            // UserForm_Type
            // 
            this.UserForm_Type.FormattingEnabled = true;
            this.UserForm_Type.Items.AddRange(new object[] {
            "本社",
            "営業",
            "物流"});
            this.UserForm_Type.Location = new System.Drawing.Point(184, 277);
            this.UserForm_Type.Name = "UserForm_Type";
            this.UserForm_Type.Size = new System.Drawing.Size(186, 32);
            this.UserForm_Type.TabIndex = 2;
            // 
            // UserForm_L5
            // 
            this.UserForm_L5.AutoSize = true;
            this.UserForm_L5.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UserForm_L5.Location = new System.Drawing.Point(111, 277);
            this.UserForm_L5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserForm_L5.Name = "UserForm_L5";
            this.UserForm_L5.Size = new System.Drawing.Size(60, 28);
            this.UserForm_L5.TabIndex = 19;
            this.UserForm_L5.Text = "役職";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 640);
            this.Controls.Add(this.UserForm_L5);
            this.Controls.Add(this.UserForm_Type);
            this.Controls.Add(this.UserForm_Name);
            this.Controls.Add(this.UserForm_L4);
            this.Controls.Add(this.UserForm_ID);
            this.Controls.Add(this.UserForm_L0);
            this.Controls.Add(this.UserForm_Password2);
            this.Controls.Add(this.UserForm_Cancel);
            this.Controls.Add(this.UserForm_Send);
            this.Controls.Add(this.UserForm_L3);
            this.Controls.Add(this.UserForm_Password);
            this.Controls.Add(this.UserForm_L2);
            this.Controls.Add(this.UserForm_Username);
            this.Controls.Add(this.UserForm_L1);
            this.Controls.Add(this.head);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.head.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Label UserForm_L1;
        public System.Windows.Forms.TextBox UserForm_Username;
        public System.Windows.Forms.TextBox UserForm_Password;
        private System.Windows.Forms.Label UserForm_L2;
        private System.Windows.Forms.Label UserForm_L3;
        private System.Windows.Forms.Button UserForm_Cancel;
        public System.Windows.Forms.Button UserForm_Send;
        public System.Windows.Forms.TextBox UserForm_Password2;
        public System.Windows.Forms.TextBox UserForm_ID;
        private System.Windows.Forms.Label UserForm_L0;
        private System.Windows.Forms.Label UserForm_L4;
        public System.Windows.Forms.TextBox UserForm_Name;
        public System.Windows.Forms.ComboBox UserForm_Type;
        private System.Windows.Forms.Label UserForm_L5;
    }
}