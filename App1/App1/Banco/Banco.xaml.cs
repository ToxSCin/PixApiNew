using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using App1.Banco;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Banco
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Banco : ContentPage
    {
        public Banco()
        {
            InitializeComponent();
        }
        public class Usuario
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }

            public string CPF { get; set; }

            public string Nome { get; set; }

            public string Senha { get; set; }
        }
        public interface IDatabasePath
        {
            string GetDatabasePath();
        }



    }
}