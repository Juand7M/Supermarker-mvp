using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarker_mvp.Views
{
    public partial class CustomersView : Form, ICustomersView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public CustomersView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageCustomersDetail);
            btnCLose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public string CustomersId 
        {
            get { return txtCustomersId.Text; }
            set { txtCustomersId.Text = value;}
        }
        public string CustomersDocument_Number 
        {
            get { return txtCustomersDocumentNumber.Text; }
            set { txtCustomersDocumentNumber.Text = value; }
        }
        public string CustomersFirst_Name 
        {
            get { return txtCustomersFirstName.Text; }
            set { txtCustomersFirstName.Text = value; }
        }
        public string CustomersLast_Name 
        {
            get { return txtCustomersLastName.Text; }
            set { txtCustomersLastName.Text = value; }
        }
        public string CustomersAddress 
        {
            get { return txtCustomersAddress.Text; }
            set { txtCustomersAddress.Text = value; }
        }
        public string CustomersBirthday 
        {
            get { return txtCustomersBirthday.Text; }
            set { txtCustomersBirthday.Text = value; }
        }
        public string CustomersPhone_Number 
        {
            get { return txtCustomersPhoneNumber.Text; }
            set { txtCustomersPhoneNumber.Text = value; }
        }
        public string CustomersEmail 
        {
            get { return txtCustomersEmail.Text; }
            set { txtCustomersEmail.Text = value; }
        }


        public string SearchValue 
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public bool IsEdit 
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful 
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
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

        public void SetcustomersListBildingSource(BindingSource customersList)
        {
            DgCustomers.DataSource = customersList;
        }
        private static CustomersView instance;

        internal static ICustomersView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CustomersView();
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
