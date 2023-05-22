using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLitePCL;
using SQLite;
using static App1.View.Banco;

namespace App1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class cadastro : ContentPage
    {
        public RegistroModel NovoRegistro { get; set; }
        private Banco.DatabaseContext _context;

        public cadastro()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("App1.Imagem.itauu.png");
            NovoRegistro = new RegistroModel();
            var databasePath = ":memory:";
            _context = new Banco.DatabaseContext(databasePath);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Preencher os dados do novo registro
                NovoRegistro.CPF = txt_cpf.Text;
                NovoRegistro.NOME = txt_nome.Text;
                NovoRegistro.SENHA = txt_senha.Text;

                // Salvar o registro no banco de dados
                _context.Insert(NovoRegistro);

                await DisplayAlert("Sucesso", "Usuário cadastrado com sucesso.", "OK");
                App.Current.MainPage = new NavigationPage(new View.Login());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new View.Login());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
        }
    }
}
