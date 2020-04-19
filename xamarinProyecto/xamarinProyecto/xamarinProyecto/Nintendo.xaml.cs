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
    public partial class Nintendo : ContentPage
    {
        public Nintendo()
        {
            InitializeComponent();
            GetProNintendo();
        }

        private async void GetProNintendo()
        {
            HttpClient client = new HttpClient();
            var Nintendo = await client.GetStringAsync("http://localhost:3000/api/productos/nintendo");
            var pnint = JsonConvert.DeserializeObject<List<NintendoP>>(Nintendo);
            nintendo1.ItemsSource = pnint;

        }


    }
}