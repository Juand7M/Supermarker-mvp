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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(CustomersModel customersModel)
        {
            throw new NotImplementedException();
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
                                        ORDER By Pay_Mode_Id DESC";
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
