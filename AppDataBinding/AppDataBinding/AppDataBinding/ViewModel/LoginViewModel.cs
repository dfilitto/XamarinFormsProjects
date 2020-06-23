using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using AppDataBinding.View;

namespace AppDataBinding.ViewModel
{
    class LoginViewModel : INotifyPropertyChanged
    {
        private String _userName;

        public String UserName
        {
            get { return _userName; }
            set {
                _userName = value;
                LoginCommand.ChangeCanExecute();
            }
        }
        public INavigation NavigationPage;

        public Command LoginCommand { get; }
        
        public LoginViewModel(INavigation navigation)
        {
            LoginCommand = new Command(LoginExecute,LoginCanExecute);
            this.NavigationPage = navigation;
        }

        private bool LoginCanExecute()
        {
            return !String.IsNullOrEmpty(this.UserName);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void LoginExecute()
        {
            //App.Current.MainPage.DisplayAlert("Exemplo","Meu evento por meio de um comando","ok");
            NavigationPage.PushAsync(new WelcomeLogin());
        }

       
    }
}
