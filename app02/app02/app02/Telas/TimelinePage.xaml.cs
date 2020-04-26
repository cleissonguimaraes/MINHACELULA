using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app02.Classes;
using app02.Service;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app02.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TimelinePage : ContentPage
	{

        DataService dataService;
        List<Usuario> usuarios;

        public TimelinePage ()
		{
			InitializeComponent ();
            dataService = new DataService();
            AtualizaDados();
        }

        async void AtualizaDados()
        {
            usuarios = await dataService.GetUsuariosAsync();
            listaUsuarios.ItemsSource = usuarios.OrderBy(item => item.Nome).ToList();
        }
    }
}