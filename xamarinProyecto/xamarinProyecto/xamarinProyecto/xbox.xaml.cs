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
    public partial class xbox : ContentPage
    {
        public xbox()
        {
            InitializeComponent();
            GetProXbox();
        }
        private async void GetProXbox()
        {
            HttpClient client = new HttpClient();
            var Xbox = await client.GetStringAsync("http://localhost:3000/api/productos/xbox");
            var pxbox = JsonConvert.DeserializeObject<List<XboxP>>(Xbox);
            xbox1.ItemsSource = pxbox;

        }
    }
}