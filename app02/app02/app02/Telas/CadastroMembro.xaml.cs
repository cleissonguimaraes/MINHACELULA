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
	public partial class CadastroMembro : ContentPage
	{
		public CadastroMembro ()
		{
			InitializeComponent ();

		}

        private async void Salvar(object sender, SelectedItemChangedEventArgs args)
        {
            People atualizada = new People() { Nome = nome.Text, endereco = endereco.Text, bairro = bairro.Text, telefone = telefone.Text, funcao = funcao.ToString() };
            await Navigation.PopAsync();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}