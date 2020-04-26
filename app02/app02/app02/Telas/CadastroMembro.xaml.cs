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
	public partial class CadastroMembro : ContentPage
	{
        DataService dataService;
        List<Pessoa> pessoas;

		public CadastroMembro ()
		{
			InitializeComponent ();
            dataService = new DataService();

		}

        private async void Salvar(object sender, EventArgs args)
        {
            // Pessoa atualizada = new Pessoa() { Name = nome.Text, Endereco = null, Telefone = telefone.Text, Funcao = funcao.ToString() };
            //await Navigation.PopAsync();
            //Endereco = endereco.Text, bairro = bairro.Text
            if (Valida())
            {
                Endereco End = new Endereco()
                {
                    Logradouro=endereco.Text.Trim(),
                    numero=numero.Text.Trim(),
                    bairro=bairro.Text.Trim(),
                    cidade=cidade.Text.Trim()
                };
                Pessoa novaPessoa = new Pessoa
                {
                    Name = nome.Text.Trim(),
                    CelulaId = int.Parse(txtCelulaId.Text),
                    Telefone = telefone.Text.Trim(),
                    Endereco = End,
                    Funcao = funcao.ToString()
                };
                try
                {
                    await dataService.AddPessoaAsync(novaPessoa);
                    await Navigation.PopAsync();
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Erro", ex.Message, "OK");
                }
            }
            else
            {
                await DisplayAlert("Erro", "Dados inválidos...", "OK");
            }

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private bool Valida()
        {
            if (string.IsNullOrEmpty(nome.Text) && string.IsNullOrEmpty(endereco.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}