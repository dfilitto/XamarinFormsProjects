using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaNoite
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Principal : ContentPage
	{
		public Principal ()
		{
			InitializeComponent ();
		}

        public void Cadastrar(object sender, EventArgs args)
        {
            Application.Current.MainPage = new NavigationPage(new pageCadastrar());
        }

        public void Localizar(object sender, EventArgs args)
        {
            Application.Current.MainPage = new NavigationPage(new pageLocalizar());
        }

        public void Listar(object sender, EventArgs args)
        {
            Application.Current.MainPage = new NavigationPage(new pageListar());
        }

        public void Alterar(object sender, EventArgs args)
        {
            Application.Current.MainPage = new NavigationPage(new pageAlterar());
        }

        public void Excluir(object sender, EventArgs args)
        {
            Application.Current.MainPage = new NavigationPage(new pageExcluir());
        }

        public void Sair(object sender, EventArgs args)
        {
            Process.GetCurrentProcess().CloseMainWindow();
            Process.GetCurrentProcess().Close();
        }

    }
}