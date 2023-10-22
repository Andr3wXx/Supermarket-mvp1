﻿using Supermarket_mvp.Views;
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