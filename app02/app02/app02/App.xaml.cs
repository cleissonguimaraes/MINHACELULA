using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using System.Linq;
using app02.Service;
using app02.Classes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace app02
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Telas.LoginPage();
            DataService dataService = new DataService();
            /*List<Pessoa> p = dataService.GetPessoasAsync();
            usuarios = await dataService.GetUsuariosAsync();
foreach (Usuario us in usuarios)
{
    if (us.Email == txtUser.Text && us.Password == txtPswd.Text)
    {
        App.Current.MainPage = new TipoPagina.Tabbed.Abas();
    }
    else
    {
       await DisplayAlert("Erro", "Usuário ou senha incorreto!", "OK");
    }*/
            //AtualizaDados();


        }

        public static int celula; 

        /*async void AtualizaDados()
        {
            pessoas = await dataService.GetPessoasAsync();
            listaPessoas.ItemsSource = pessoas.OrderBy(item => item.Nome).ToList();
        }*/

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
