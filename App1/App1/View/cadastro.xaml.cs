using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Banco; // Removi o "Banco" duplicado aqui
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class cadastro : ContentPage
    {
        public string CPF { get; set; }
        public string NOME { get; set; }
        public string SENHA { get; set; }

        public cadastro()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("App1.Imagem.itauu.png");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Criando Cadastro Para Colocar Na "Login"
                var novoCadastro = new cadastro
                {
                    CPF = txt_cpf.Text,
                    NOME = txt_nome.Text,
                    SENHA = txt_senha.Text
                };


                // Salvar o cadastro no banco de dados
                var databasePath = DependencyService.Get<IDatabasePath>().GetDatabasePath();
                var context = new DatabaseContext(databasePath);
                context.Insert(novoCadastro);

                await DisplayAlert("Sucesso", "Usuário cadastrado com sucesso.", "OK");
                await Navigation.PopAsync(); //Volta para tela de login dps de se registrar
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
                //Caso não funcione ele dara erro "provalmente" erro na instancia entre banco e o App1.Banco.Banco;
            }
        }


        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }
    }
}
