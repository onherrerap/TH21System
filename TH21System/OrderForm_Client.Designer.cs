namespace TH21System
{
    partial class OrderForm_Client
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
            this.head = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OrderForm_Cancel = new System.Windows.Forms.Button();
            this.OrderForm_Send = new System.Windows.Forms.Button();
            this.Order_ClientList = new System.Windows.Forms.DataGridView();
            this.Order_ClientID = new System.Windows.Forms.TextBox();
            this.Order_ClientForm_L0 = new System.Windows.Forms.Label();
            this.Order_ClientName = new System.Windows.Forms.TextBox();
            this.Order_ClientForm_L1 = new System.Windows.Forms.Label();
            this.Order_ClientAddress = new System.Windows.Forms.TextBox();
            this.Order_ClientForm_L2 = new System.Windows.Forms.Label();
            this.head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_ClientList)).BeginInit();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.head.Controls.Add(this.pictureBox1);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1080, 90);
            this.head.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TH21System.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(517, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OrderForm_Cancel
            // 
            this.OrderForm_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.OrderForm_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OrderForm_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OrderForm_Cancel.FlatAppearance.BorderSize = 0;
            this.OrderForm_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderForm_Cancel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.OrderForm_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.OrderForm_Cancel.Location = new System.Drawing.Point(333, 535);
            this.OrderForm_Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.OrderForm_Cancel.Name = "OrderForm_Cancel";
            this.OrderForm_Cancel.Size = new System.Drawing.Size(180, 80);
            this.OrderForm_Cancel.TabIndex = 6;
            this.OrderForm_Cancel.Text = "戻る";
            this.OrderForm_Cancel.UseVisualStyleBackColor = false;
            // 
            // OrderForm_Send
            // 
            this.OrderForm_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.OrderForm_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OrderForm_Send.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OrderForm_Send.FlatAppearance.BorderSize = 0;
            this.OrderForm_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderForm_Send.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.OrderForm_Send.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(129)))));
            this.OrderForm_Send.Location = new System.Drawing.Point(67, 535);
            this.OrderForm_Send.Margin = new System.Windows.Forms.Padding(0);
            this.OrderForm_Send.Name = "OrderForm_Send";
            this.OrderForm_Send.Size = new System.Drawing.Size(180, 80);
            this.OrderForm_Send.TabIndex = 5;
            this.OrderForm_Send.Text = "追加";
            this.OrderForm_Send.UseVisualStyleBackColor = false;
            // 
            // Order_ClientList
            // 
            this.Order_ClientList.AllowUserToAddRows = false;
            this.Order_ClientList.AllowUserToDeleteRows = false;
            this.Order_ClientList.AllowUserToResizeColumns = false;
            this.Order_ClientList.AllowUserToResizeRows = false;
            this.Order_ClientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Order_ClientList.BackgroundColor = System.Drawing.Color.White;
            this.Order_ClientList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Order_ClientList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Order_ClientList.Location = new System.Drawing.Point(552, 95);
            this.Order_ClientList.Margin = new System.Windows.Forms.Padding(0);
            this.Order_ClientList.MultiSelect = false;
            this.Order_ClientList.Name = "Order_ClientList";
            this.Order_ClientList.RowHeadersVisible = false;
            this.Order_ClientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Order_ClientList.Size = new System.Drawing.Size(519, 520);
            this.Order_ClientList.TabIndex = 0;
            this.Order_ClientList.Click += new System.EventHandler(this.Order_ClientList_Click);
            // 
            // Order_ClientID
            // 
            this.Order_ClientID.Enabled = false;
            this.Order_ClientID.Location = new System.Drawing.Point(135, 148);
            this.Order_ClientID.Name = "Order_ClientID";
            this.Order_ClientID.Size = new System.Drawing.Size(112, 31);
            this.Order_ClientID.TabIndex = 19;
            // 
            // Order_ClientForm_L0
            // 
            this.Order_ClientForm_L0.AutoSize = true;
            this.Order_ClientForm_L0.Location = new System.Drawing.Point(89, 151);
            this.Order_ClientForm_L0.Name = "Order_ClientForm_L0";
            this.Order_ClientForm_L0.Size = new System.Drawing.Size(33, 24);
            this.Order_ClientForm_L0.TabIndex = 18;
            this.Order_ClientForm_L0.Text = "ID";
            // 
            // Order_ClientName
            // 
            this.Order_ClientName.Enabled = false;
            this.Order_ClientName.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Order_ClientName.Location = new System.Drawing.Point(135, 198);
            this.Order_ClientName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Order_ClientName.Name = "Order_ClientName";
            this.Order_ClientName.Size = new System.Drawing.Size(313, 34);
            this.Order_ClientName.TabIndex = 16;
            // 
            // Order_ClientForm_L1
            // 
            this.Order_ClientForm_L1.AutoSize = true;
            this.Order_ClientForm_L1.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Order_ClientForm_L1.Location = new System.Drawing.Point(62, 200);
            this.Order_ClientForm_L1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Order_ClientForm_L1.Name = "Order_ClientForm_L1";
            this.Order_ClientForm_L1.Size = new System.Drawing.Size(60, 28);
            this.Order_ClientForm_L1.TabIndex = 17;
            this.Order_ClientForm_L1.Text = "氏名";
            // 
            // Order_ClientAddress
            // 
            this.Order_ClientAddress.Enabled = false;
            this.Order_ClientAddress.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Order_ClientAddress.Location = new System.Drawing.Point(135, 251);
            this.Order_ClientAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Order_ClientAddress.Multiline = true;
            this.Order_ClientAddress.Name = "Order_ClientAddress";
            this.Order_ClientAddress.Size = new System.Drawing.Size(313, 112);
            this.Order_ClientAddress.TabIndex = 20;
            // 
            // Order_ClientForm_L2
            // 
            this.Order_ClientForm_L2.AutoSize = true;
            this.Order_ClientForm_L2.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Order_ClientForm_L2.Location = new System.Drawing.Point(62, 253);
            this.Order_ClientForm_L2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Order_ClientForm_L2.Name = "Order_ClientForm_L2";
            this.Order_ClientForm_L2.Size = new System.Drawing.Size(60, 28);
            this.Order_ClientForm_L2.TabIndex = 21;
            this.Order_ClientForm_L2.Text = "住所";
            // 
            // OrderForm_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.Order_ClientAddress);
            this.Controls.Add(this.Order_ClientForm_L2);
            this.Controls.Add(this.Order_ClientID);
            this.Controls.Add(this.Order_ClientForm_L0);
            this.Controls.Add(this.Order_ClientName);
            this.Controls.Add(this.Order_ClientForm_L1);
            this.Controls.Add(this.Order_ClientList);
            this.Controls.Add(this.OrderForm_Cancel);
            this.Controls.Add(this.OrderForm_Send);
            this.Controls.Add(this.head);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderForm_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Client_Load);
            this.head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_ClientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Button OrderForm_Cancel;
        public System.Windows.Forms.Button OrderForm_Send;
        public System.Windows.Forms.DataGridView Order_ClientList;
        public System.Windows.Forms.TextBox Order_ClientID;
        private System.Windows.Forms.Label Order_ClientForm_L0;
        public System.Windows.Forms.TextBox Order_ClientName;
        private System.Windows.Forms.Label Order_ClientForm_L1;
        public System.Windows.Forms.TextBox Order_ClientAddress;
        private System.Windows.Forms.Label Order_ClientForm_L2;
    }
}