using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.View;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace App1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
            anun.Source = ImageSource.FromResource("App1.Imagem.anun.png");
            ToxBanco.Source = ImageSource.FromResource("App1.Imagem.ToxBankk.png");
        }

        private async void Saldo(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new View.Saldo());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
            Button botao = (Button)sender;
            
        }

        

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new View.Saldo());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
            Button botao = (Button)sender;
           
           
        }

        private async void Conta(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new View.LerQr());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
            Button botao = (Button)sender;
            
        }
        private async void Voltar(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new View.Login());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
            Button botao = (Button)sender;
            
        }

        private void Banco_DescendantAdded(object sender, ElementEventArgs e)
        {

        }

        private async void Pix(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new View.Pix());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
            
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {

        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {

        }

        private void ImageButton_Clicked_3(object sender, EventArgs e)
        {

        }

        private async void Perfil(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new View.Profile());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
            Button botao = (Button)sender;
        }
    }
}