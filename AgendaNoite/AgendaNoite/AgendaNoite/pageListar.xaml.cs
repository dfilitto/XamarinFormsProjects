using AgendaNoite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaNoite
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class pageListar : ContentPage
	{
        Pessoa pessoa;
        
		public pageListar ()
		{
			InitializeComponent ();


            List<Pessoa> contatos = App.BancoDeDados.RecuperarContatos();
            ListaDeContatos.ItemsSource = contatos;
        }

        public void Voltar(object sender, EventArgs args)
        {
            Application.Current.MainPage = new NavigationPage(new Principal());
        }

        public void AtivaBotoes(object sender, SelectedItemChangedEventArgs e)
        {
            btAlterar.IsVisible = true;
            btExcluir.IsVisible = true;
            pessoa = (Pessoa)ListaDeContatos.SelectedItem;
        }

        public async Task ExcluirAsync(object sender, EventArgs args)
        {
            var resp = await DisplayAlert("Excluir Registro", "Deseja excluir o item selecionado?",
                "Sim", "Não");
            if (resp)
            {
                App.BancoDeDados.ExcluirContatos(pessoa.Id);
                List<Pessoa> contatos = App.BancoDeDados.RecuperarContatos();
                ListaDeContatos.ItemsSource = contatos;
            }
        }

        public void Alterar(object sender, EventArgs args)
        {
            Application.Current.MainPage = new NavigationPage(new pageAlterar(pessoa.Id));
        }
    }
}