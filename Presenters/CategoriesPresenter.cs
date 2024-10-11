﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarker_mvp.Views;
using Supermarker_mvp.Models;

namespace Supermarker_mvp.Presenters
{
    internal class CategoriesPresenter
    {
        private ICategoriesView view;
        private ICategoriesRepository repository;
        private BindingSource categoriesBindingSource;
        private IEnumerable<CategoriesModel> categoriesList;

        public CategoriesPresenter(ICategoriesView view, ICategoriesRepository repository)
        {
            this.categoriesBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategories;
            this.view.AddNewEvent += AddNewCategories;
            this.view.EditEvent += LoadSelectCategorieToEdit;
            this.view.DeleteEvent += DeleteSelectedCategories;
            this.view.SaveEvent += SaveCategories;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoriesListBildingSource(categoriesBindingSource);

            LoadAllCategoriesList();

            this.view.Show();

        }

        private void LoadAllCategoriesList()
        {
            categoriesList = repository.GetAll();
            categoriesBindingSource.DataSource = categoriesList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCategories(object? sender, EventArgs e)
        {
            var categories = new CategoriesModel();
            categories.Id = Convert.ToInt32(view.CategoriesId);
            categories.Name = view.CategoriesName;
            categories.Description = view.CategoriesDescription;

            try
            {
                new Common.ModelDataValidation().Validate(categories);
                if (view.IsEdit)
                {
                    repository.Edit(categories);
                    view.Message = "Categories Edit Successfuly";
                }
                else
                {
                    repository.Add(categories);
                    view.Message = "Categories added Successfuly";
                }
                view.IsSuccessful = true;
                LoadAllCategoriesList();
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
            view.CategoriesId = "0";
            view.CategoriesName = "";
            view.CategoriesDescription = "";
        }

        private void DeleteSelectedCategories(object? sender, EventArgs e)
        {
            try
            {
                var Categories = (CategoriesModel)categoriesBindingSource.Current;
                repository.Delete(Categories.Id);
                view.IsSuccessful = true;
                view.Message = "Categories deleted Successfuly";
                LoadAllCategoriesList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete Categories";
            }
        }

        private void LoadSelectCategorieToEdit(object? sender, EventArgs e)
        {
            var categories = (CategoriesModel)categoriesBindingSource.Current;

            view.CategoriesId = categories.Id.ToString();
            view.CategoriesName = categories.Name;
            view.CategoriesDescription = categories.Description;

            view.IsEdit = true;
        }

        private void AddNewCategories(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategories(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categoriesList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categoriesList = repository.GetAll();
            }
            categoriesBindingSource.DataSource = categoriesList;
        }

    }
}
