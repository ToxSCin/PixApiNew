using App1.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class App : Application
    {
        public static Model.Correntista DadosCorrentista { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.Login());


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
