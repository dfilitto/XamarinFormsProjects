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
	public partial class pageCadastrar : ContentPage
	{
		public pageCadastrar ()
		{
			InitializeComponent ();
		}

        public void Salvar(object sender, EventArgs args)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.Nome = txtNome.Text;
                p.Celular = txtCelular.Text;
                p.Email = txtEmail.Text;

                App.BancoDeDados.AdicionarContato(p);
                String msg = App.BancoDeDados.StatusMessage;
                DisplayAlert("Aviso", msg, "Ok");
                txtNome.Text = "";
                txtCelular.Text = "";
                txtEmail.Text = "";
            }
            catch (Exception erro) {
                DisplayAlert("Aviso", erro.Message, "Ok");
            }
        }

        public void Voltar(object sender, EventArgs args)
        {
            Application.Current.MainPage = new NavigationPage(new Principal());
        }
    }
}