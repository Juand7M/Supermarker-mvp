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
    internal class CustomersRepository : BaseRepository, ICustomersRepository
    {
        public CustomersRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(CustomersModel customersModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Customers VALUES (@document, @firstName,@lastName,@address,@birthday,@phoneNumber,@email)";
                command.Parameters.Add("@document", SqlDbType.NVarChar).Value = customersModel.Document_Number;
                command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = customersModel.First_Name;
                command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = customersModel.Last_Name;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = customersModel.Address;
                command.Parameters.Add("@birthday", SqlDbType.Date).Value = customersModel.Birthday;
                command.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = customersModel.Phone_Number;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = customersModel.Email;
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
                command.CommandText = "DELETE FROM Customers WHERE Customers_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CustomersModel customersModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Customers
                                        SET Customers_Document_Number =@document,
                                        Customers_First_Name = @firstName,
                                        Customers_Last_Name = @lastName,
                                        Customers_Address = @address,
                                        Customers_Birthday = @birthday,
                                        Customers_Phone_Number = @phoneNumber,
                                        Customers_Email = @email
                                        WHERE Customers_Id =@id";
                command.Parameters.Add("@document", SqlDbType.NVarChar).Value = customersModel.Document_Number;
                command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = customersModel.First_Name;
                command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = customersModel.Last_Name;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = customersModel.Address;
                command.Parameters.Add("@birthday", SqlDbType.Date).Value = customersModel.Birthday;
                command.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = customersModel.Phone_Number;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = customersModel.Email;
                command.Parameters.Add("@id", SqlDbType.Int).Value = customersModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CustomersModel> GetAll()
        {
            var customersList = new List<CustomersModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customers ORDER BY Customers_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customersModel = new CustomersModel();
                        customersModel.Id = (int)reader["Customers_Id"];
                        customersModel.Document_Number = reader["Customers_Document_Number"].ToString();
                        customersModel.First_Name = reader["Customers_First_Name"].ToString();
                        customersModel.Last_Name = reader["Customers_Last_Name"].ToString();
                        customersModel.Address = reader["Customers_Address"].ToString();
                        customersModel.Birthday = reader["Customers_Birthday"] != DBNull.Value ? (DateTime)reader["Customers_Birthday"] : (DateTime?) null;
                        customersModel.Phone_Number = reader["Customers_Phone_Number"].ToString();
                        customersModel.Email = reader["Customers_Email"].ToString();
                        customersList.Add(customersModel);
                    }
                }
            }
            return customersList;
        }

        public IEnumerable<CustomersModel> GetByValue(string value)
        {
            var customersList = new List<CustomersModel>();
            int customersId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string customersFirst_Name = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Customers
                                        WHERE Customers_Id=@id or Customers_First_Name LIKE @name '%'
                                        ORDER By Customers_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = customersId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = customersFirst_Name;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customersModel = new CustomersModel();
                        customersModel.Id = (int)reader["Customers_Id"];
                        customersModel.Document_Number = reader["Customers_Document_Number"].ToString();
                        customersModel.First_Name = reader["Customers_First_Name"].ToString();
                        customersModel.Last_Name = reader["Customers_Last_Name"].ToString();
                        customersModel.Address = reader["Customers_Address"].ToString();
                        customersModel.Birthday = reader["Customers_Birthday"] != DBNull.Value ? (DateTime)reader["Customers_Birthday"] : (DateTime?)null;
                        customersModel.Phone_Number = reader["Customers_Phone_Number"].ToString();
                        customersModel.Email = reader["Customers_Email"].ToString();
                        customersList.Add(customersModel);
                    }
                }
            }

            return customersList;
        }
    }
}
