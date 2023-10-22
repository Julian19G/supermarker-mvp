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
    public partial class CategoriesView : Form, ICategoriesView
    {
        private bool isEdit;
        private bool isSuccesfull;
        private string message;

        public CategoriesView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControlCategories.TabPages.Remove(tabPageCategoriesDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearchCategories.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearchCategories.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public string CategoriesId {
           get { return TxtIdCategories.Text; }
           set { TxtIdCategories.Text = value;}
                
        }
        public string CategoriesName
        {
            get { return TxtNameCategories.Text; }
            set { TxtNameCategories.Text = value; }
        }
        public string CategoriesObservation
        {
            get { return TxtObservationCategories.Text; }
            set { TxtIdCategories.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtIdCategories.Text; }
            set { TxtIdCategories.Text = value; }
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

        public void SetCategoriesListBildSource(BindingSource categoriesList)
        {
            DgCategories.DataSource = categoriesList;
        }
    }
}
