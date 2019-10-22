using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app02.Classes;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app02.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();


		}
        
        
        private void GoTabbed(object sender, EventArgs args)
        {
            if (txtUser.Text == "cleisson" && txtPswd.Text == "Kimberli14*")
                App.Current.MainPage = new TipoPagina.Tabbed.Abas();
            else
                DisplayAlert("Erro", "Usuário ou senha incorreto!", "OK");

        }

        private void GoSocialPage(object sender, EventArgs args)
        {
            App.Current.MainPage = new Telas.SocialPage();

        }

    }
}