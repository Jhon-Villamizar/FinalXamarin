using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetallePage : ContentPage
	{
		public DetallePage (Lugar lugar)
		{
			InitializeComponent ();
            BindingContext = lugar;
        }

    }
}