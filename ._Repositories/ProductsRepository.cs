using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarker_mvp.Models;
using System.Data;

namespace Supermarker_mvp._Repositories
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
                command.CommandText = "INSERT INTO Products VALUES (@name, @price, @stock, @categoriesId)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsModel.Name;
                command.Parameters.Add("@price", SqlDbType.NVarChar).Value = productsModel.Price;
                command.Parameters.Add("@stock", SqlDbType.NVarChar).Value = productsModel.Stock;
                command.Parameters.Add("@categoriesId", SqlDbType.NVarChar).Value = productsModel.Categories_Id;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection?.Open();
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
                command.CommandText = @"UPDATE Products SET Products_Name = @name,
                                        Products_Price = @price,
                                        Products_Stock = @stock,
                                        Products_Categories_Id = @categoriesId
                                        WHERE Products_Id = @Id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsModel.Name;
                command.Parameters.Add("@price", SqlDbType.NVarChar).Value = productsModel.Price;
                command.Parameters.Add("@stock", SqlDbType.NVarChar).Value = productsModel.Stock;
                command.Parameters.Add("@categoriesId", SqlDbType.NVarChar).Value = productsModel.Categories_Id;
                command.Parameters.Add("@id", SqlDbType.Int).Value = productsModel.Id;
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
                command.CommandText = "SELECT * FROM Products ORDER BY Products_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.Id = (int)reader["Products_Id"];
                        productsModel.Name = reader["Products_Name"].ToString();
                        productsModel.Price = reader["Products_Price"].ToString();
                        productsModel.Stock = reader["Products_Stock"].ToString();
                        productsModel.Categories_Id = reader["Products_Categories_Id"].ToString();
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
                command.CommandText = @"SELECT * FROM Products WHERE Products_Id=@id or Products_Name LIKE @name+ '%'
                                      ORDER by Products_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productsId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.Id = (int)reader["Products_Id"];
                        productsModel.Name = reader["Products_Name"].ToString();
                        productsModel.Price = reader["Products_Price"].ToString();
                        productsModel.Stock = reader["Products_Stock"].ToString();
                        productsModel.Categories_Id = reader["Products_Categories_Id"].ToString();
                        productsList.Add(productsModel);
                    }
                }
            }

            return productsList;
        }
    }
}
