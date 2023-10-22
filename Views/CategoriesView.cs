﻿using System;
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

            BtnSalirCategories.Click += delegate { this.Close(); };
            BtnEditCategories.Click += delegate { EditEvent?.Invoke(this, EventArgs.Empty); };
            BtnDeleteCategories.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            BtnSaveCategories.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
            BtnCancelCategories.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
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

            BtnNewCategories.Click += delegate { AddNewEvent?.Invoke(this, EventArgs.Empty); };
        }

        public string CategoriesId
        {
            get { return TxtIdCategories.Text; }
            set { TxtIdCategories.Text = value; }

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

        private static CategoriesView instance;

        public static CategoriesView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CategoriesView();
                instance.MdiParent = parentContainer;

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
