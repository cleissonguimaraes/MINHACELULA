using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using app02.Classes;
using System.Collections.ObjectModel;

namespace app02.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastroFrequencia : ContentPage
	{
        public ObservableCollection<Frequencia> Pessoas { get; set; }
        public CadastroFrequencia ()
		{
			InitializeComponent ();
            /*
            List <Pessoa> listaPessoa = new List<Pessoa>();
            listaPessoa.Add(new Pessoa { Nome = "Thais" });
            listaPessoa.Add(new Pessoa { Nome = "Thamara" });
            listaPessoa.Add(new Pessoa { Nome = "Sara" });
            listaPessoa.Add(new Pessoa { Nome = "Alexandre" });
            listaPessoa.Add(new Pessoa { Nome = "Maria Eduarda" });
            listaPessoa.Add(new Pessoa { Nome = "Kimberli" });
            listaPessoa.Add(new Pessoa { Nome = "Alanda" });
            listaPessoa.Add(new Pessoa { Nome = "Pablo" });
            listaPessoa.Add(new Pessoa { Nome = "Brendo" });
            listaPessoa.Add(new Pessoa { Nome = "Guilherme" });
            listaPessoa.Add(new Pessoa { Nome = "Thalita" });
            listPersonal.ItemsSource = listaPessoa.OrderBy(p => p.Nome).ToList();*/
            Pessoas = new ObservableCollection<Frequencia>();
            ListView lstView = new ListView();
            //lstView.ItemSelected += SelectItemAction;
            //lstView.RowHeight = 60;
            this.Title = "FREQUÊNCIA";
            lstView.ItemTemplate = new DataTemplate(typeof(CustomVeggieCell));
            Pessoas.Add(new Frequencia { NomePessoa = "Thais", freqPessoa = false });
            Pessoas.Add(new Frequencia { NomePessoa = "Thamara", freqPessoa = false });
            Pessoas.Add(new Frequencia { NomePessoa = "Sara", freqPessoa = false });
            Pessoas.Add(new Frequencia { NomePessoa = "Alexandre", freqPessoa = false });
            Pessoas.Add(new Frequencia { NomePessoa = "Maria Eduarda", freqPessoa = false });
            Pessoas.Add(new Frequencia { NomePessoa = "Kimberli", freqPessoa = false });
            Pessoas.Add(new Frequencia { NomePessoa = "Alanda", freqPessoa = false });
            Pessoas.Add(new Frequencia { NomePessoa = "Pablo", freqPessoa = false });
            Pessoas.Add(new Frequencia { NomePessoa = "Brendo", freqPessoa = false });
            Pessoas.Add(new Frequencia { NomePessoa = "Guilherme", freqPessoa = false });
            Pessoas.Add(new Frequencia { NomePessoa = "Thalita", freqPessoa = false });
            lstView.ItemsSource = Pessoas.OrderBy(p => p.NomePessoa).ToList();
            
            MeuStack.Children.Add(lstView);

        }

        private async void NovoMembro(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Telas.CadastroMembro());
        }


       
        public class CustomVeggieCell : ViewCell
        {
            public CustomVeggieCell()
            {
                //instantiate each of our views
                var image = new Image();
                var nameLabel = new Label();
                var typeLabel = new Label();
                var stackPai = new StackLayout();
                var stackNomes = new StackLayout();
                var stackPresenca = new StackLayout() { BackgroundColor = Color.Transparent };

                //set bindings
                nameLabel.SetBinding(Label.TextProperty, new Binding("NomePessoa"));
                //typeLabel.SetBinding(Label.TextProperty, new Binding("Type"));

                image.Source = "checkboxUnMark.png";
                string auxImagem = "checkboxUnMark.png";
                TapGestureRecognizer check = new TapGestureRecognizer();
                check.Tapped += delegate
                {
                    image.Source = TrocaImagem(auxImagem);
                    if (auxImagem == "checkboxUnMark.png")
                        auxImagem ="CheckboxMarked.png";
                    else
                        auxImagem = "checkboxUnMark.png";

                };

                stackPai.GestureRecognizers.Add(check);
                //image.GestureRecognizers.Add(check);

                

                //Set properties for desired design
                stackPai.Orientation = StackOrientation.Horizontal;
                stackPai.Margin = 10;
                stackNomes.VerticalOptions = LayoutOptions.CenterAndExpand;
                stackNomes.HorizontalOptions = LayoutOptions.FillAndExpand;
                stackPresenca.VerticalOptions = LayoutOptions.CenterAndExpand;
                stackPresenca.HorizontalOptions = LayoutOptions.FillAndExpand;
                image.HorizontalOptions = LayoutOptions.End;
                image.WidthRequest = 15;
                image.HeightRequest = 15;
                nameLabel.FontSize = 18;
                nameLabel.TextColor = Color.Black;

                //add views to the view hierarchy

                stackNomes.Children.Add(nameLabel);
                //verticaLayout.Children.Add(typeLabel);
                //stackPresenca.Children.Add(stackNomes);
                stackPresenca.Children.Add(image);
                stackPai.Children.Add(stackNomes);
                stackPai.Children.Add(stackPresenca);



                // add to parent view
                View = stackPai;
            }
        }

        public static string TrocaImagem(string freq)
        {
            if (freq == "checkboxUnMark.png")
               return "CheckboxMarked.png";
            else
              return "checkboxUnMark.png";

        }

        private async void Salvar(object sender, SelectedItemChangedEventArgs args)
        {
           
            await Navigation.PopAsync();

        }

        /* private void SelectItemAction(object sender, SelectedItemChangedEventArgs args)
         {
             bool frequencia = false;
             frequencia = (bool) args.SelectedItem;


         }*/
    }
}