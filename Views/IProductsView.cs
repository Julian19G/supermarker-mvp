using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IProductsView
    {
        string ProductsId { get; set; }
        string ProductsName { get; set; }
        string ProductsStock { get; set; }
        string ProductsCategory { get; set; }
        string ProductsPrice { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccesfull { get; set; }
        string Message { get; set; }


        event EventHandler SearchEvent;
        event EventHandler SearchCategoriesEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProductsListBildSource(BindingSource productsList);
        void SetCategoriesListBildSource(BindingSource categoriesList);
        void Show();
    }
}
