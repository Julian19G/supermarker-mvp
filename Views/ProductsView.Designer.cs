namespace Supermarket_mvp.Views
{
    partial class ProductsView
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControlProducts = new TabControl();
            tabPageProductList = new TabPage();
            tabPageProductDetail = new TabPage();
            label2 = new Label();
            TxtSearchProducts = new TextBox();
            BtnSearchProducts = new Button();
            DgProducts = new DataGridView();
            BtnNewProducts = new Button();
            BtnEditProducts = new Button();
            BtnDeleteProducts = new Button();
            BtnCloseProviders = new Button();
            label3 = new Label();
            TxtIdProducts = new TextBox();
            label4 = new Label();
            TxtNameProducts = new TextBox();
            label5 = new Label();
            TxtPriceProducts = new TextBox();
            label6 = new Label();
            TxtStockProducts = new TextBox();
            label7 = new Label();
            CbCategoriesProducts = new ComboBox();
            BtnSaveProducts = new Button();
            BtnCancelProducts = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControlProducts.SuspendLayout();
            tabPageProductList.SuspendLayout();
            tabPageProductDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 48);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControlProducts
            // 
            tabControlProducts.Controls.Add(tabPageProductList);
            tabControlProducts.Controls.Add(tabPageProductDetail);
            tabControlProducts.Dock = DockStyle.Fill;
            tabControlProducts.Location = new Point(0, 125);
            tabControlProducts.Name = "tabControlProducts";
            tabControlProducts.SelectedIndex = 0;
            tabControlProducts.Size = new Size(800, 325);
            tabControlProducts.TabIndex = 1;
            // 
            // tabPageProductList
            // 
            tabPageProductList.Controls.Add(BtnCloseProviders);
            tabPageProductList.Controls.Add(BtnDeleteProducts);
            tabPageProductList.Controls.Add(BtnEditProducts);
            tabPageProductList.Controls.Add(BtnNewProducts);
            tabPageProductList.Controls.Add(DgProducts);
            tabPageProductList.Controls.Add(BtnSearchProducts);
            tabPageProductList.Controls.Add(TxtSearchProducts);
            tabPageProductList.Controls.Add(label2);
            tabPageProductList.Location = new Point(4, 29);
            tabPageProductList.Name = "tabPageProductList";
            tabPageProductList.Padding = new Padding(3);
            tabPageProductList.Size = new Size(792, 292);
            tabPageProductList.TabIndex = 0;
            tabPageProductList.Text = "Products List";
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(BtnCancelProducts);
            tabPageProductDetail.Controls.Add(BtnSaveProducts);
            tabPageProductDetail.Controls.Add(CbCategoriesProducts);
            tabPageProductDetail.Controls.Add(label7);
            tabPageProductDetail.Controls.Add(TxtStockProducts);
            tabPageProductDetail.Controls.Add(label6);
            tabPageProductDetail.Controls.Add(TxtPriceProducts);
            tabPageProductDetail.Controls.Add(label5);
            tabPageProductDetail.Controls.Add(TxtNameProducts);
            tabPageProductDetail.Controls.Add(label4);
            tabPageProductDetail.Controls.Add(TxtIdProducts);
            tabPageProductDetail.Controls.Add(label3);
            tabPageProductDetail.Location = new Point(4, 29);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(3);
            tabPageProductDetail.Size = new Size(792, 292);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Product Details";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 15);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 0;
            label2.Text = "Product Search";
            // 
            // TxtSearchProducts
            // 
            TxtSearchProducts.Location = new Point(57, 38);
            TxtSearchProducts.Name = "TxtSearchProducts";
            TxtSearchProducts.PlaceholderText = "Product to search";
            TxtSearchProducts.Size = new Size(352, 27);
            TxtSearchProducts.TabIndex = 1;
            // 
            // BtnSearchProducts
            // 
            BtnSearchProducts.Image = Properties.Resources.search_small;
            BtnSearchProducts.Location = new Point(426, 15);
            BtnSearchProducts.Name = "BtnSearchProducts";
            BtnSearchProducts.Size = new Size(94, 52);
            BtnSearchProducts.TabIndex = 2;
            BtnSearchProducts.UseVisualStyleBackColor = true;
            // 
            // DgProducts
            // 
            DgProducts.AllowUserToAddRows = false;
            DgProducts.AllowUserToDeleteRows = false;
            DgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProducts.Location = new Point(57, 81);
            DgProducts.Name = "DgProducts";
            DgProducts.ReadOnly = true;
            DgProducts.RowHeadersWidth = 51;
            DgProducts.RowTemplate.Height = 29;
            DgProducts.Size = new Size(573, 188);
            DgProducts.TabIndex = 3;
            // 
            // BtnNewProducts
            // 
            BtnNewProducts.Image = Properties.Resources._new;
            BtnNewProducts.Location = new Point(669, 66);
            BtnNewProducts.Name = "BtnNewProducts";
            BtnNewProducts.Size = new Size(94, 44);
            BtnNewProducts.TabIndex = 4;
            BtnNewProducts.UseVisualStyleBackColor = true;
            // 
            // BtnEditProducts
            // 
            BtnEditProducts.Image = Properties.Resources.edit;
            BtnEditProducts.Location = new Point(669, 116);
            BtnEditProducts.Name = "BtnEditProducts";
            BtnEditProducts.Size = new Size(94, 46);
            BtnEditProducts.TabIndex = 5;
            BtnEditProducts.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteProducts
            // 
            BtnDeleteProducts.Image = Properties.Resources.delete;
            BtnDeleteProducts.Location = new Point(669, 171);
            BtnDeleteProducts.Name = "BtnDeleteProducts";
            BtnDeleteProducts.Size = new Size(94, 42);
            BtnDeleteProducts.TabIndex = 6;
            BtnDeleteProducts.TabStop = false;
            BtnDeleteProducts.UseVisualStyleBackColor = true;
            // 
            // BtnCloseProviders
            // 
            BtnCloseProviders.Image = Properties.Resources.cerrar;
            BtnCloseProviders.Location = new Point(669, 230);
            BtnCloseProviders.Name = "BtnCloseProviders";
            BtnCloseProviders.Size = new Size(94, 39);
            BtnCloseProviders.TabIndex = 7;
            BtnCloseProviders.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 20);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 0;
            label3.Text = "Product ID";
            // 
            // TxtIdProducts
            // 
            TxtIdProducts.Location = new Point(45, 43);
            TxtIdProducts.Name = "TxtIdProducts";
            TxtIdProducts.Size = new Size(253, 27);
            TxtIdProducts.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(322, 20);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 2;
            label4.Text = "Product Name";
            // 
            // TxtNameProducts
            // 
            TxtNameProducts.Location = new Point(322, 43);
            TxtNameProducts.Name = "TxtNameProducts";
            TxtNameProducts.PlaceholderText = "Product Name";
            TxtNameProducts.Size = new Size(378, 27);
            TxtNameProducts.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 95);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 4;
            label5.Text = "Product Price";
            // 
            // TxtPriceProducts
            // 
            TxtPriceProducts.Location = new Point(45, 118);
            TxtPriceProducts.Name = "TxtPriceProducts";
            TxtPriceProducts.Size = new Size(253, 27);
            TxtPriceProducts.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(322, 95);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 6;
            label6.Text = "Product Stock";
            // 
            // TxtStockProducts
            // 
            TxtStockProducts.Location = new Point(322, 118);
            TxtStockProducts.Name = "TxtStockProducts";
            TxtStockProducts.Size = new Size(378, 27);
            TxtStockProducts.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 168);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 8;
            label7.Text = "Product Categories";
            // 
            // CbCategoriesProducts
            // 
            CbCategoriesProducts.FormattingEnabled = true;
            CbCategoriesProducts.Location = new Point(45, 191);
            CbCategoriesProducts.Name = "CbCategoriesProducts";
            CbCategoriesProducts.Size = new Size(655, 28);
            CbCategoriesProducts.TabIndex = 9;
            // 
            // BtnSaveProducts
            // 
            BtnSaveProducts.Image = Properties.Resources.save;
            BtnSaveProducts.Location = new Point(246, 225);
            BtnSaveProducts.Name = "BtnSaveProducts";
            BtnSaveProducts.Size = new Size(94, 45);
            BtnSaveProducts.TabIndex = 10;
            BtnSaveProducts.UseVisualStyleBackColor = true;
            // 
            // BtnCancelProducts
            // 
            BtnCancelProducts.Image = Properties.Resources.cancel;
            BtnCancelProducts.Location = new Point(396, 225);
            BtnCancelProducts.Name = "BtnCancelProducts";
            BtnCancelProducts.Size = new Size(94, 45);
            BtnCancelProducts.TabIndex = 11;
            BtnCancelProducts.UseVisualStyleBackColor = true;
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlProducts);
            Controls.Add(panel1);
            Name = "ProductsView";
            Text = "Products Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControlProducts.ResumeLayout(false);
            tabPageProductList.ResumeLayout(false);
            tabPageProductList.PerformLayout();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControlProducts;
        private TabPage tabPageProductList;
        private TabPage tabPageProductDetail;
        private TextBox TxtSearchProducts;
        private Label label2;
        private DataGridView DgProducts;
        private Button BtnSearchProducts;
        private Button BtnCloseProviders;
        private Button BtnDeleteProducts;
        private Button BtnEditProducts;
        private Button BtnNewProducts;
        private Label label3;
        private Button BtnCancelProducts;
        private Button BtnSaveProducts;
        private ComboBox CbCategoriesProducts;
        private Label label7;
        private TextBox TxtStockProducts;
        private Label label6;
        private TextBox TxtPriceProducts;
        private Label label5;
        private TextBox TxtNameProducts;
        private Label label4;
        private TextBox TxtIdProducts;
    }
}