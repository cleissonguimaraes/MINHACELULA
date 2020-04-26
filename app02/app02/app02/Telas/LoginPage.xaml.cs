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
	public partial class LoginPage : ContentPage
	{
        DataService dataService;
        List<Usuario> usuarios;

        public LoginPage ()
		{

                InitializeComponent();

            dataService = new DataService();

		}
        
        
        private async void GoTabbed(object sender, EventArgs args)
        {
            App.Current.MainPage = new TipoPagina.Tabbed.Abas();
           /* usuarios = await dataService.GetUsuariosAsync();
            foreach (Usuario us in usuarios)
            {
                if (us.Email == txtUser.Text && us.Password == txtPswd.Text)
                {
                    App.Current.MainPage = new TipoPagina.Tabbed.Abas();
                }
                else
                {
                    await DisplayAlert("Erro", "Usuário ou senha incorreto!", "OK");
                }
            }*/
        }




        private void GoSocialPage(object sender, EventArgs args)
        {
            App.Current.MainPage = new Telas.SocialPage();

        }

    }
}