using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using Supermarket_mvp1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp1._Repositories
{
    internal class CategoriesRepository : BaseRepository, ICategorieRepository
    {
        public CategoriesRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(CategoriesModel categorieMode)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSER INTO Categories VALUES (@name, @observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categorieMode.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = categorieMode.Observation;
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
                command.CommandText = "DELETE FRROM Categories WHERE Pay_Mode_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CategoriesModel categorieMode)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE PayMode
                                        SET Categories_Name =@name,
                                        Categories_Observation = @observation
                                        WHERE Categories_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categorieMode.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = categorieMode.Observation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = categorieMode.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoriesModel> GetAll()
        {
            var categoriesList = new List<PayModeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM PayMode ORDER BY Pay_Mode_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categorieMode = new PayModeModel();
                        categorieMode.Id = (int)reader["Pay_Mode_Id"];

                        categorieMode.Name = reader["Pay_Mode_Name"].ToString();
                        categorieMode.Observation = reader["Pay_Mode_Observation"].ToString();
                        categoriesList.Add(categorieMode);
                    }
                }
            }
            return (IEnumerable<CategoriesModel>)categoriesList;
        }

        public IEnumerable<CategoriesModel> GetByValue(string value)
        {
            var categoriesList = new List<PayModeModel>();
            int categorieModeId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categorieModeName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM PayMode
                                        WHERE Pay_Mode_Id=@id or Pay_Mode_Name LIKE @name+ '%'
                                        ORDER By Pay_Mode_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = categorieModeId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categorieModeName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categorieMode = new PayModeModel();
                        categorieMode.Id = (int)reader["Pay_Mode_Id"];
                        categorieMode.Name = reader["Pay_Mode_Name"].ToString();
                        categorieMode.Observation = reader["Pay_Mode_Observation"].ToString();
                        categoriesList.Add(categorieMode);
                    }
                }
            }
            return (IEnumerable<CategoriesModel>)categoriesList;
        }
    }
}
