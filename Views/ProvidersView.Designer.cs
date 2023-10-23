namespace Supermarket_mvp.Views
{
    partial class ProvidersView
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
            tabControlProviders = new TabControl();
            tabPageProvidersList = new TabPage();
            BtnCloseProviders = new Button();
            BtnDeleteProviders = new Button();
            BtnEditProviders = new Button();
            BtnNewProviders = new Button();
            DgProviders = new DataGridView();
            BtnSearchProviders = new Button();
            TxtSearchProviders = new TextBox();
            label2 = new Label();
            tabPageProvidersDetail = new TabPage();
            BtnCancelProviders = new Button();
            BtnSaveProviders = new Button();
            TxtObservationProviders = new TextBox();
            label5 = new Label();
            TxtNameProviders = new TextBox();
            label4 = new Label();
            TxtIdProviders = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControlProviders.SuspendLayout();
            tabPageProvidersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).BeginInit();
            tabPageProvidersDetail.SuspendLayout();
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
            pictureBox1.Image = Properties.Resources.providers;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 52);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Providers";
            // 
            // tabControlProviders
            // 
            tabControlProviders.Controls.Add(tabPageProvidersList);
            tabControlProviders.Controls.Add(tabPageProvidersDetail);
            tabControlProviders.Dock = DockStyle.Fill;
            tabControlProviders.Location = new Point(0, 125);
            tabControlProviders.Name = "tabControlProviders";
            tabControlProviders.SelectedIndex = 0;
            tabControlProviders.Size = new Size(800, 325);
            tabControlProviders.TabIndex = 1;
            // 
            // tabPageProvidersList
            // 
            tabPageProvidersList.Controls.Add(BtnCloseProviders);
            tabPageProvidersList.Controls.Add(BtnDeleteProviders);
            tabPageProvidersList.Controls.Add(BtnEditProviders);
            tabPageProvidersList.Controls.Add(BtnNewProviders);
            tabPageProvidersList.Controls.Add(DgProviders);
            tabPageProvidersList.Controls.Add(BtnSearchProviders);
            tabPageProvidersList.Controls.Add(TxtSearchProviders);
            tabPageProvidersList.Controls.Add(label2);
            tabPageProvidersList.Location = new Point(4, 29);
            tabPageProvidersList.Name = "tabPageProvidersList";
            tabPageProvidersList.Padding = new Padding(3);
            tabPageProvidersList.Size = new Size(792, 292);
            tabPageProvidersList.TabIndex = 0;
            tabPageProvidersList.Text = "Providers List";
            tabPageProvidersList.UseVisualStyleBackColor = true;
            // 
            // BtnCloseProviders
            // 
            BtnCloseProviders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCloseProviders.Image = Properties.Resources.cerrar;
            BtnCloseProviders.Location = new Point(654, 214);
            BtnCloseProviders.Name = "BtnCloseProviders";
            BtnCloseProviders.Size = new Size(94, 39);
            BtnCloseProviders.TabIndex = 7;
            BtnCloseProviders.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteProviders
            // 
            BtnDeleteProviders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeleteProviders.Image = Properties.Resources.delete;
            BtnDeleteProviders.Location = new Point(654, 168);
            BtnDeleteProviders.Name = "BtnDeleteProviders";
            BtnDeleteProviders.Size = new Size(94, 40);
            BtnDeleteProviders.TabIndex = 6;
            BtnDeleteProviders.UseVisualStyleBackColor = true;
            // 
            // BtnEditProviders
            // 
            BtnEditProviders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditProviders.Image = Properties.Resources.edit;
            BtnEditProviders.Location = new Point(654, 121);
            BtnEditProviders.Name = "BtnEditProviders";
            BtnEditProviders.Size = new Size(94, 41);
            BtnEditProviders.TabIndex = 5;
            BtnEditProviders.UseVisualStyleBackColor = true;
            // 
            // BtnNewProviders
            // 
            BtnNewProviders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNewProviders.Image = Properties.Resources._new;
            BtnNewProviders.Location = new Point(654, 75);
            BtnNewProviders.Name = "BtnNewProviders";
            BtnNewProviders.Size = new Size(94, 40);
            BtnNewProviders.TabIndex = 4;
            BtnNewProviders.UseVisualStyleBackColor = true;
            // 
            // DgProviders
            // 
            DgProviders.AllowUserToAddRows = false;
            DgProviders.AllowUserToDeleteRows = false;
            DgProviders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProviders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProviders.Location = new Point(52, 75);
            DgProviders.Name = "DgProviders";
            DgProviders.ReadOnly = true;
            DgProviders.RowHeadersWidth = 51;
            DgProviders.RowTemplate.Height = 29;
            DgProviders.Size = new Size(542, 209);
            DgProviders.TabIndex = 3;
            // 
            // BtnSearchProviders
            // 
            BtnSearchProviders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearchProviders.Image = Properties.Resources.search_small;
            BtnSearchProviders.Location = new Point(379, 30);
            BtnSearchProviders.Name = "BtnSearchProviders";
            BtnSearchProviders.Size = new Size(54, 41);
            BtnSearchProviders.TabIndex = 2;
            BtnSearchProviders.UseVisualStyleBackColor = true;
            // 
            // TxtSearchProviders
            // 
            TxtSearchProviders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearchProviders.Location = new Point(52, 42);
            TxtSearchProviders.Name = "TxtSearchProviders";
            TxtSearchProviders.PlaceholderText = "Data to search";
            TxtSearchProviders.Size = new Size(302, 27);
            TxtSearchProviders.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 19);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Providers";
            // 
            // tabPageProvidersDetail
            // 
            tabPageProvidersDetail.Controls.Add(BtnCancelProviders);
            tabPageProvidersDetail.Controls.Add(BtnSaveProviders);
            tabPageProvidersDetail.Controls.Add(TxtObservationProviders);
            tabPageProvidersDetail.Controls.Add(label5);
            tabPageProvidersDetail.Controls.Add(TxtNameProviders);
            tabPageProvidersDetail.Controls.Add(label4);
            tabPageProvidersDetail.Controls.Add(TxtIdProviders);
            tabPageProvidersDetail.Controls.Add(label3);
            tabPageProvidersDetail.Location = new Point(4, 29);
            tabPageProvidersDetail.Name = "tabPageProvidersDetail";
            tabPageProvidersDetail.Padding = new Padding(3);
            tabPageProvidersDetail.Size = new Size(792, 292);
            tabPageProvidersDetail.TabIndex = 1;
            tabPageProvidersDetail.Text = "Providers Detail";
            tabPageProvidersDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancelProviders
            // 
            BtnCancelProviders.Image = Properties.Resources.cancel;
            BtnCancelProviders.Location = new Point(239, 237);
            BtnCancelProviders.Name = "BtnCancelProviders";
            BtnCancelProviders.Size = new Size(94, 42);
            BtnCancelProviders.TabIndex = 7;
            BtnCancelProviders.UseVisualStyleBackColor = true;
            // 
            // BtnSaveProviders
            // 
            BtnSaveProviders.Image = Properties.Resources.save;
            BtnSaveProviders.Location = new Point(74, 237);
            BtnSaveProviders.Name = "BtnSaveProviders";
            BtnSaveProviders.Size = new Size(94, 42);
            BtnSaveProviders.TabIndex = 6;
            BtnSaveProviders.UseVisualStyleBackColor = true;
            // 
            // TxtObservationProviders
            // 
            TxtObservationProviders.Location = new Point(56, 153);
            TxtObservationProviders.Multiline = true;
            TxtObservationProviders.Name = "TxtObservationProviders";
            TxtObservationProviders.PlaceholderText = "Providers Observations";
            TxtObservationProviders.Size = new Size(317, 78);
            TxtObservationProviders.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 127);
            label5.Name = "label5";
            label5.Size = new Size(160, 20);
            label5.TabIndex = 4;
            label5.Text = "Providers Observations";
            // 
            // TxtNameProviders
            // 
            TxtNameProviders.Location = new Point(56, 92);
            TxtNameProviders.Name = "TxtNameProviders";
            TxtNameProviders.PlaceholderText = "Providers Name";
            TxtNameProviders.Size = new Size(317, 27);
            TxtNameProviders.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 69);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 2;
            label4.Text = "Providers Name";
            // 
            // TxtIdProviders
            // 
            TxtIdProviders.Location = new Point(56, 35);
            TxtIdProviders.Name = "TxtIdProviders";
            TxtIdProviders.ReadOnly = true;
            TxtIdProviders.Size = new Size(279, 27);
            TxtIdProviders.TabIndex = 1;
            TxtIdProviders.Text = "0";
            TxtIdProviders.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 12);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 0;
            label3.Text = "Providers ID";
            // 
            // ProvidersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlProviders);
            Controls.Add(panel1);
            Name = "ProvidersView";
            Text = "Providers Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControlProviders.ResumeLayout(false);
            tabPageProvidersList.ResumeLayout(false);
            tabPageProvidersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).EndInit();
            tabPageProvidersDetail.ResumeLayout(false);
            tabPageProvidersDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControlProviders;
        private TabPage tabPageProvidersList;
        private Label label2;
        private TabPage tabPageProvidersDetail;
        private Button BtnCloseProviders;
        private Button BtnDeleteProviders;
        private Button BtnEditProviders;
        private Button BtnNewProviders;
        private DataGridView DgProviders;
        private Button BtnSearchProviders;
        private TextBox TxtSearchProviders;
        private Button BtnCancelProviders;
        private Button BtnSaveProviders;
        private TextBox TxtObservationProviders;
        private Label label5;
        private TextBox TxtNameProviders;
        private Label label4;
        private TextBox TxtIdProviders;
        private Label label3;
    }
}