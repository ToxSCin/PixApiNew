using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.View;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }

        public Login()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("App1.Imagem.itauu.png");

    }
        private bool CheckCredentials(string cpf, string senha)
        {
            //Login Para Admin
            if (cpf == "999.999.999-99" && senha == "1")
            {
                return true;
            }
            else
            {
                return false;
            
            }
        }

        private async void cadastro_Clicked(object sender, EventArgs e)
        {

            try
            {
                App.Current.MainPage = new NavigationPage(new View.cadastro());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
            Button botao = (Button)sender;
            await botao.ScaleTo(1.2, 100, Easing.CubicOut);
            await botao.ScaleTo(1, 100, Easing.CubicIn);
        }

        private void user_Clicked_1(object sender, EventArgs e)
        {
            string CPF = txt_cpf.Text;
            string Senha = txt_senha.Text;
            string Nome = txt_name.Text;

            if (string.IsNullOrEmpty(CPF) || string.IsNullOrEmpty(Senha))
            {
                DisplayAlert("Erro de Login", "CPF e senha são obrigatórios.", "OK");
                return;
            }

            // Verifica se o CPF e a senha inseridada é valida
            bool isValidUser = CheckCredentials(CPF, Senha);

            if (isValidUser)
            {
                App.Current.MainPage = new NavigationPage(new View.Menu());
            }
            else
            {
                DisplayAlert("Erro de Login", "CPF ou senha inválidos.", "OK");
            }


        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
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
    }
}