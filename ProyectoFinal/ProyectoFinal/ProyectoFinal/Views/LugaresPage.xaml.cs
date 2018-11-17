using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private void CargarLugares()
        {
            var listado = new List<Lugar>
            {
                new Lugar{Tipo="Restaurantes", Descripcion="Enacuentra los mejores lugares de la ciudad para comer", Imagen="restaurates.jpg"},
                new Lugar{Tipo="Bares", Descripcion="Enacuentra los mejores bares de la ciudad", Imagen="bares2.jpg"},
                new Lugar{Tipo="Cafés", Descripcion="Enacuentra los mejores cafés de la ciudad", Imagen="cafes.jpg"}
            };
            listaLugares.ItemsSource = listado;
        }

        private async void Item_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var lugar = e.SelectedItem as Lugar;
            await Navigation.PushAsync(new DetalleLugarPage(lugar));
        }
    }
}