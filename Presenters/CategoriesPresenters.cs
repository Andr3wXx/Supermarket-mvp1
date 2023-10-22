using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using Supermarket_mvp1.Models;
using Supermarket_mvp1.Views;

namespace Supermarket_mvp1.Presenters
{
    internal class CategoriesPresenters
    {
        private ICategorieView view;
        private ICategorieRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<CategoriesModel> categoriesModelList;

        public CategoriesPresenters(ICategorieView view, ICategorieRepository repository)
        {
            this.payModeBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategories;
            this.view.AddNewEvent += AddNewCategories;
            this.view.EditEvent += LoadSelectCategoriesToEdit;
            this.view.DeleteEvent += DeleteSelectedCategories;
            this.view.SaveEvent += SaveCategories;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategorieListBildingSource(payModeBindingSource);

            loadAllCategoriesList();

            this.view.Show();

        }

        private void loadAllCategoriesList()
        {
            categoriesModelList = repository.GetAll();
            payModeBindingSource.DataSource = categoriesModelList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveCategories(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedCategories(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectCategoriesToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewCategories(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchCategories(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
