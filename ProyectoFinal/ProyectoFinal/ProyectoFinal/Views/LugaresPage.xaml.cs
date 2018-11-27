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
	public partial class LugaresPage : ContentPage
	{
		public LugaresPage ()
		{
			InitializeComponent ();
            CargarLugares();

            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(6.2104336464231125, -75.57068936356820), Distance.FromKilometers(3)));

            var pin1 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.246363634000576, -75.59771299739168),
                Label = "La Pampa",
                Address = "Carrera 75#40-10",
                Id = "La Pampa",
            };
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.2101752, -75.5739697),
                Label = "SA-TA",
                Address = "Carrera 43E#11A-46",
                Id = "SA-TA",
            };
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.233566700000001, -75.56778689999999),
                Label = "Angus Brangus",
                Address = "Carrera 42#34-15",
                Id = "Angus Brangus",
            };
            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.232418600698259, -75.60457230077327),
                Label = "Sarku Japan",
                Address = "Calle 30A#82a-26",
                Id = "Sarku Japan",
            };
            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.2080310330031105, -75.56462332606316),
                Label = "Kabuki",
                Address = "Carrera 33#8A-37",
                Id = "Kabuki",
            };
            var pin6 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.217748263237816, -75.56509137153625),
                Label = "Wakame",
                Address = "Calle 18#35-69",
                Id = "Wakame",
            };
            var pin7 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.2086176, -75.56626749999998),
                Label = "Bao Bei",
                Address = "Carrera 36#8a-123",
                Id = "Bao Bei",
            };
            var pin8 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.217745, -75.565089),
                Label = "Parmessano",
                Address = "Transversal 39b#74b-17",
                Id = "Parmessano",
            };
            var pin9 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.2449642, -75.59492419999998),
                Label = "Romero",
                Address = "Calle 18#35-59",
                Id = "Romero",
            };
            var pin10 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.207344519141129, -75.56776511712434),
                Label = "Il Forno",
                Address = "Carrera 37A#8-09",
                Id = "Il Forno",
            };
            var pin11 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.2082227, -75.5671131),
                Label = "Pergamino",
                Address = "Carrera 37#8A-37",
                Id = "Pergamino",
            };
            var pin12 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.20886238, -75.56673241),
                Label = "Velvet",
                Address = "Carrera 37#8a-46",
                Id = "Velvet",
            };
            var pin13 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.19968, -75.57286),
                Label = "Starbucks",
                Address = "Carrera 43A#3Sur-92",
                Id = "Starbucks",
            };
            var pin14 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.2075, -75.56529),
                Label = "Bogotá beer company",
                Address = "Carrera 34#7-165",
                Id = "Bogotá beer company",
            };
            var pin15 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.2075, -75.56529),
                Label = "El Alemán Pues",
                Address = "Carrera 43b#11-76",
                Id = "El Alemán Pues",
            };
            var pin16 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(6.2083, -75.5674),
                Label = "Patrick's irish pub",
                Address = "Carrera 37A#8A-43",
                Id = "Patrick's irish pub",
            };

            MyMap.Pins.Add(pin1);
            MyMap.Pins.Add(pin2);
            MyMap.Pins.Add(pin3);
            MyMap.Pins.Add(pin4);
            MyMap.Pins.Add(pin5);
            MyMap.Pins.Add(pin6);
            MyMap.Pins.Add(pin7);
            MyMap.Pins.Add(pin8);
            MyMap.Pins.Add(pin9);
            MyMap.Pins.Add(pin10);
            MyMap.Pins.Add(pin11);
            MyMap.Pins.Add(pin12);
            MyMap.Pins.Add(pin13);
            MyMap.Pins.Add(pin14);
            MyMap.Pins.Add(pin15);
            MyMap.Pins.Add(pin16);
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