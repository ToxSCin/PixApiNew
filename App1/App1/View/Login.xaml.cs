using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.View;
using static App1.View.Banco;
using SQLite;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
       
        private Banco.DatabaseContext _context;

        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }

        public Login()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("App1.Imagem.itauu.png");
            _context = new Banco.DatabaseContext(":memory:");
            string databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "database.db");
            _context = new Banco.DatabaseContext(databasePath);

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
            // Obtenha os valores digitados nos campos de CPF e Senha
            string cpf = txt_cpf.Text;
            string senha = txt_senha.Text;

            // Verifique se existe um registro com as credenciais informadas
            bool isValidCredentials = _context.IsValidCredentials(cpf, senha);

            if (isValidCredentials)
            {
                // Credenciais válidas, redirecione para a página principal do aplicativo
                App.Current.MainPage = new Menu();
            }
            else
            {
                // Credenciais inválidas, exiba uma mensagem de erro
                DisplayAlert("Erro", "Credenciais inválidas.", "OK");
            }

        }

        

        private async void Button_Clicked_1(object sender, EventArgs e)
        {

            // Botão Voltar (Volta Para A Pagina Anterior)
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