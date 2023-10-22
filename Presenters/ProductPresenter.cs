using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp1.Views;
using Supermarket_mvp1.Models;

namespace Supermarket_mvp1.Presenters
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productsList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewPodruct;
            this.view.EditEvent += LoadSelectProductToEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductListBildingSource(productBindingSource);

            loadAllProduct();

            this.view.Show();

        }
            
        private void loadAllProduct()
        {
            productsList= repository.GetAll();
            productBindingSource.DataSource = productsList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            var productMode = new ProductModel();
            productMode.Product_Id = Convert.ToInt32(view.ProductId);
            productMode.Product_Name = view.ProductName;
            productMode.Product_Price = view.ProductPrice;
            productMode.Product_Stock = view.ProductStock;

            try
            {
                new Common.ModelDataValidation().Validate(productMode);
                if (view.IsEdit)
                {
                    repository.Edit(productMode);
                    view.Message = "Product edited successfuly";
                }
                else
                {
                    repository.Add(productMode);
                    view.Message = "Product added successfuly";
                }
                view.IsSuccessful = true;
                loadAllProduct();
                CleanViewFields();
            }   
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.ProductId = "0";
            view.ProductName = "";
            view.ProductPrice = "";
            view.ProductStock = "0";
        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            try
            {
                var productMode = (PayModeModel)productBindingSource.Current;

                repository.Delete(productMode.Id);
                view.IsSuccessful = true;
                view.Message = "Product deleted successfully";
                loadAllProduct();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Ah error ocurred, could not delete product";
            }
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {
            //Se obtiene el objeto del dtagridview que se encuentra seleccionado
            var productMode = (ProductModel)productBindingSource.Current;
            //Se cambia el contenido de las cajas de texto por el objeto recuperado 
            // del datagrudview
            view.ProductId = productMode.Product_Id.ToString();
            view.ProductName = productMode.Product_Name;
            view.ProductPrice = productMode.Product_Price;
            view.ProductStock = productMode.Product_Stock;

            //Se establece el modo como edicion
            view.IsEdit = true;
        }

        private void AddNewPodruct(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productsList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productsList = repository.GetAll();
            }
            productBindingSource.DataSource = productsList;
        }
    }

}
