using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarker_mvp.Models;
using Supermarker_mvp.Views;
using Supermarker_mvp._Repositories;

namespace Supermarker_mvp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;


        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;

            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowCustomersView += ShowCustomersView;
            this.mainView.ShowCategoriesView += ShowCategoriesView;
            this.mainView.ShowProductsView += ShowProductsView;
        }

        private void ShowProductsView(object? sender, EventArgs e)
        {
            IProductsView view = ProductsView.GetInstance((MainView)mainView);
            ProductsRepository repository = new ProductsRepository(sqlConnectionString);
            new ProductsPresenter(view, repository);
        }

        private void ShowCategoriesView(object? sender, EventArgs e)
        {
            ICategoriesView view = CategoriesView.GetInstance((MainView)mainView);
            ICategoriesRepository repository = new CategoriesRepository(sqlConnectionString);
            new CategoriesPresenter(view, repository);
        }

        private void ShowCustomersView(object? sender, EventArgs e)
        {
            ICustomersView view = CustomersView.GetInstance((MainView)mainView);
            ICustomersRepository repository = new CustomersRepository(sqlConnectionString);
            new CustomersPresenter(view, repository);
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }
    }
}
