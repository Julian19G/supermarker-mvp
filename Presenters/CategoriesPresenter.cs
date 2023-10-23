using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace Supermarket_mvp.Presenters
{
    internal class CategoriesPresenter
    {
        private ICategoriesView view;
        private ICategoriesRepository repository;
        private BindingSource categoriesBindingSource;
        private IEnumerable<CategoriesModel> categoriesList;

        public CategoriesPresenter(ICategoriesView view, ICategoriesRepository repository)
        {
            this.categoriesBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategories;
            this.view.AddNewEvent += AddNewCategories;
            this.view.EditEvent += LoadSelectCategoriesToEdit;
            this.view.DeleteEvent += DeleteSelectedCategories;
            this.view.SaveEvent += SaveCategories;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoriesListBildSource(categoriesBindingSource);

            loadAllOpenCategoriesList();

            this.view.Show();
        }

        private void loadAllOpenCategoriesList()
        {
            categoriesList = repository.GetAll();
            categoriesBindingSource.DataSource = categoriesList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCategories(object? sender, EventArgs e)
        {
            var categories = new CategoriesModel();
            categories.IdCategoria = Convert.ToInt32(view.CategoriesId);
            categories.NameCategoria = view.CategoriesName;
            categories.ObservationCategoria = view.CategoriesObservation;

            try
            {
                new Common.ModelDataValidation().Validate(categories);
                if (view.IsEdit)
                {
                    repository.Edit(categories);
                    view.Message = "Category Edited Succesfuly";
                }
                else
                {
                    repository.Add(categories);
                    view.Message = "Category Added successfuly";
                }
                view.IsSuccesfull = true;
                loadAllOpenCategoriesList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccesfull = false;
                view.Message = ex.Message;
            }

        }

        private void CleanViewFields()
        {
            view.CategoriesId = "0";
            view.CategoriesName = "";
            view.CategoriesObservation = "";
        }

        private void DeleteSelectedCategories(object? sender, EventArgs e)
        {
            try
            {
                var categories = (CategoriesModel)categoriesBindingSource.Current;

                repository.Delete(categories.IdCategoria);
                view.IsSuccesfull = true;
                view.Message = "Pay Mode deleted successfully";
                loadAllOpenCategoriesList();
            }
            catch (Exception ex)
            {
                view.IsSuccesfull = false;
                view.Message = "An Error ocurred, could not delete pay mode";
            }
        }

        private void LoadSelectCategoriesToEdit(object? sender, EventArgs e)
        {
            var categories = (CategoriesModel)categoriesBindingSource.Current;

            view.CategoriesId = categories.IdCategoria.ToString();
            view.CategoriesName = categories.NameCategoria;
            view.CategoriesObservation = categories.ObservationCategoria;


            view.IsEdit = true;
        }

        private void AddNewCategories(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategories(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categoriesList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categoriesList = repository.GetAll();
            }
            categoriesBindingSource.DataSource = categoriesList;
        }
    }
}
