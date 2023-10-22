using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class ProductsView : Form, IProductsView
    {
        private bool isEdit;
        private bool isSuccesfull;
        private string message;

        public ProductsView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControlProducts.TabPages.Remove(tabPageProductDetail);

            BtnCloseProducts.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearchProducts.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearchProducts.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            BtnNewProducts.Click += delegate { AddNewEvent?.Invoke(this, EventArgs.Empty); };
            BtnEditProducts.Click += delegate { EditEvent?.Invoke(this, EventArgs.Empty); };
            BtnDeleteProducts.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            BtnSaveProducts.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
            BtnCancelProducts.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
 
        }

        public string ProductsId
        {
            get { return TxtIdProducts.Text; }
            set { TxtIdProducts.Text = value; }
        }
        public string ProductsName
        {
            get { return TxtNameProducts.Text; }
            set { TxtNameProducts.Text = value; }
        }
        public string ProductsStock
        {
            get { return TxtStockProducts.Text; }
            set { TxtStockProducts.Text = value; }
        }
        public string ProductsCategory
        {
            get { return CbCategoriesProducts.Text; }
            set { CbCategoriesProducts.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearchProducts.Text; }
            set { TxtSearchProducts.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccesfull
        {
            get { return isSuccesfull; }
            set { isSuccesfull = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProductsListBildSource(BindingSource productsList)
        {
            throw new NotImplementedException();
        }
        private static ProductsView instance;

        public static ProductsView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductsView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}
