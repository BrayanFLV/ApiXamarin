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
    public partial class Productos : ContentPage
    {
        public Productos()
        {
            InitializeComponent();
            GetProPlayL();
            GetProXboxL();
            GetProNintendoL();
        }
        private async void GetProPlayL()
        {
            HttpClient client = new HttpClient();
            var playP = await client.GetStringAsync("http://localhost:3000/api/productos/play");
            var play = JsonConvert.DeserializeObject<List<PlayS>>(playP);
            playlist.ItemsSource = play;

        }

        private async void GetProXboxL()
        {
            HttpClient client = new HttpClient();
            var Xbox = await client.GetStringAsync("http://localhost:3000/api/productos/xbox");
            var pxbox = JsonConvert.DeserializeObject<List<XboxP>>(Xbox);
            xboxlist.ItemsSource = pxbox;

        }

        private async void GetProNintendoL()
        {
            HttpClient client = new HttpClient();
            var Nintendo = await client.GetStringAsync("http://localhost:3000/api/productos/nintendo");
            var pnint = JsonConvert.DeserializeObject<List<NintendoP>>(Nintendo);
            nintendolist.ItemsSource = pnint;

        }
    }
}