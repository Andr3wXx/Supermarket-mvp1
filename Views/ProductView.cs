using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp1.Views
{
    public partial class ProductView : Form, IProductView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public string ProductId
        {
            get { return TxtProductId.Text; }
            set { TxtProductId.Text = value; }
        }
        string IProductView.ProductName
        {
            get { return TxtProductName.Text; }
            set { TxtProductName.Text = value; }
        }
        public string ProductPrice
        {
            get { return TxtPrice.Text; }
            set { TxtPrice.Text = value; }
        }
        public string ProductStock
        {
            get { return TxtStock.Text; }
            set { TxtStock.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearchS.Text; }
            set { TxtSearchS.Text = value; }
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
        string IProductView { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private static ProductView instance;

        public static ProductView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductView();
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

        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabProducts.TabPages.Remove(tabPagePorductsModeList);

            BtnCloseP.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearchP.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearchS.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            BtnNewP.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabProducts.TabPages.Add(tabPageProductsDetail);
                tabProducts.TabPages.Remove(tabPagePorductsModeList);
                tabPageProductsDetail.Text = "Add New Product";
            };
            BtnEditP.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabProducts.TabPages.Remove(tabPagePorductsModeList);
                tabProducts.TabPages.Add(tabPageProductsDetail);
                tabPageProductsDetail.Text = "Edit Product";
            };

            BtnDeleteP.Click += delegate
            {
                var result = MessageBox.Show(
                "Are you sure you want to delete the selected Product",
                "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }

            };

            BtnSaveP.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabProducts.TabPages.Remove(tabPageProductsDetail);
                    tabProducts.TabPages.Add(tabPagePorductsModeList);
                }
                MessageBox.Show(Message);
            };

            BtnCancelP.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabProducts.TabPages.Remove(tabPageProductsDetail);
                tabProducts.TabPages.Add(tabPageProductsDetail);
            };
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearchP_Click(object sender, EventArgs e)
        {
        }
    }
}
