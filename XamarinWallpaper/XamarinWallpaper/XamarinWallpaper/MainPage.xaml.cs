using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinWallpaper.Models;

namespace XamarinWallpaper
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        public async void bt1_clickAsync (object sender, EventArgs e)
        {
            try
            {
                CategoriaManager maneger = new CategoriaManager();
                var res = await maneger.getCategoria();

                if(res != null)
                {
                    lsCategorias.ItemsSource = res;
                }
            }
            catch(Exception erro)
            {
                
            }
        }

    }
}
