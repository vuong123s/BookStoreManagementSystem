namespace WindowsFormsApp3
{
    partial class Home
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.main = new System.Windows.Forms.TabPage();
            this.orders = new System.Windows.Forms.TabPage();
            this.products = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label_book_price = new System.Windows.Forms.Label();
            this.label_book_author = new System.Windows.Forms.Label();
            this.label_book_name = new System.Windows.Forms.Label();
            this.book_price = new System.Windows.Forms.TextBox();
            this.book_author = new System.Windows.Forms.TextBox();
            this.book_name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.client = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.products.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.main);
            this.tabControl1.Controls.Add(this.orders);
            this.tabControl1.Controls.Add(this.products);
            this.tabControl1.Controls.Add(this.client);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // main
            // 
            this.main.Location = new System.Drawing.Point(4, 25);
            this.main.Name = "main";
            this.main.Padding = new System.Windows.Forms.Padding(3);
            this.main.Size = new System.Drawing.Size(794, 421);
            this.main.TabIndex = 0;
            this.main.Text = "Trang chủ";
            this.main.UseVisualStyleBackColor = true;
            // 
            // orders
            // 
            this.orders.Location = new System.Drawing.Point(4, 25);
            this.orders.Name = "orders";
            this.orders.Padding = new System.Windows.Forms.Padding(3);
            this.orders.Size = new System.Drawing.Size(794, 421);
            this.orders.TabIndex = 1;
            this.orders.Text = "Đặt hàng";
            this.orders.UseVisualStyleBackColor = true;
            // 
            // products
            // 
            this.products.Controls.Add(this.panel1);
            this.products.Controls.Add(this.dataGridView1);
            this.products.Location = new System.Drawing.Point(4, 25);
            this.products.Name = "products";
            this.products.Padding = new System.Windows.Forms.Padding(3);
            this.products.Size = new System.Drawing.Size(794, 421);
            this.products.TabIndex = 2;
            this.products.Text = "Sản phẩm";
            this.products.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.changeBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.label_book_price);
            this.panel1.Controls.Add(this.label_book_author);
            this.panel1.Controls.Add(this.label_book_name);
            this.panel1.Controls.Add(this.book_price);
            this.panel1.Controls.Add(this.book_author);
            this.panel1.Controls.Add(this.book_name);
            this.panel1.Location = new System.Drawing.Point(3, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 166);
            this.panel1.TabIndex = 3;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(622, 110);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(622, 67);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(75, 23);
            this.changeBtn.TabIndex = 8;
            this.changeBtn.Text = "Sửa";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(622, 23);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label_book_price
            // 
            this.label_book_price.AutoSize = true;
            this.label_book_price.Location = new System.Drawing.Point(65, 113);
            this.label_book_price.Name = "label_book_price";
            this.label_book_price.Size = new System.Drawing.Size(28, 16);
            this.label_book_price.TabIndex = 5;
            this.label_book_price.Text = "Giá";
            // 
            // label_book_author
            // 
            this.label_book_author.AutoSize = true;
            this.label_book_author.Location = new System.Drawing.Point(38, 70);
            this.label_book_author.Name = "label_book_author";
            this.label_book_author.Size = new System.Drawing.Size(55, 16);
            this.label_book_author.TabIndex = 2;
            this.label_book_author.Text = "Tác Giả";
            // 
            // label_book_name
            // 
            this.label_book_name.AutoSize = true;
            this.label_book_name.Location = new System.Drawing.Point(28, 26);
            this.label_book_name.Name = "label_book_name";
            this.label_book_name.Size = new System.Drawing.Size(65, 16);
            this.label_book_name.TabIndex = 1;
            this.label_book_name.Text = "Tên Sách";
            // 
            // book_price
            // 
            this.book_price.Location = new System.Drawing.Point(137, 110);
            this.book_price.Name = "book_price";
            this.book_price.Size = new System.Drawing.Size(343, 22);
            this.book_price.TabIndex = 0;
            // 
            // book_author
            // 
            this.book_author.Location = new System.Drawing.Point(137, 70);
            this.book_author.Name = "book_author";
            this.book_author.Size = new System.Drawing.Size(343, 22);
            this.book_author.TabIndex = 0;
            this.book_author.TextChanged += new System.EventHandler(this.book_author_TextChanged);
            // 
            // book_name
            // 
            this.book_name.Location = new System.Drawing.Point(137, 24);
            this.book_name.Name = "book_name";
            this.book_name.Size = new System.Drawing.Size(343, 22);
            this.book_name.TabIndex = 0;
            this.book_name.TextChanged += new System.EventHandler(this.book_name_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 241);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(4, 25);
            this.client.Name = "client";
            this.client.Padding = new System.Windows.Forms.Padding(3);
            this.client.Size = new System.Drawing.Size(794, 421);
            this.client.TabIndex = 3;
            this.client.Text = "Khách hàng";
            this.client.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Home";
            this.Text = "Home";
            this.tabControl1.ResumeLayout(false);
            this.products.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage main;
        private System.Windows.Forms.TabPage orders;
        private System.Windows.Forms.TabPage products;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label_book_price;
        private System.Windows.Forms.Label label_book_author;
        private System.Windows.Forms.Label label_book_name;
        private System.Windows.Forms.TextBox book_price;
        private System.Windows.Forms.TextBox book_author;
        private System.Windows.Forms.TextBox book_name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage client;
    }
}