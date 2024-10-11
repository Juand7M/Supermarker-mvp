using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarker_mvp.Models;
using Supermarker_mvp.Views;

namespace Supermarker_mvp.Presenters
{
    internal class ProductsPresenter
    {
        private IProductsView view;
        private IProductsRepository repository;
        private BindingSource productsBindingSource;
        private IEnumerable<ProductsModel> productsList;

        public ProductsPresenter(IProductsView view, IProductsRepository repository)
        {
            this.productsBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProducts;
            this.view.AddNewEvent += AddNewProducts;
            this.view.EditEvent += LoadSelectProductsToEdit;
            this.view.DeleteEvent += DeleteSelectedProducts;
            this.view.SaveEvent += SaveProducts;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductsListBildingSource(productsBindingSource);

            LoadAllProductsList();

            this.view.Show();
        }

        private void LoadAllProductsList()
        {
            productsList = repository.GetAll();
            productsBindingSource.DataSource = productsList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProducts(object? sender, EventArgs e)
        {
            var products = new ProductsModel();
            products.Id = Convert.ToInt32(view.ProductsId);
            products.Name = view.ProductsName;
            products.Price = view.ProductsPrice;
            products.Stock = view.ProductsStock;
            products.Categories_Id = view.ProductsCategoriesId;

            try
            {
                new Common.ModelDataValidation().Validate(products);
                if (view.IsEdit)
                {
                    repository.Edit(products);
                    view.Message = "Products Edit Successfuly";
                }
                else
                {
                    repository.Add(products);
                    view.Message = "Products added Successfuly";
                }
                view.IsSuccessful = true;
                LoadAllProductsList();
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
            view.ProductsId = "0";
            view.ProductsName = "";
            view.ProductsPrice = "";
            view.ProductsStock = "";
            view.ProductsCategoriesId = "";
        }

        private void DeleteSelectedProducts(object? sender, EventArgs e)
        {
            try
            {
                var products = (ProductsModel)productsBindingSource.Current;
                repository.Delete(products.Id);
                view.IsSuccessful = true;
                view.Message = "Products deleted Successfuly";
                LoadAllProductsList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete Products";
            }
        }

        private void LoadSelectProductsToEdit(object? sender, EventArgs e)
        {
            var products = (ProductsModel)productsBindingSource.Current;

            view.ProductsId = products.Id.ToString();
            view.ProductsName = products.Name;
            view.ProductsPrice = products.Price;
            view.ProductsStock = products.Stock;
            view.ProductsCategoriesId = products.Categories_Id;

            view.IsEdit = true;
        }

        private void AddNewProducts(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProducts(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productsList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productsList = repository.GetAll();
            }
            productsBindingSource.DataSource = productsList;
        }
    }
}
