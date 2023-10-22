using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp1.Models;
using System.Data;

namespace Supermarket_mvp1._Repositories
{
    internal class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(ProductModel productModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(ProductModel productModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Product ORDER BY Product_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.Product_Id = (int)reader["Product_Id"];
                        productModel.Product_Name = reader["Product_Name"].ToString();
                        productModel.Product_Price = reader["Product_Price"].ToString();
                        productModel.Product_Stock = reader["Product_Stock"].ToString();
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }

        public IEnumerable<ProductModel> GetByValue(string value)
        {
            var productList = new List<ProductModel>();
            int productId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Products WHERE Products_Id=@id or Products_Name LIKE @name+ '%' ORDER By Products_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.Product_Id = (int)reader["Products_Id"];
                        productModel.Product_Name = reader["Product_Name"].ToString();
                        productModel.Product_Price = reader["Produt_Price"].ToString();
                        productModel.Product_Stock = reader["Produt_Stock"].ToString();
                        productList.Add(productModel);

                    }
                }
            }
            return productList;
        }
    }
}
