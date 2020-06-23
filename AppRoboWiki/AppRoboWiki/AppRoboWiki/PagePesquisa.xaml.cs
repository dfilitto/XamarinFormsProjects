using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppRoboWiki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePesquisa : ContentPage
    {
        public PagePesquisa()
        {
            InitializeComponent();
        }

        public PagePesquisa(DadosWikipedia dados)
        {
            InitializeComponent();
            lTitulo.Text = dados.title;
            GetImages(dados);
            //iImagem.Source = GetImage(dados);
            eDados.Text = dados.content.Substring(0, dados.content.IndexOf("="));
        }

        public String GetImage(DadosWikipedia dados)
        {
            string imagem = "";
            int i = 0;
            while (i < dados.images.Length && imagem == "")
            {
                if (dados.images[i].IndexOf("jpg") > 0)
                {
                    imagem = dados.images[i];
                }
                i++;
            }
            return imagem;
        }

        public void GetImages(DadosWikipedia dados)
        {
            String imagem = "";
            int i = 0;
            while (i < dados.images.Length)
            {
                if (dados.images[i].IndexOf("jpg") > 0)
                {
                    imagem = dados.images[i];
                    Image image = new Image { Source = imagem, HeightRequest = 300 };
                    sImagens.Children.Add(image);
                }
                i++;
            }
        }
    }
}