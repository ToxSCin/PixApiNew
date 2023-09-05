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
            logo.Source = ImageSource.FromResource("App1.Imagem.itauu.png");
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
            await botao.ScaleTo(1.2, 100, Easing.CubicOut);
            await botao.ScaleTo(1, 100, Easing.CubicIn);
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
            Button botao = (Button)sender;
            await botao.ScaleTo(1.2, 100, Easing.CubicOut);
            await botao.ScaleTo(1, 100, Easing.CubicIn);
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
            await botao.ScaleTo(1.2, 100, Easing.CubicOut);
            await botao.ScaleTo(1, 100, Easing.CubicIn);
           
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
            await botao.ScaleTo(1.2, 100, Easing.CubicOut);
            await botao.ScaleTo(1, 100, Easing.CubicIn);
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
            await botao.ScaleTo(1.2, 100, Easing.CubicOut);
            await botao.ScaleTo(1, 100, Easing.CubicIn);
        }
    }
}