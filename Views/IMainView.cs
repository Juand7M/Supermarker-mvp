﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarker_mvp.Views
{
    internal interface IMainView
    {
        event EventHandler ShowPayModeView;
        event EventHandler ShowCustomersView;
        event EventHandler ShowCategoriesView;
        event EventHandler ShowProductsView;
    }
}
