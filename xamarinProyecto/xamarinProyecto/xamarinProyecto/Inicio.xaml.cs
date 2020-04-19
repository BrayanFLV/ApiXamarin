using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinProyecto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private async void play_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Play());
        }

        private async void xbox_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new xbox());
        }

        private async void nintendo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Nintendo());
        }
    }
}