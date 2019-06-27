using FreshMvvmExample.PageModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FreshMvvmExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var page = FreshMvvm.FreshPageModelResolver.ResolvePageModel<UsersListPageModel>();
            var nagviagationContainer = new FreshMvvm.FreshNavigationContainer(page);
            MainPage = nagviagationContainer;          
   
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
