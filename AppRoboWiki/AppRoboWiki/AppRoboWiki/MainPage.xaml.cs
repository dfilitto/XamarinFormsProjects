using Algorithmia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppRoboWiki
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtExecutar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var input = "{"
                     + "  \"articleName\": \"" + eValor.Text + "\","
                     + "  \"lang\": \"pt\""
                     + "}";
                var client = new Client("simHRknoZYKwkSN9b68LU2CxZiy1");
                var algorithm = client.algo("web/WikipediaParser/0.1.2");
                algorithm.setOptions(timeout: 300); // optional
                var response = algorithm.pipeJson<DadosWikipedia>(input);
                DadosWikipedia dados = (DadosWikipedia)response.result;
                this.Navigation.PushAsync(new PagePesquisa(dados));
            }
            catch(Exception erro)
            {
                DisplayAlert("Error", "Tente refinar os parâmetro de busca", "OK");
            }
        }
    }
}
