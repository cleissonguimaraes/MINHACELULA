using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app02.Classes;
using app02.TipoPagina.Navigation;
using app02.Service;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app02.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditarMembros : ContentPage
	{
        DataService dataService;
        List<Pessoa> pessoas;

        public EditarMembros(Pessoa pessoa)
        {
            InitializeComponent();
            dataService = new DataService();
            txtNome.Text = pessoa.Name;
            txtId.Text = pessoa.PessoaId.ToString();
            txtCelulaId.Text = pessoa.CelulaId.ToString();
            txtEndereco.Text = pessoa.Endereco==null?"": pessoa.Endereco.Logradouro;
            txtNumero.Text = pessoa.Endereco==null?"":pessoa.Endereco.numero;
            txtBairro.Text = pessoa.Endereco == null ? "" : pessoa.Endereco.bairro;
            txtCidade.Text = pessoa.Endereco == null ? "" : pessoa.Endereco.cidade;
            txtTelefone.Text = pessoa.Telefone;
            if (pessoa.Funcao == "Membro")
                txtFuncao.SelectedIndex = 0;
            else if (pessoa.Funcao == "Visitante")
                txtFuncao.SelectedIndex = 1;
            else if (pessoa.Funcao == "Lider")
                txtFuncao.SelectedIndex = 2;
            else if (pessoa.Funcao == "Let")
                txtFuncao.SelectedIndex = 3;
            else if (pessoa.Funcao == "Secretário")
                txtFuncao.SelectedIndex = 4;
            else if (pessoa.Funcao == "Anfitrião")
                txtFuncao.SelectedIndex = 5;
            else if (pessoa.Funcao == "Irmão do Lanche")
                txtFuncao.SelectedIndex = 6;
                

        }

        private async void Excluir(object sender, EventArgs args)
        {
           var res = await DisplayAlert("Excluir Membro", "Você tem certeza que quer excluir este membro?", "OK", "CANCELAR");
            if (res == true)
            App.Current.MainPage = new TipoPagina.Tabbed.Abas();

        }
        /*
        private List<Pessoa> ExcluirPessoa(string nome)
        {
            int i = 0;
            foreach (Pessoa p in TipoPagina.Navigation.Pagina3.geralista())
            {
                if (p.Name == nome)
                {
                    TipoPagina.Navigation.Pagina3.geralista().RemoveAt(i);
                }
                i++;
            }

            return TipoPagina.Navigation.Pagina3.geralista();

        }*/
        private async void Salvar(object sender, SelectedItemChangedEventArgs args)
        {
            //Pessoa atualizada = new Pessoa() { Name = txtNome.Text , Endereco = null, Telefone = txtTelefone.Text, Funcao = txtFuncao.ToString()};
            //await Navigation.PopAsync();

            if(Valida())
            {
                Endereco End = new Endereco()
                {
                    Logradouro = txtEndereco.Text.Trim(),
                    numero = txtNumero.Text.Trim(),
                    bairro = txtBairro.Text.Trim(),
                    cidade = txtCidade.Text.Trim()
                };
                Pessoa novaPessoa = new Pessoa
                {
                    Name = txtNome.Text.Trim(),
                    PessoaId = int.Parse(txtId.Text),
                    CelulaId = int.Parse(txtCelulaId.Text),
                    Telefone = txtTelefone.Text.Trim(),
                    Endereco = End,
                    Funcao = txtFuncao.ToString()
                };
                try
                {
                    await dataService.UpdatePessoaAsync(novaPessoa);
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

        private bool Valida()
        {
            if (string.IsNullOrEmpty(txtNome.Text) && string.IsNullOrEmpty(txtEndereco.Text))
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