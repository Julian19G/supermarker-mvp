namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayModeView));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPagePayModeLis = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPagePayModeDetail = new TabPage();
            button2 = new Button();
            button1 = new Button();
            TxtPayModeObservation = new TextBox();
            TxtPayModeName = new TextBox();
            TxtPayModeId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeLis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPagePayModeDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1119, 280);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 37);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Pay Mode";
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeLis);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 280);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1119, 436);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeLis
            // 
            tabPagePayModeLis.Controls.Add(BtnClose);
            tabPagePayModeLis.Controls.Add(BtnDelete);
            tabPagePayModeLis.Controls.Add(BtnEdit);
            tabPagePayModeLis.Controls.Add(BtnNew);
            tabPagePayModeLis.Controls.Add(DgPayMode);
            tabPagePayModeLis.Controls.Add(BtnSearch);
            tabPagePayModeLis.Controls.Add(TxtSearch);
            tabPagePayModeLis.Controls.Add(label2);
            tabPagePayModeLis.Location = new Point(4, 29);
            tabPagePayModeLis.Name = "tabPagePayModeLis";
            tabPagePayModeLis.Padding = new Padding(3);
            tabPagePayModeLis.Size = new Size(1111, 403);
            tabPagePayModeLis.TabIndex = 0;
            tabPagePayModeLis.Text = "Pay Mode List";
            tabPagePayModeLis.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.ImageAlign = ContentAlignment.TopCenter;
            BtnClose.Location = new Point(955, 305);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(94, 50);
            BtnClose.TabIndex = 7;
            BtnClose.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = (Image)resources.GetObject("BtnDelete.Image");
            BtnDelete.ImageAlign = ContentAlignment.TopCenter;
            BtnDelete.Location = new Point(955, 231);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 46);
            BtnDelete.TabIndex = 6;
            BtnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.ImageAlign = ContentAlignment.TopCenter;
            BtnEdit.Location = new Point(955, 138);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(94, 61);
            BtnEdit.TabIndex = 5;
            BtnEdit.Text = "&Edit";
            BtnEdit.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = (Image)resources.GetObject("BtnNew.Image");
            BtnNew.ImageAlign = ContentAlignment.TopCenter;
            BtnNew.Location = new Point(955, 58);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(94, 60);
            BtnNew.TabIndex = 4;
            BtnNew.Text = "&New";
            BtnNew.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(8, 80);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowHeadersWidth = 51;
            DgPayMode.RowTemplate.Height = 29;
            DgPayMode.Size = new Size(719, 315);
            DgPayMode.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.ImageAlign = ContentAlignment.TopCenter;
            BtnSearch.Location = new Point(494, 8);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(88, 66);
            BtnSearch.TabIndex = 2;
            BtnSearch.Text = "&Buscar";
            BtnSearch.TextAlign = ContentAlignment.TopCenter;
            BtnSearch.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(8, 35);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(453, 27);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 12);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(button2);
            tabPagePayModeDetail.Controls.Add(button1);
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Controls.Add(label5);
            tabPagePayModeDetail.Controls.Add(label4);
            tabPagePayModeDetail.Controls.Add(label3);
            tabPagePayModeDetail.Location = new Point(4, 29);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(1111, 403);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.cancel;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(308, 340);
            button2.Name = "button2";
            button2.Size = new Size(94, 46);
            button2.TabIndex = 7;
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.save;
            button1.Location = new Point(69, 340);
            button1.Name = "button1";
            button1.Size = new Size(94, 46);
            button1.TabIndex = 6;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(45, 197);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.Size = new Size(395, 133);
            TxtPayModeObservation.TabIndex = 5;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(45, 129);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(395, 27);
            TxtPayModeName.TabIndex = 4;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(45, 65);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.PlaceholderText = "Pay Mode Id";
            TxtPayModeId.Size = new Size(395, 27);
            TxtPayModeId.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 174);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 2;
            label5.Text = "Pay Mode Observation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 106);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 1;
            label4.Text = "Pay Mode Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 42);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 0;
            label3.Text = "Pay Mode Id";
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 716);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeLis.ResumeLayout(false);
            tabPagePayModeLis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeLis;
        private TabPage tabPagePayModeDetail;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnSearch;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgPayMode;
        private Button BtnClose;
        private Button button2;
        private Button button1;
        private TextBox TxtPayModeObservation;
        private TextBox TxtPayModeName;
        private TextBox TxtPayModeId;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}