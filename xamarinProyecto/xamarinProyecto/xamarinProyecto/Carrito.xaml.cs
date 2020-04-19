using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinProyecto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carrito : ContentPage
    {
        public Carrito()
        {
            InitializeComponent();
            Getcarrito();
        }

        private async void Getcarrito()
        {
            HttpClient client = new HttpClient();
            var productos = await client.GetStringAsync("http://localhost:3000/api/productos/play1");
            var carrito = JsonConvert.DeserializeObject<List<PlayS>>(productos);
            carro.ItemsSource = carrito;
        }
    }
}