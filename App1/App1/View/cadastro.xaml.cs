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
using App1.Service;
using App1.Model;

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
                Model.Correntista c = await DataServiceCorrentista.SaveAsync(new Model.Correntista
                {
                    nome = txt_nome.Text,
                    cpf = txt_cpf.Text,
                    senha = txt_senha.Text,
                    data_nascimento = dtcpk_nascimento.Date,
                    email = txt_email.Text,
                }) ;

                if (c.id != null)
                {
                    
                   

                   
                    await Navigation.PushAsync(new View.Login());
                }
                else
                    throw new Exception("Ocorreu um erro ao salvar seu cadastro.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                await DisplayAlert("Ops!", ex.Message, "OK");
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
