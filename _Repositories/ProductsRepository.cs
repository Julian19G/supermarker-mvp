using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Products VALUES (@name, @price, @stock, @category)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsModel.NameProducto;
                command.Parameters.Add("@price", SqlDbType.Int).Value = productsModel.PriceProducto;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productsModel.StockProducto;
                command.Parameters.Add("@category", SqlDbType.NVarChar).Value = productsModel.CategoryProducto;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Products WHERE Products_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProductsModel productsModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Products
                SET Products_Name =@name,
                Products_Price = @price
                WHERE Products_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsModel.NameProducto;
                command.Parameters.Add("@price", SqlDbType.Int).Value = productsModel.PriceProducto;
                command.Parameters.Add("@id", SqlDbType.Int).Value = productsModel.IdProducto;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProductsModel> GetAll()
        {
            var productsList = new List<ProductsModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Products ORDER BY Products_ID DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.IdProducto = (int)reader["Products_ID"];
                        productsModel.NameProducto = reader["Products_Name"].ToString();
                        productsModel.PriceProducto = (int)reader["Products_Price"];
                        productsModel.StockProducto = (int)reader["Products_Stock"];
                        productsModel.CategoryProducto = reader["Products_Categories"].ToString();
                        productsList.Add(productsModel);
                    }
                }
            }
            return productsList;
        }

        public IEnumerable<ProductsModel> GetByValue(string value)
        {
            var productsList = new List<ProductsModel>();
            int productsId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productsName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Products
                                      WHERE Products_Id=@id or Products_Name LIKE @name+ '%'
                                      ORDER By Products_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productsId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.IdProducto = (int)reader["Providers_Id"];
                        productsModel.NameProducto = reader["Providers_Name"].ToString();
                        productsModel.PriceProducto = (int)reader["Price_Id"];
                        productsModel.StockProducto = (int)reader["Stock_Id"];
                        productsModel.Add(productsModel);
                    }
                }
            }
            return productsList;
        }
    }
}
