namespace TH21System
{
    partial class StoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.head = new System.Windows.Forms.Panel();
            this.StoreForm_L3 = new System.Windows.Forms.Label();
            this.StoreForm_Cancel = new System.Windows.Forms.Button();
            this.StoreForm_Send = new System.Windows.Forms.Button();
            this.StoreForm_L0 = new System.Windows.Forms.Label();
            this.StoreForm_ID = new System.Windows.Forms.TextBox();
            this.StoreForm_Amount = new System.Windows.Forms.TextBox();
            this.StoreForm_Product1 = new System.Windows.Forms.TextBox();
            this.OrderForm_ProductFill = new System.Windows.Forms.Button();
            this.StoreForm_Product2 = new System.Windows.Forms.TextBox();
            this.OrderForm_L2 = new System.Windows.Forms.Label();
            this.StoreForm_L4 = new System.Windows.Forms.Label();
            this.StoreForm_Resp = new System.Windows.Forms.TextBox();
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
            // StoreForm_L3
            // 
            this.StoreForm_L3.AutoSize = true;
            this.StoreForm_L3.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreForm_L3.Location = new System.Drawing.Point(80, 260);
            this.StoreForm_L3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StoreForm_L3.Name = "StoreForm_L3";
            this.StoreForm_L3.Size = new System.Drawing.Size(60, 28);
            this.StoreForm_L3.TabIndex = 7;
            this.StoreForm_L3.Text = "数量";
            // 
            // StoreForm_Cancel
            // 
            this.StoreForm_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.StoreForm_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StoreForm_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.StoreForm_Cancel.FlatAppearance.BorderSize = 0;
            this.StoreForm_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoreForm_Cancel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.StoreForm_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.StoreForm_Cancel.Location = new System.Drawing.Point(321, 348);
            this.StoreForm_Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.StoreForm_Cancel.Name = "StoreForm_Cancel";
            this.StoreForm_Cancel.Size = new System.Drawing.Size(180, 80);
            this.StoreForm_Cancel.TabIndex = 6;
            this.StoreForm_Cancel.Text = "戻る";
            this.StoreForm_Cancel.UseVisualStyleBackColor = false;
            // 
            // StoreForm_Send
            // 
            this.StoreForm_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.StoreForm_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StoreForm_Send.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.StoreForm_Send.FlatAppearance.BorderSize = 0;
            this.StoreForm_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoreForm_Send.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.StoreForm_Send.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.StoreForm_Send.Location = new System.Drawing.Point(40, 348);
            this.StoreForm_Send.Margin = new System.Windows.Forms.Padding(0);
            this.StoreForm_Send.Name = "StoreForm_Send";
            this.StoreForm_Send.Size = new System.Drawing.Size(180, 80);
            this.StoreForm_Send.TabIndex = 5;
            this.StoreForm_Send.Text = "追加";
            this.StoreForm_Send.UseVisualStyleBackColor = false;
            this.StoreForm_Send.Click += new System.EventHandler(this.StoreForm_Send_Click);
            // 
            // StoreForm_L0
            // 
            this.StoreForm_L0.AutoSize = true;
            this.StoreForm_L0.Location = new System.Drawing.Point(107, 119);
            this.StoreForm_L0.Name = "StoreForm_L0";
            this.StoreForm_L0.Size = new System.Drawing.Size(33, 24);
            this.StoreForm_L0.TabIndex = 12;
            this.StoreForm_L0.Text = "ID";
            // 
            // StoreForm_ID
            // 
            this.StoreForm_ID.Enabled = false;
            this.StoreForm_ID.Location = new System.Drawing.Point(153, 116);
            this.StoreForm_ID.Name = "StoreForm_ID";
            this.StoreForm_ID.Size = new System.Drawing.Size(104, 31);
            this.StoreForm_ID.TabIndex = 13;
            // 
            // StoreForm_Amount
            // 
            this.StoreForm_Amount.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreForm_Amount.Location = new System.Drawing.Point(153, 254);
            this.StoreForm_Amount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StoreForm_Amount.Name = "StoreForm_Amount";
            this.StoreForm_Amount.Size = new System.Drawing.Size(282, 34);
            this.StoreForm_Amount.TabIndex = 3;
            // 
            // StoreForm_Product1
            // 
            this.StoreForm_Product1.Enabled = false;
            this.StoreForm_Product1.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreForm_Product1.Location = new System.Drawing.Point(154, 166);
            this.StoreForm_Product1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StoreForm_Product1.Name = "StoreForm_Product1";
            this.StoreForm_Product1.Size = new System.Drawing.Size(206, 34);
            this.StoreForm_Product1.TabIndex = 21;
            // 
            // OrderForm_ProductFill
            // 
            this.OrderForm_ProductFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.OrderForm_ProductFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OrderForm_ProductFill.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OrderForm_ProductFill.FlatAppearance.BorderSize = 0;
            this.OrderForm_ProductFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderForm_ProductFill.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OrderForm_ProductFill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.OrderForm_ProductFill.Location = new System.Drawing.Point(364, 166);
            this.OrderForm_ProductFill.Margin = new System.Windows.Forms.Padding(0);
            this.OrderForm_ProductFill.Name = "OrderForm_ProductFill";
            this.OrderForm_ProductFill.Size = new System.Drawing.Size(71, 34);
            this.OrderForm_ProductFill.TabIndex = 20;
            this.OrderForm_ProductFill.Text = "書込";
            this.OrderForm_ProductFill.UseVisualStyleBackColor = false;
            this.OrderForm_ProductFill.Click += new System.EventHandler(this.OrderForm_ProductFill_Click);
            // 
            // StoreForm_Product2
            // 
            this.StoreForm_Product2.Enabled = false;
            this.StoreForm_Product2.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreForm_Product2.Location = new System.Drawing.Point(154, 210);
            this.StoreForm_Product2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StoreForm_Product2.Name = "StoreForm_Product2";
            this.StoreForm_Product2.Size = new System.Drawing.Size(282, 34);
            this.StoreForm_Product2.TabIndex = 18;
            // 
            // OrderForm_L2
            // 
            this.OrderForm_L2.AutoSize = true;
            this.OrderForm_L2.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OrderForm_L2.Location = new System.Drawing.Point(80, 169);
            this.OrderForm_L2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderForm_L2.Name = "OrderForm_L2";
            this.OrderForm_L2.Size = new System.Drawing.Size(60, 28);
            this.OrderForm_L2.TabIndex = 19;
            this.OrderForm_L2.Text = "商品";
            // 
            // StoreForm_L4
            // 
            this.StoreForm_L4.AutoSize = true;
            this.StoreForm_L4.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreForm_L4.Location = new System.Drawing.Point(56, 301);
            this.StoreForm_L4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StoreForm_L4.Name = "StoreForm_L4";
            this.StoreForm_L4.Size = new System.Drawing.Size(84, 28);
            this.StoreForm_L4.TabIndex = 28;
            this.StoreForm_L4.Text = "担当者";
            // 
            // StoreForm_Resp
            // 
            this.StoreForm_Resp.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreForm_Resp.Location = new System.Drawing.Point(154, 298);
            this.StoreForm_Resp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StoreForm_Resp.Name = "StoreForm_Resp";
            this.StoreForm_Resp.Size = new System.Drawing.Size(283, 34);
            this.StoreForm_Resp.TabIndex = 24;
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 452);
            this.Controls.Add(this.StoreForm_L4);
            this.Controls.Add(this.StoreForm_Resp);
            this.Controls.Add(this.StoreForm_Product1);
            this.Controls.Add(this.OrderForm_ProductFill);
            this.Controls.Add(this.StoreForm_Product2);
            this.Controls.Add(this.OrderForm_L2);
            this.Controls.Add(this.StoreForm_ID);
            this.Controls.Add(this.StoreForm_L0);
            this.Controls.Add(this.StoreForm_Cancel);
            this.Controls.Add(this.StoreForm_Send);
            this.Controls.Add(this.StoreForm_Amount);
            this.Controls.Add(this.StoreForm_L3);
            this.Controls.Add(this.head);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.head.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Label StoreForm_L3;
        private System.Windows.Forms.Button StoreForm_Cancel;
        public System.Windows.Forms.Button StoreForm_Send;
        private System.Windows.Forms.Label StoreForm_L0;
        public System.Windows.Forms.TextBox StoreForm_ID;
        public System.Windows.Forms.TextBox StoreForm_Amount;
        public System.Windows.Forms.TextBox StoreForm_Product1;
        public System.Windows.Forms.Button OrderForm_ProductFill;
        public System.Windows.Forms.TextBox StoreForm_Product2;
        private System.Windows.Forms.Label OrderForm_L2;
        private System.Windows.Forms.Label StoreForm_L4;
        public System.Windows.Forms.TextBox StoreForm_Resp;
    }
}