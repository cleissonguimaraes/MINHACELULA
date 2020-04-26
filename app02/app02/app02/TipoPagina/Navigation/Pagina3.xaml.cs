using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app02.Classes;
using app02.Service;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using app02.Classes;

namespace app02.TipoPagina.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina3 : ContentPage
	{
        DataService dataService;
        List<Pessoa> pessoas;

		public Pagina3 ()
		{

            InitializeComponent();
            dataService = new DataService();
            AtualizaDados();
            //listPersonal.ItemsSource = geralista().OrderBy(p => p.Name).ToList();



        }

        async void AtualizaDados()
        {
            pessoas = await dataService.GetPessoasAsync();
            listPersonal.ItemsSource = pessoas.OrderBy(item => item.Name).ToList();
        }

       /*public static List<Pessoa> geralista()
        {
            List<Pessoa> listaPessoa = new List<Pessoa>();
            listaPessoa.Add(new Pessoa { Name = "Thais", Endereco = "Rua Santo Antonio, 137", bairro = "Filadelfia", telefone="993225889", funcao = "Let" });
            listaPessoa.Add(new Pessoa { Name = "Thamara", endereco = "Rua Ferreira Costa, 45", bairro = "Filadelfia", telefone = "993225865", funcao = "Secretaria" });
            listaPessoa.Add(new Pessoa { Name = "Sara", endereco = "Rua Ferreira Costa, 45", bairro = "Filadelfia", telefone = "9932258334", funcao = "Membro" });
            listaPessoa.Add(new Pessoa { Name = "Alexandre", endereco = "Rua Santo Antonio, 137", bairro = "Filadelfia", telefone = "993145889", funcao = "Membro" });
            listaPessoa.Add(new Pessoa { Name = "Maria Eduarda", endereco = "Rua Santo Antonio, 137", bairro = "Filadelfia", telefone = "993675889", funcao = "Membro" });
            listaPessoa.Add(new Pessoa { Name = "Kimberli", endereco = "Rua Pedro II, 672 A", bairro = "Filadelfia", telefone = "993133765", funcao = "Lider" });
            listaPessoa.Add(new Pessoa { Name = "Alanda", endereco = "Rua Das Pedras, 543", bairro = "Quintas do Godoy", telefone = "993246889", funcao = "Let" });
            listaPessoa.Add(new Pessoa { Name = "Pablo", endereco = "Rua Itapi, 36", bairro = "Salomé", telefone = "993225854", funcao = "Visitante" });
            listaPessoa.Add(new Pessoa { Name = "Brendo", endereco = "Rua Itapi, 36", bairro = "Salomé", telefone = "993225689", funcao = "Membro" });
            listaPessoa.Add(new Pessoa { Name = "Guilherme", endereco = "Rua Ildeu Gomes do Prado, 125", bairro = "Filadelfia", telefone = "993225679", funcao = "Membro" });
            listaPessoa.Add(new Pessoa { Name = "Thalita", endereco = "Rua Maximiliana Aparecida dos Anjos, 182", bairro = "Filadelfia", telefone = "971225889", funcao = "Anfitrião" });
            
            listaPessoa.Add(new Pessoa { Name = "Thais", Endereco = null, Telefone = "993225889", Funcao = "Let" });
            listaPessoa.Add(new Pessoa { Name = "Thamara", Endereco = null, Telefone = "993225865", Funcao = "Secretaria" });
            listaPessoa.Add(new Pessoa { Name = "Sara", Endereco = null, Telefone = "9932258334", Funcao = "Membro" });
            listaPessoa.Add(new Pessoa { Name = "Alexandre", Endereco = null, Telefone = "993145889", Funcao = "Membro" });

            return (listaPessoa);
        }*/



       private async void Editar(object sender, SelectedItemChangedEventArgs args)
        {
            /*Pessoa novaPessoa = (Pessoa)args.SelectedItem;
            Pessoa pessoaT = new Pessoa();
            foreach (Pessoa p in geralista())
                if (p.Nome == novaPessoa.Nome)
                    pessoaT = p;*/
            await Navigation.PushAsync(new Telas.EditarMembros((Pessoa)args.SelectedItem));

        }

        private async void NovoMembro(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Telas.CadastroMembro());
        }


        /*private static List<Pessoa> ExcluirPessoa(string nome)
        {
            int i = 0;
            foreach (Pessoa p in geralista())
            {
                if (p.Name == nome)
                {
                    geralista().RemoveAt(i);
                }
                i++;
            }

            return geralista();

        }*/



    }
}