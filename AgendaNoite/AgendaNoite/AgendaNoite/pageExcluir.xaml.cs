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
	public partial class pageExcluir : ContentPage
	{
		public pageExcluir ()
		{
			InitializeComponent ();
		}
        public void Verificar(object sender, EventArgs args)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                Pessoa p = App.BancoDeDados.CarregarContato(id);
                if (p.Id != 0)
                {
                    btExcluir.IsEnabled = true;
                    txtNome.Text = p.Nome; txtCelular.Text = p.Celular; txtEmail.Text = p.Email;
                }
                else
                {
                    throw new Exception("Cadastro não encontrado");
                }
            }
            catch (Exception erro)
            {
                txtId.Text = ""; txtNome.Text = ""; txtCelular.Text = ""; txtEmail.Text = "";
                btExcluir.IsEnabled = false;
                btVoltar.Focus();
                DisplayAlert("Aviso", erro.Message, "Ok");
            }
        }
        public void Excluir(object sender, EventArgs args)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                App.BancoDeDados.ExcluirContatos(id);
                String msg = App.BancoDeDados.StatusMessage;
                txtId.Text = "";
                DisplayAlert("Aviso", msg, "Ok");
                
            }
            catch (Exception erro)
            {
                DisplayAlert("Aviso", erro.Message, "Ok");
            }
        }

        public void Voltar(object sender, EventArgs args)
        {
            Application.Current.MainPage = new NavigationPage(new Principal());
        }
    }
}