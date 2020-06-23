using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AgendaNoite.Models;

namespace AgendaNoite
{
	public partial class MainPage : ContentPage
	{
        
        public MainPage()
		{
			InitializeComponent();
		}

        public void OnNewButtonClicked(object sender, EventArgs args)
        {
            //statusMessage.Text = "";

            //App.PersonRepo.AddNewPerson(newPerson.Text);
            //statusMessage.Text = App.PersonRepo.StatusMessage;
        }

        public void OnGetButtonClicked(object sender, EventArgs args)
        {
            //statusMessage.Text = "";

            //List<Person> people = App.PersonRepo.GetAllPeople();
            //peopleList.ItemsSource = people;
        }
    }
}
