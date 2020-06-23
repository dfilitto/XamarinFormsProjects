using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppAreaTriangulo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtExecutar_Clicked(object sender, EventArgs e)
        {
            Double vBase = Convert.ToDouble(eBase.Text);
            Double vAltura = Convert.ToDouble(eAltura.Text);
            Double total = (vBase * vAltura) / 2;
            lTotal.Text = "A área do triângo é " + total.ToString();
        }
    }
}
