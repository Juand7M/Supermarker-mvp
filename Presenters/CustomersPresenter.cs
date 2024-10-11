using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarker_mvp.Views;
using Supermarker_mvp.Models;

namespace Supermarker_mvp.Presenters
{
    internal class CustomersPresenter
    {
        private ICustomersView view;
        private ICustomersRepository repository;
        private BindingSource customersBindingSource;
        private IEnumerable<CustomersModel> customersList;

        public CustomersPresenter(ICustomersView view, ICustomersRepository repository)
        {
            this.customersBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCustomers;
            this.view.AddNewEvent += AddNewCustomers;
            this.view.EditEvent += LoadSelectCustomersToEdit;
            this.view.DeleteEvent += DeleteSelectedCustomers;
            this.view.SaveEvent += SaveCustomers;
            this.view.CancelEvent += CancelAction;

            this.view.SetcustomersListBildingSource(customersBindingSource);

            loadAllCustomersList();

            this.view.Show();

        }

        private void loadAllCustomersList()
        {
            customersList = repository.GetAll();
            customersBindingSource.DataSource = customersList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCustomers(object? sender, EventArgs e)
        {
            
            var customers = new CustomersModel();
            customers.Id = Convert.ToInt32(view.CustomersId);
            customers.Document_Number = view.CustomersDocument_Number;
            customers.First_Name = view.CustomersFirst_Name;
            customers.Last_Name = view.CustomersLast_Name;
            customers.Address = view.CustomersAddress;
            customers.Birthday = string.IsNullOrEmpty(view.CustomersBirthday)
            ? (DateTime?)null
            : DateTime.Parse(view.CustomersBirthday);
            customers.Phone_Number = view.CustomersPhone_Number;
            customers.Email = view.CustomersEmail;

            try
            {
                new Common.ModelDataValidation().Validate(customers);
                if (view.IsEdit)
                {
                    repository.Edit(customers);
                    view.Message = "PayMode edited sucessfuly";
                }
                else
                {
                    repository.Add(customers);
                    view.Message = "PayMode added successfuly";
                }
                view.IsSuccessful = true;
                loadAllCustomersList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.CustomersId = "0";
            view.CustomersDocument_Number = "";
            view.CustomersFirst_Name = "";
            view.CustomersLast_Name = "";
            view.CustomersAddress = "";
            view.CustomersBirthday = "";
            view.CustomersPhone_Number = "";
            view.CustomersEmail = "";
        }

        private void DeleteSelectedCustomers(object? sender, EventArgs e)
        {
            try
            {
                var customers = (CustomersModel)customersBindingSource.Current;

                repository.Delete(customers.Id);
                view.IsSuccessful = true;
                view.Message = "Customers deleted successfully";
                loadAllCustomersList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete Customers";
            }
        }

        private void LoadSelectCustomersToEdit(object? sender, EventArgs e)
        {
            //Se obtiene el objeto del datagridview que se encuentra seleccionado
            var customers = (CustomersModel)customersBindingSource.Current;

            // Se cambia el contenido de las cajas de texto por el objeto recuperado
            // del datagridview
            view.CustomersId = customers.Id.ToString();
            view.CustomersDocument_Number = customers.Document_Number;
            view.CustomersFirst_Name = customers.First_Name;
            view.CustomersLast_Name = customers.Last_Name;
            view.CustomersAddress = customers.Address;
            view.CustomersBirthday = customers.Birthday.ToString();
            view.CustomersPhone_Number = customers.Phone_Number;
            view.CustomersEmail = customers.Email;

            

            //Se establece el modo como edicion
            view.IsEdit = true;
        }

        private void AddNewCustomers(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCustomers(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                customersList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                customersList = repository.GetAll();
            }
            customersBindingSource.DataSource = customersList;
        }
    }
}
