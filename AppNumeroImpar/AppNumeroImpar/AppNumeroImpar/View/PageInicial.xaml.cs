using AppNumeroImpar.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNumeroImpar.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageInicial : ContentPage
    {
        public PageInicial()
        {
            InitializeComponent();
            BindingContext = new PageInicialViewModel(this.Navigation);
            //alterar o construtor
        }
    }
}