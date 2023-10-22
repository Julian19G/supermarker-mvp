using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class ProductsModel
    {
        [DisplayName("PRODUCTO  ID")]
        public int IdProducto { get; set; }
        [DisplayName("Producto Name")]
        [Required(ErrorMessage = "Producto name is requerided")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Producto name must be between 3 and 50 characters")]
        public string NameProducto { get; set; }
        [DisplayName("PRICE  PRODUCTO")]
        public int PriceProducto { get; set; }
        [DisplayName("STOCK  PRODUCTO")]
        public int StockProducto { get; set; }
        [DisplayName("CATEGORIA  ID")]
        public int CategoryProducto { get; set; }

        internal void Add(ProductsModel productsModel)
        {
            throw new NotImplementedException();
        }
    }
}
