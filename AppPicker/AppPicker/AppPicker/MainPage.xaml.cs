using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppPicker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        public Boolean NumeroPar(int valor)
        {
            Boolean retorno = false;
            if (valor % 2 == 0) { retorno = true; }
            return retorno;
        }

        public int CalculaFatorial(int valor)
        {
            int retorno = 0;
            //validar entradas negativas
            if (valor == 0)
            {
                retorno = 1;
            }
            else
            {
                retorno = valor;
                for (int i = valor - 1; i > 0; i--)
                {
                    retorno = retorno * i;
                }
            }
            return retorno;
        }

        public Boolean NumeroPrimo(int valor)
        {
            Boolean retorno = false;
            int count = 0;
            //4 
            for (int i = valor; i > 0; i--)
            {
                if (valor % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                retorno = true;
            }
            return retorno;
        }

        private void BtVerificar_Clicked(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(etValor.Text);
            String resposta = "";
            String iPicker = (String) pkOperacao.SelectedItem;
            if(iPicker == "Número primo")
            {
                resposta = "Não é um número primo";
                
                if (NumeroPrimo(valor) == true)
                {
                    resposta = "É um número primo";
                }
                lbResposta.Text = resposta;
            }
            if(iPicker == "Número par")
            {
                resposta = "O número informado é impar";

                if (NumeroPar(valor) == true)
                {
                    resposta = "O número informado é par";
                }
                lbResposta.Text = resposta;
            }
            if(pkOperacao.SelectedIndex == 2)
            {
                int fatorial = CalculaFatorial(valor);
                lbResposta.Text = "O fatorial do número " + valor.ToString() +
                    " é " + fatorial.ToString(); 
            }
        }
    }
}
