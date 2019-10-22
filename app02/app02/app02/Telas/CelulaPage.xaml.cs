using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app02.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CelulaPage : ContentPage
	{


        public CelulaPage ()
		{
        InitializeComponent ();
            var map = new Map(
    MapSpan.FromCenterAndRadius(
            new Position(-19.971992, -44.185547), Distance.FromKilometers(1)));
            MapContainer.Children.Add(map);
            /* {
                 IsShowingUser = true,
                 HeightRequest = 100,
                 WidthRequest = 960,
                 VerticalOptions = LayoutOptions.FillAndExpand
             };
             var stack = new StackLayout { Spacing = 0 };
             map.MapType = MapType.Hybrid;
             stack.Children.Add(map);
             Content = stack;*/
            map.IsShowingUser = true;
            var Celula1 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-19.969578, -44.191237),
                Label = "F5 em Cristo I - Sábado 17:30",
                Address = "Rua Pedro II, 672 A, Filadelfia",
            };
            var Celula2 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-19.970604, -44.184887),
                Label = "F5 em Cristo II - Sábado 18:00",
                Address = "Rua Leozino de Oliveira, 417, Filadelfia",
            };
            var Celula3 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-19.971898, -44.185510),
                Label = "Semear I - Terça 19:30",
                Address = "Rua Leozino de Oliveira, 722, Filadelfia",
            };

            map.Pins.Add(Celula1);
            map.Pins.Add(Celula2);
            map.Pins.Add(Celula3);

        }




    }
}