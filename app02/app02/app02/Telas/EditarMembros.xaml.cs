using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app02.Classes;
using app02.TipoPagina.Navigation;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app02.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditarMembros : ContentPage
	{
        public EditarMembros(People pessoa)
        {
            InitializeComponent();

            txtNome.Text = pessoa.Nome;
            txtEndereco.Text = pessoa.endereco;
            txtBairro.Text = pessoa.bairro;
            txtTelefone.Text = pessoa.telefone;
            if (pessoa.funcao == "Membro")
                txtFuncao.SelectedIndex = 0;
            else if (pessoa.funcao == "Visitante")
                txtFuncao.SelectedIndex = 1;
            else if (pessoa.funcao == "Lider")
                txtFuncao.SelectedIndex = 2;
            else if (pessoa.funcao == "Let")
                txtFuncao.SelectedIndex = 3;
            else if (pessoa.funcao == "Secretario")
                txtFuncao.SelectedIndex = 4;
            else if (pessoa.funcao == "Anfitriao")
                txtFuncao.SelectedIndex = 5;
            else if (pessoa.funcao == "Irmão do Lanche")
                txtFuncao.SelectedIndex = 6;
                

        }

        private async void Excluir(object sender, EventArgs args)
        {
           var res = await DisplayAlert("Excluir Membro", "Você tem certeza que quer excluir este membro?", "OK", "CANCELAR");
            if (res == true)
            App.Current.MainPage = new TipoPagina.Tabbed.Abas();

        }

        private List<People> ExcluirPessoa(string nome)
        {
            int i = 0;
            foreach (People p in TipoPagina.Navigation.Pagina3.geralista())
            {
                if (p.Nome == nome)
                {
                    TipoPagina.Navigation.Pagina3.geralista().RemoveAt(i);
                }
                i++;
            }

            return TipoPagina.Navigation.Pagina3.geralista();

        }
        private async void Salvar(object sender, SelectedItemChangedEventArgs args)
        {
            People atualizada = new People() { Nome = txtNome.Text , endereco = txtEndereco.Text, bairro = txtBairro.Text, telefone = txtTelefone.Text, funcao = txtFuncao.ToString()};
            await Navigation.PopAsync();

        }

    }
}