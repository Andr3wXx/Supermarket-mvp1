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
            throw new NotImplementedException();
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewPodruct(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
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
