using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEsqueci.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PagePrincipal : MasterDetailPage
	{
		public PagePrincipal ()
		{
			InitializeComponent ();
            BtHome_Clicked(new Object(), new EventArgs());
           
        }

        private void BtHome_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PageHome());
            IsPresented = false;
        }

        private void BtCadastrar_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PageCadastrar());
            IsPresented = false;
        }

        private void BtListar_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PageListar());
            IsPresented = false;
        }

        private void BtSobre_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PageSobre());
            IsPresented = false;
        }
    }
}