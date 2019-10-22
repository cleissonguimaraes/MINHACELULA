using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app02.Classes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app02.TipoPagina.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();

            List<Frequencia> listaFreq = new List<Frequencia>();
            listaFreq.Add(new Frequencia { celula = "F5 em Cristo I", dataRelatorio = "27/04/2019", NomePessoa = "Kimberli"});
            listaFreq.Add(new Frequencia { celula = "F5 em Cristo I", dataRelatorio = "20/04/2019", NomePessoa = "Thais" });
            listaFreq.Add(new Frequencia { celula = "F5 em Cristo I", dataRelatorio = "13/04/2019", NomePessoa = "Alexandre" });
            listaFreq.Add(new Frequencia { celula = "F5 em Cristo I", dataRelatorio = "06/04/2019", NomePessoa = "Thalita" });
           /* listaFreq.Add(new Frequencia { celula = "F5 em Cristo I", dataRelatorio = "27/04/2019", Pessoa = "Thamara" });
            listaFreq.Add(new Frequencia { celula = "F5 em Cristo I", dataRelatorio = "27/04/2019", Pessoa = "Brendo" });
            listaFreq.Add(new Frequencia { celula = "F5 em Cristo I", dataRelatorio = "20/04/2019", Pessoa = "Kimberli" });
            listaFreq.Add(new Frequencia { celula = "F5 em Cristo I", dataRelatorio = "20/04/2019", Pessoa = "Alexandre" });
            listaFreq.Add(new Frequencia { celula = "F5 em Cristo I", dataRelatorio = "20/04/2019", Pessoa = "Thamara" });
            listaFreq.Add(new Frequencia { celula = "F5 em Cristo I", dataRelatorio = "20/04/2019", Pessoa = "Thais" });
            listaFreq.Add(new Frequencia { celula = "F5 em Cristo I", dataRelatorio = "20/04/2019", Pessoa = "Guilherme" });*/


            listFrequency.ItemsSource = listaFreq.OrderByDescending(p => p.dataRelatorio).ToList();
        }


        private async void novoRelatorio(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Telas.CadastroFrequencia());
        }

    }
}