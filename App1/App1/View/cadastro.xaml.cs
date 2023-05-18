using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static App1.Banco.Banco;

namespace App1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class cadastro : ContentPage
    {
        string CPF;
        string NOME;
        string SENHA;

        private SQLiteConnection database;
        public cadastro()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("App1.Imagem.itauu.png");

            
            string databasePath = DependencyService.Get<Banco.Banco>().GetDatabasePath();
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Usuario>(); // Cria a tabela do banco de dados se não existir
        }


        private async void Button_Clicked(object sender, EventArgs e)
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
            try
            {
                // Salva os dados do usuário no banco de dados
                Usuario usuario = new Usuario
                {
                    CPF = txt_cpf.Text,
                    Nome = txt_nome.Text,
                    Senha = txt_senha.Text
                };
                database.Insert(usuario);

                await DisplayAlert("Sucesso", "Usuário cadastrado com sucesso.", "OK");
                App.Current.MainPage = new NavigationPage(new View.Login());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
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