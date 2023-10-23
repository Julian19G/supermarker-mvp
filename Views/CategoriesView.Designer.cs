namespace Supermarket_mvp.Views
{
    partial class CategoriesView
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControlCategories = new TabControl();
            tabPageCategoriesList = new TabPage();
            BtnSalirCategories = new Button();
            BtnDeleteCategories = new Button();
            BtnEditCategories = new Button();
            BtnNewCategories = new Button();
            DgCategories = new DataGridView();
            BtnSearchCategories = new Button();
            TxtSearchCategories = new TextBox();
            label2 = new Label();
            tabPageCategoriesDetail = new TabPage();
            BtnCancelCategories = new Button();
            BtnSaveCategories = new Button();
            TxtObservationCategories = new TextBox();
            label5 = new Label();
            TxtNameCategories = new TextBox();
            label4 = new Label();
            TxtIdCategories = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControlCategories.SuspendLayout();
            tabPageCategoriesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).BeginInit();
            tabPageCategoriesDetail.SuspendLayout();
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(175, 9);
            label1.Name = "label1";
            label1.Size = new Size(519, 98);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // tabControlCategories
            // 
            tabControlCategories.Controls.Add(tabPageCategoriesList);
            tabControlCategories.Controls.Add(tabPageCategoriesDetail);
            tabControlCategories.Dock = DockStyle.Fill;
            tabControlCategories.Location = new Point(0, 125);
            tabControlCategories.Name = "tabControlCategories";
            tabControlCategories.SelectedIndex = 0;
            tabControlCategories.Size = new Size(800, 325);
            tabControlCategories.TabIndex = 1;
            // 
            // tabPageCategoriesList
            // 
            tabPageCategoriesList.Controls.Add(BtnSalirCategories);
            tabPageCategoriesList.Controls.Add(BtnDeleteCategories);
            tabPageCategoriesList.Controls.Add(BtnEditCategories);
            tabPageCategoriesList.Controls.Add(BtnNewCategories);
            tabPageCategoriesList.Controls.Add(DgCategories);
            tabPageCategoriesList.Controls.Add(BtnSearchCategories);
            tabPageCategoriesList.Controls.Add(TxtSearchCategories);
            tabPageCategoriesList.Controls.Add(label2);
            tabPageCategoriesList.Location = new Point(4, 29);
            tabPageCategoriesList.Name = "tabPageCategoriesList";
            tabPageCategoriesList.Padding = new Padding(3);
            tabPageCategoriesList.Size = new Size(792, 292);
            tabPageCategoriesList.TabIndex = 0;
            tabPageCategoriesList.Text = "Categories List";
            tabPageCategoriesList.UseVisualStyleBackColor = true;
            // 
            // BtnSalirCategories
            // 
            BtnSalirCategories.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSalirCategories.Image = Properties.Resources.cerrar;
            BtnSalirCategories.Location = new Point(662, 217);
            BtnSalirCategories.Name = "BtnSalirCategories";
            BtnSalirCategories.Size = new Size(94, 46);
            BtnSalirCategories.TabIndex = 7;
            BtnSalirCategories.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteCategories
            // 
            BtnDeleteCategories.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeleteCategories.Image = Properties.Resources.delete;
            BtnDeleteCategories.Location = new Point(662, 173);
            BtnDeleteCategories.Name = "BtnDeleteCategories";
            BtnDeleteCategories.Size = new Size(94, 38);
            BtnDeleteCategories.TabIndex = 6;
            BtnDeleteCategories.UseVisualStyleBackColor = true;
            // 
            // BtnEditCategories
            // 
            BtnEditCategories.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditCategories.Image = Properties.Resources.edit;
            BtnEditCategories.Location = new Point(662, 125);
            BtnEditCategories.Name = "BtnEditCategories";
            BtnEditCategories.Size = new Size(94, 42);
            BtnEditCategories.TabIndex = 5;
            BtnEditCategories.UseVisualStyleBackColor = true;
            // 
            // BtnNewCategories
            // 
            BtnNewCategories.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNewCategories.Image = Properties.Resources._new;
            BtnNewCategories.ImageAlign = ContentAlignment.TopCenter;
            BtnNewCategories.Location = new Point(662, 77);
            BtnNewCategories.Name = "BtnNewCategories";
            BtnNewCategories.Size = new Size(94, 42);
            BtnNewCategories.TabIndex = 4;
            BtnNewCategories.UseVisualStyleBackColor = true;
            // 
            // DgCategories
            // 
            DgCategories.AllowUserToAddRows = false;
            DgCategories.AllowUserToDeleteRows = false;
            DgCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategories.Location = new Point(50, 90);
            DgCategories.Name = "DgCategories";
            DgCategories.ReadOnly = true;
            DgCategories.RowHeadersWidth = 51;
            DgCategories.RowTemplate.Height = 29;
            DgCategories.Size = new Size(554, 188);
            DgCategories.TabIndex = 3;
            // 
            // BtnSearchCategories
            // 
            BtnSearchCategories.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearchCategories.Image = Properties.Resources.search_small;
            BtnSearchCategories.Location = new Point(438, 25);
            BtnSearchCategories.Name = "BtnSearchCategories";
            BtnSearchCategories.Size = new Size(45, 54);
            BtnSearchCategories.TabIndex = 2;
            BtnSearchCategories.UseVisualStyleBackColor = true;
            // 
            // TxtSearchCategories
            // 
            TxtSearchCategories.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearchCategories.Location = new Point(50, 48);
            TxtSearchCategories.Name = "TxtSearchCategories";
            TxtSearchCategories.PlaceholderText = "Data to search";
            TxtSearchCategories.Size = new Size(370, 27);
            TxtSearchCategories.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 25);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Categories";
            // 
            // tabPageCategoriesDetail
            // 
            tabPageCategoriesDetail.Controls.Add(BtnCancelCategories);
            tabPageCategoriesDetail.Controls.Add(BtnSaveCategories);
            tabPageCategoriesDetail.Controls.Add(TxtObservationCategories);
            tabPageCategoriesDetail.Controls.Add(label5);
            tabPageCategoriesDetail.Controls.Add(TxtNameCategories);
            tabPageCategoriesDetail.Controls.Add(label4);
            tabPageCategoriesDetail.Controls.Add(TxtIdCategories);
            tabPageCategoriesDetail.Controls.Add(label3);
            tabPageCategoriesDetail.Location = new Point(4, 29);
            tabPageCategoriesDetail.Name = "tabPageCategoriesDetail";
            tabPageCategoriesDetail.Padding = new Padding(3);
            tabPageCategoriesDetail.Size = new Size(792, 292);
            tabPageCategoriesDetail.TabIndex = 1;
            tabPageCategoriesDetail.Text = "Categories Detail";
            tabPageCategoriesDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancelCategories
            // 
            BtnCancelCategories.Image = Properties.Resources.cancel;
            BtnCancelCategories.Location = new Point(202, 246);
            BtnCancelCategories.Name = "BtnCancelCategories";
            BtnCancelCategories.Size = new Size(94, 40);
            BtnCancelCategories.TabIndex = 7;
            BtnCancelCategories.UseVisualStyleBackColor = true;
            // 
            // BtnSaveCategories
            // 
            BtnSaveCategories.Image = Properties.Resources.save;
            BtnSaveCategories.Location = new Point(55, 246);
            BtnSaveCategories.Name = "BtnSaveCategories";
            BtnSaveCategories.Size = new Size(94, 40);
            BtnSaveCategories.TabIndex = 6;
            BtnSaveCategories.UseVisualStyleBackColor = true;
            // 
            // TxtObservationCategories
            // 
            TxtObservationCategories.Location = new Point(55, 167);
            TxtObservationCategories.Multiline = true;
            TxtObservationCategories.Name = "TxtObservationCategories";
            TxtObservationCategories.PlaceholderText = "Categories Observation";
            TxtObservationCategories.Size = new Size(329, 73);
            TxtObservationCategories.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 144);
            label5.Name = "label5";
            label5.Size = new Size(164, 20);
            label5.TabIndex = 4;
            label5.Text = "Categories Observation";
            // 
            // TxtNameCategories
            // 
            TxtNameCategories.Location = new Point(55, 104);
            TxtNameCategories.Name = "TxtNameCategories";
            TxtNameCategories.Size = new Size(329, 27);
            TxtNameCategories.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 81);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 2;
            label4.Text = "Categories Name";
            // 
            // TxtIdCategories
            // 
            TxtIdCategories.Location = new Point(55, 47);
            TxtIdCategories.Name = "TxtIdCategories";
            TxtIdCategories.ReadOnly = true;
            TxtIdCategories.Size = new Size(214, 27);
            TxtIdCategories.TabIndex = 1;
            TxtIdCategories.Text = "0";
            TxtIdCategories.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 21);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 0;
            label3.Text = "Categories ID";
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlCategories);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "Categories Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControlCategories.ResumeLayout(false);
            tabPageCategoriesList.ResumeLayout(false);
            tabPageCategoriesList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).EndInit();
            tabPageCategoriesDetail.ResumeLayout(false);
            tabPageCategoriesDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControlCategories;
        private TabPage tabPageCategoriesList;
        private TabPage tabPageCategoriesDetail;
        private Button BtnSalirCategories;
        private Button BtnDeleteCategories;
        private Button BtnEditCategories;
        private Button BtnNewCategories;
        private DataGridView DgCategories;
        private Button BtnSearchCategories;
        private TextBox TxtSearchCategories;
        private Label label2;
        private TextBox TxtObservationCategories;
        private Label label5;
        private TextBox TxtNameCategories;
        private Label label4;
        private TextBox TxtIdCategories;
        private Label label3;
        private Button BtnCancelCategories;
        private Button BtnSaveCategories;
    }
}