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
        public Login()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("App1.Imagem.itauu.png");
        }



        private void user_Clicked(object sender, EventArgs e)
        {
            string cpf = txt_cpf.Text;
            string senha = txt_senha.Text;

            if (string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(senha))
            {
                DisplayAlert("Erro de Login", "CPF e senha são obrigatórios.", "OK");
                return;
            }

            // Verifica se o CPF e a senha inseridada é valida
            bool isValidUser = CheckCredentials(cpf, senha);

            if (isValidUser)
            {
                // Navegar para a próxima página ou fornecer acesso às funcionalidades protegidas pelo login
                // Exemplo:
                // Navigation.PushAsync(new HomePage());
                // Não feita
            }
            else
            {
                DisplayAlert("Erro de Login", "CPF ou senha inválidos.", "OK");
            }
        }
        private bool CheckCredentials(string cpf, string senha)
        {
            //Login Para Admin
            if (cpf == "999.999.999-99" && senha == "zzxxccvv123")
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
        }

        private async void user_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new View.Menu());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
        }
    }
}