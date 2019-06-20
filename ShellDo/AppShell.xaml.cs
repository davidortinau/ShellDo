using System;
using System.Collections.Generic;
using ShellDo.Views;
using Xamarin.Forms;

namespace ShellDo
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("detail", typeof(ItemDetailPage));
            Routing.RegisterRoute("new", typeof(NewItemPage));
        }
    }
}
