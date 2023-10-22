using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class ProductsRepository : BaseRepository, IProductsRepository
    {
        public ProductsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(ProductsModel productsModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(ProductsModel productsModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductsModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductsModel> GetByValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
