using DatabaseOefening.Model;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatabaseOefening
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public App()
        {

            InitializeComponent();
            //NavigationPage toevoegen
            MainPage = new NavigationPage(new DatabaseTabel());
        }

        public App(string databaseLocation)
        {
            InitializeComponent();
            DatabaseLocation = databaseLocation;
            MainPage = new NavigationPage(new DatabaseTabel());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
