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
    public partial class Saldo : ContentPage
    {
        public Saldo()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("App1.Imagem.itauu.png");

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}