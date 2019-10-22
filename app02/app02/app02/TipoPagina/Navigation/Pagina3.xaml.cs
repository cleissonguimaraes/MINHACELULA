using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using app02.Classes;

namespace app02.TipoPagina.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina3 : ContentPage
	{
		public Pagina3 ()
		{

            InitializeComponent();
            listPersonal.ItemsSource = geralista().OrderBy(p => p.Nome).ToList();



        }

        public static List<People> geralista()
        {
            List<People> listaPessoa = new List<People>();
            listaPessoa.Add(new People { Nome = "Thais", endereco = "Rua Santo Antonio, 137", bairro = "Filadelfia", telefone="993225889", funcao = "Let" });
            listaPessoa.Add(new People { Nome = "Thamara", endereco = "Rua Ferreira Costa, 45", bairro = "Filadelfia", telefone = "993225865", funcao = "Secretaria" });
            listaPessoa.Add(new People { Nome = "Sara", endereco = "Rua Ferreira Costa, 45", bairro = "Filadelfia", telefone = "9932258334", funcao = "Membro" });
            listaPessoa.Add(new People { Nome = "Alexandre", endereco = "Rua Santo Antonio, 137", bairro = "Filadelfia", telefone = "993145889", funcao = "Membro" });
            listaPessoa.Add(new People { Nome = "Maria Eduarda", endereco = "Rua Santo Antonio, 137", bairro = "Filadelfia", telefone = "993675889", funcao = "Membro" });
            listaPessoa.Add(new People { Nome = "Kimberli", endereco = "Rua Pedro II, 672 A", bairro = "Filadelfia", telefone = "993133765", funcao = "Lider" });
            listaPessoa.Add(new People { Nome = "Alanda", endereco = "Rua Das Pedras, 543", bairro = "Quintas do Godoy", telefone = "993246889", funcao = "Let" });
            listaPessoa.Add(new People { Nome = "Pablo", endereco = "Rua Itapi, 36", bairro = "Salomé", telefone = "993225854", funcao = "Visitante" });
            listaPessoa.Add(new People { Nome = "Brendo", endereco = "Rua Itapi, 36", bairro = "Salomé", telefone = "993225689", funcao = "Membro" });
            listaPessoa.Add(new People { Nome = "Guilherme", endereco = "Rua Ildeu Gomes do Prado, 125", bairro = "Filadelfia", telefone = "993225679", funcao = "Membro" });
            listaPessoa.Add(new People { Nome = "Thalita", endereco = "Rua Maximiliana Aparecida dos Anjos, 182", bairro = "Filadelfia", telefone = "971225889", funcao = "Anfitrião" });

            return (listaPessoa);
        }



       private async void Editar(object sender, SelectedItemChangedEventArgs args)
        {
            /*Pessoa novaPessoa = (Pessoa)args.SelectedItem;
            Pessoa pessoaT = new Pessoa();
            foreach (Pessoa p in geralista())
                if (p.Nome == novaPessoa.Nome)
                    pessoaT = p;*/
            await Navigation.PushAsync(new Telas.EditarMembros((People)args.SelectedItem));

        }

        private async void NovoMembro(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Telas.CadastroMembro());
        }


        private static List<People> ExcluirPessoa(string nome)
        {
            int i = 0;
            foreach (People p in geralista())
            {
                if (p.Nome == nome)
                {
                    geralista().RemoveAt(i);
                }
                i++;
            }

            return geralista();

        }



    }
}