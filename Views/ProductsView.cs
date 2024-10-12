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
    public partial class ProductsView : Form, IProductsView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public ProductsView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageProductsDetail);

            btnClose.Click += delegate { this.Close(); };
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

        public string ProductsId
        {
            get { return txtProductsId.Text; }
            set { txtProductsId.Text = value; }
        }
        public string ProductsName
        {
            get { return txtProductsName.Text; }
            set { txtProductsName.Text = value; }
        }
        public string ProductsPrice
        {
            get { return txtProductsPrice.Text; }
            set { txtProductsPrice.Text = value; }
        }
        public string ProductsStock
        {
            get { return txtProductsStock.Text; }
            set { txtProductsStock.Text = value; }
        }
        public string ProductsCategoriesId
        {
            get { return txtProductsCategoriesId.Text; }
            set { txtProductsCategoriesId.Text = value; }
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

        public void SetProductsListBildingSource(BindingSource productsList)
        {
            DgProducts.DataSource = productsList;
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
