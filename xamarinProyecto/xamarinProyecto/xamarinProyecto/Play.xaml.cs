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
    public partial class Play : ContentPage
    {
        public Play()
        {
            InitializeComponent();
            GetProPlay();
        }
        private async void GetProPlay()
        {
            HttpClient client = new HttpClient();
            var playP= await client.GetStringAsync("http://localhost:3000/api/productos/play");
            var play = JsonConvert.DeserializeObject<List<PlayS>>(playP);
            play1.ItemsSource = play;
    
        }
        private async void carrito_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Carrito());
        }
    }
}