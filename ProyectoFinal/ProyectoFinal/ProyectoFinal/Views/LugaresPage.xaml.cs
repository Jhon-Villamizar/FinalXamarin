using Newtonsoft.Json;
using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LugaresPage : ContentPage
	{
		public LugaresPage ()
		{
			InitializeComponent ();
            CargarLugares();
        }
        private async void CargarLugares()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://www.guialocalapi.somee.com");
            var request = await client.GetAsync("/api/Guia");
            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var lugares = JsonConvert.DeserializeObject<List<Lugar>>(responseJson);
                listaLugares.ItemsSource = lugares;
            }
            else
            {
                await DisplayAlert("Lo Sentimos!", "Ha Ocurrido un error de comunicacion", "OK");
            }
        }

        private async void Item_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var lugar = e.SelectedItem as Lugar;
            await Navigation.PushAsync(new DetallePage(lugar));
        }
    }
}