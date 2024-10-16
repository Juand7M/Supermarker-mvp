﻿using System;
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
                command.CommandText = "DELETE FROM Products WHERE Product_Id = @id";
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
                command.CommandText = @"UPDATE Products SET Product_Name = @name,
                                        Product_Price = @price,
                                        Product_Stock = @stock,
                                        Product_Categories_Id = @categoriesId
                                        WHERE Product_Id = @Id";
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
                command.CommandText = "SELECT * FROM Products ORDER BY Product_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.Id = (int)reader["Product_Id"];
                        productsModel.Name = reader["Product_Name"].ToString();
                        productsModel.Price = reader["Product_Price"].ToString();
                        productsModel.Stock = reader["Product_Stock"].ToString();
                        productsModel.Categories_Id = reader["Product_Categories_Id"].ToString();
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
                command.CommandText = @"SELECT * FROM Products WHERE Product_Id=@id or Product_Name LIKE @name+ '%'
                                      ORDER by Product_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productsId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.Id = (int)reader["Product_Id"];
                        productsModel.Name = reader["Product_Name"].ToString();
                        productsModel.Price = reader["Product_Price"].ToString();
                        productsModel.Stock = reader["Product_Stock"].ToString();
                        productsModel.Categories_Id = reader["Product_Categories_Id"].ToString();
                        productsList.Add(productsModel);
                    }
                }
            }

            return productsList;
        }
    }
}
