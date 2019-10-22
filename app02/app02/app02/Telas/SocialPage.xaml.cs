using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app02.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SocialPage : MasterDetailPage
	{
		public SocialPage ()
		{
			InitializeComponent ();
		}
        
        private void GoLoginPage(object sender, EventArgs args)
        {
            App.Current.MainPage = new Telas.LoginPage();
        }

        private void GoCelulaPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage( new Telas.CelulaPage());
            IsPresented = false;
        }

        private void GoMusicaPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Telas.MusicaPage());
            IsPresented = false;
        }
        
    }
}