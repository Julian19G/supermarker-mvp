using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class ProductsPresenter
    {
        private IProductsView view;
        private IProductsRepository repository;
        private ICategoriesRepository categoriesRepository;
        private BindingSource productsBindingSource;
        private BindingSource categoriesBindingSource;
        private IEnumerable<ProductsModel> productsList;
        private IEnumerable<CategoriesModel> categoriesList;

        public ProductsPresenter(IProductsView view, IProductsRepository repository, ICategoriesRepository categoriesRepository)
        {
            this.productsBindingSource = new BindingSource();
            this.categoriesBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.categoriesRepository = categoriesRepository;

            this.view.SearchEvent += SearchProducts;
            this.view.AddNewEvent += AddNewProducts;
            this.view.EditEvent += LoadSelectProductsToEdit;
            this.view.DeleteEvent += DeleteSelectedProducts;
            this.view.SaveEvent += SaveProducts;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductsListBildSource(productsBindingSource);
            this.view.SetCategoriesListBildSource(categoriesBindingSource);

            loadAllOpenProductsList();
            loadAllOpenCategoriesList();

            this.view.Show();
        }

        private void loadAllOpenProductsList()
        {
            productsList = repository.GetAll();
            productsBindingSource.DataSource = productsList;
        }

        private void loadAllOpenCategoriesList()
        {
            categoriesList = categoriesRepository.GetAll();
            categoriesBindingSource.DataSource = categoriesList;
        }
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProducts(object? sender, EventArgs e)
        {
            var products = new ProductsModel();
            products.IdProducto = Convert.ToInt32(view.ProductsId);
            products.NameProducto = view.ProductsName;
            products.PriceProducto = Convert.ToInt32(view.ProductsPrice);
            products.StockProducto = Convert.ToInt32(view.ProductsStock);
            products.CategoryProducto = view.ProductsCategory;


            try
            {
                new Common.ModelDataValidation().Validate(products);
                if (view.IsEdit)
                {
                    repository.Edit(products);
                    view.Message = "Product Edited Succesfuly";
                }
                else
                {
                    repository.Add(products);
                    view.Message = "Product Added successfuly";
                }
                view.IsSuccesfull = true;
                loadAllOpenProductsList();
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
            view.ProductsId = "0";
            view.ProductsName = "";
            view.ProductsPrice = "";
            view.ProductsStock = "";
            view.ProductsCategory = "";
        }

        private void DeleteSelectedProducts(object? sender, EventArgs e)
        {
            try
            {
                var products = (ProductsModel)productsBindingSource.Current;

                repository.Delete(products.IdProducto);
                view.IsSuccesfull = true;
                view.Message = "Pay Mode deleted successfully";
                loadAllOpenProductsList();
            }
            catch (Exception ex)
            {
                view.IsSuccesfull = false;
                view.Message = "An Error ocurred, could not delete pay mode";
            }
        }

        private void LoadSelectProductsToEdit(object? sender, EventArgs e)
        {
            var productos = (ProductsModel)productsBindingSource.Current;

            view.ProductsId = productos.IdProducto.ToString();
            view.ProductsName = productos.NameProducto;
            view.ProductsStock = productos.StockProducto.ToString();
            view.ProductsPrice = productos.PriceProducto.ToString();
 

            view.IsEdit = true;
        }

        private void AddNewProducts(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProducts(object? sender, EventArgs e)
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
            productsBindingSource.DataSource = productsList;
        }
    }
}
