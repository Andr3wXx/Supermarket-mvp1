using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp1.Views
{
    public partial class CategoriesView : Form, ICategorieView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message; 
        public CategoriesView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabCategoriesDetail);

            BtnCloseC.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearchP.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearchsC.KeyDown += (s, e) =>
            {

                //Buscar, llame al metodo SearchEvent cuando se haga clic en el boton BtnSearch
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            BtnNewC.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabCategoriesList);
                tabControl1.TabPages.Add(tabCategoriesDetail);
                tabCategoriesDetail.Text = "Add New Pay Mode";
            };

            BtnEditC.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabCategoriesList);
                tabControl1.TabPages.Add(tabCategoriesDetail);
                tabCategoriesDetail.Text = "Edit Pay Mode"; //Cambia el titulo de la pestaña

            };
            BtnDeleteC.Click += delegate
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Pay Mode",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }

            };


            BtnSaveC.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)//Si grabar fue exitoso
                {
                    tabControl1.TabPages.Remove(tabCategoriesDetail);
                    tabControl1.TabPages.Add(tabCategoriesList);
                }
                MessageBox.Show(Message);
            };
            BtnCancelC.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabCategoriesDetail);
                tabControl1.TabPages.Add(tabCategoriesList);
            };
        }

            public string CategorieId
        {
            get { return TxtCategoriesId.Text; }
            set { TxtCategoriesId.Text = value; }
        }
        public string CategorieName
        {
            get { return TxtCategoriesName.Text; }
            set { TxtCategoriesName.Text = value; }
        }
        public string CategorieObservation
        {
            get { return TxtCategoriesObservation.Text; }
            set { TxtCategoriesObservation.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearchsC.Text; }
            set { TxtSearchsC.Text = value; }
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

        public void SetCategorieListBildingSource(BindingSource categorieList)
        {
            DgCategoriesC.DataSource = categorieList;
        }
        
    }

}

        
    
