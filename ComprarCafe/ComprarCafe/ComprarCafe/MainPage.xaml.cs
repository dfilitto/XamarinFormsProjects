using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ComprarCafe
{
	public partial class MainPage : ContentPage
	{
        public int Qtde { get; set; }
        public Double ValorUnd { get; set; }
        public Double Total { get; set; }

        public MainPage()
		{
			InitializeComponent();
            this.Qtde = 0;
            this.ValorUnd = 5;
            this.Total = 0;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.Text == "-")
            {
                if (this.Qtde > 0)
                {
                    this.Qtde--;
                }
            }
            else
            {
                this.Qtde++;
            }
            this.Total = this.Qtde * this.ValorUnd;
            lTotal.Text = "Total: R$ " +Total.ToString();
            lQtde.Text = "Quantidade: " + Qtde.ToString();
        }
    }
}
