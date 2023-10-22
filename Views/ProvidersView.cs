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
    public partial class ProvidersView : Form, IProvidersView
    {
        private bool isEdit;
        private bool isSuccesfull;
        private string message;

        public ProvidersView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControlProviders.TabPages.Remove(tabPageProvidersDetail);
            BtnCloseProviders.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {

            BtnSearchProviders.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearchProviders.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            BtnNewProviders.Click += delegate { AddNewEvent?.Invoke(this, EventArgs.Empty); };
            BtnEditProviders.Click += delegate { EditEvent?.Invoke(this, EventArgs.Empty); };
            BtnDeleteProviders.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            BtnSaveProviders.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
            BtnCancelProviders.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
        }

        public string ProvidersId
        {
            get { return TxtIdProviders.Text; }
            set { TxtIdProviders.Text = value; }
        }
        public string ProvidersName
        {
            get { return TxtNameProviders.Text; }
            set { TxtNameProviders.Text = value; }
        }
        public string ProvidersObservation
        {
            get { return TxtObservationProviders.Text; }
            set { TxtObservationProviders.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearchProviders.Text; }
            set { TxtSearchProviders.Text = value; }
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

        public void SetProvidersListBildSource(BindingSource providersList)
        {
            throw new NotImplementedException();
        }
        private static ProvidersView instance;

        public static ProvidersView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProvidersView();
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
