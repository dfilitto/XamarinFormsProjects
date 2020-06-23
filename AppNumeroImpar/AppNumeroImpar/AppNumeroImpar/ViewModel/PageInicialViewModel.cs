using AppNumeroImpar.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace AppNumeroImpar.ViewModel
{
    public class PageInicialViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _num;

        public int Numero
        {
            get { return _num; }
            set {
                _num = value;
                CommandExecute.ChangeCanExecute();
            }
        }

        public Command CommandExecute { get; }
        private INavigation _navigation;

        public PageInicialViewModel(INavigation navigation)
        {
            CommandExecute = new Command(ExecutarComando,ValidarExecucao);
            _navigation = navigation;
        }

        private bool ValidarExecucao()
        {
            bool retorno = false;
            if(Numero > 0)
            {
                retorno = true;
            }
            return retorno;
        }

        private void ExecutarComando()
        {
            if (Numero % 2 == 0)
            {
                _navigation.PushAsync(new PagePar());
            }
            else
            {
                _navigation.PushAsync(new PageImpar());
            }
        }
    }
}
