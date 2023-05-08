using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if (cpf == "123.456.789-00" && senha == "password123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void cadastro_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}