﻿using System;
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
using App1.Service;

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

        private async void user_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                Model.Correntista c = await DataServiceCorrentista.SaveAsync(new Model.Correntista
                {
                    nome = txt_name.Text,
                    cpf = txt_cpf.Text,
                    senha = txt_senha.Text,
                });

                if (c.id != null)
                {




                    await Navigation.PushAsync(new View.Menu());
                }
                else
                    throw new Exception("Erro.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

    }

        

       
        
    }