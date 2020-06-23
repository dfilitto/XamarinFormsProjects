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
	public partial class pageAlterar : ContentPage
	{
		public pageAlterar ()
		{
			InitializeComponent ();
		}

        public pageAlterar(int id)
        {
            InitializeComponent();
            txtId.Text = id.ToString();
            Verificar(new object(), new EventArgs());
        }

        public void Verificar(object sender, EventArgs args)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                Pessoa p = App.BancoDeDados.CarregarContato(id);
                if (p.Id != 0)
                {
                    txtNome.IsEnabled = true; txtCelular.IsEnabled = true;
                    txtEmail.IsEnabled = true; btSalvar.IsEnabled = true; 
                    txtNome.Text = p.Nome; txtCelular.Text = p.Celular; txtEmail.Text = p.Email;
                }
                else
                {
                    throw new Exception("Cadastro não encontrado");
                }
            }
            catch (Exception erro)
            {
                txtId.Text = "";  txtNome.Text = "";  txtCelular.Text = "";  txtEmail.Text = "";
                txtNome.IsEnabled = false; txtCelular.IsEnabled = false;
                txtEmail.IsEnabled = false; btSalvar.IsEnabled = false;
                btVoltar.Focus();
                DisplayAlert("Aviso", erro.Message, "Ok");
            }
        }
            public void Salvar(object sender, EventArgs args)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.Id = Convert.ToInt32(txtId.Text);
                p.Nome = txtNome.Text;
                p.Celular = txtCelular.Text;
                p.Email = txtEmail.Text;
                App.BancoDeDados.AtualizaContato(p);
                String msg = App.BancoDeDados.StatusMessage;
                DisplayAlert("Aviso", msg, "Ok");
                txtId.Text = "";
                txtNome.Text = "";
                txtCelular.Text = "";
                txtEmail.Text = "";
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