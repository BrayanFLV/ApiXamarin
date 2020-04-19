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
    public partial class Admin : ContentPage
    {
        public Admin()
        {
            InitializeComponent();
        }

        private async void admiUsu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Usuarios());

        }

        private async void admiPro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Productos());
        }

        private void pedidos_Clicked(object sender, EventArgs e)
        {

        }
    }
}