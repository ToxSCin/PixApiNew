using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Globalization;

namespace App1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pix : ContentPage
    {
        public Pix()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("App1.Imagem.itauu.png");
            
        }

      
        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new View.Menu());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
            Button botao = (Button)sender;
            await botao.ScaleTo(1.2, 100, Easing.CubicOut); 
            await botao.ScaleTo(1, 100, Easing.CubicIn);
        }

        private async void Enviar_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new View.Pix());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }

            await DisplayAlert("Enviado", "Pix Enviado Com Sucesso", "OK");

            Button botao = (Button)sender;
            await botao.ScaleTo(1.2, 100, Easing.CubicOut);
            await botao.ScaleTo(1, 100, Easing.CubicIn);
        }
    }
}