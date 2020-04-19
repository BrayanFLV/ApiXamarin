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
    public partial class Usuarios : ContentPage
    {
        public Usuarios()
        {
            InitializeComponent();
            GetUsuario();
        }
        private async void GetUsuario()
        {
            HttpClient client = new HttpClient();
            var usuario = await client.GetStringAsync("http://localhost:3000/api/productos/usuarios");
            var usu = JsonConvert.DeserializeObject<List<UsuariosL>>(usuario);
            usuarios1.ItemsSource = usu;

        }
    }
}