using Newtonsoft.Json;
using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LugaresPage : TabbedPage
	{
		public LugaresPage ()
		{
			InitializeComponent ();
            CargarLugares();

            var MyMap = new CustomMap
            {
                MapType = MapType.Street,
            };

            var pin = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(6.2104336464231125, -75.57068936356828),
                Label = "Xamarin San Francisco Office",
                Address = "394 Pacific Ave, San Francisco CA",
                Id = "Xamarin",
                Url = "http://xamarin.com/about/"
            };

            MyMap.CustomPins = new List<CustomPin> { pin };
            MyMap.Pins.Add(pin);
            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(6.2104336464231125, -75.57068936356828), Distance.FromKilometers(5)));

            Content = MyMap;

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