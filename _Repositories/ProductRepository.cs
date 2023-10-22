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
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Products VALUES(@name, @observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = productModel.Observation;

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

        public void Edit(ProductModel productModel)
        {
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"UPDATE Products 
                                            SET Products_Name = @name,
                                            Products_Observation = @observation
                                            WHERE Products_Id = @id";
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                    command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = productModel.Observation;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = productModel.Id;
                    command.ExecuteNonQuery();
                }
            }
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
