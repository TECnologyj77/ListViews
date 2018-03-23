using ListViews.Data;
using ListViews.Model;
using ListViews.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViews
{
	public partial class MainPage : ContentPage
	{
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();
		public MainPage(List<Person> people)
		{
            foreach(Person person in people)
            {
                People.Add(person);
            }
			InitializeComponent();
            BindingContext = this;
		}

        private void ToEntry(Object sender, EventArgs e)
        {
            Navigation.PushAsync(new EntryPage());
        }

        private void OnStore(Object sender, EventArgs e)
        {
            var repo = new PersonRepository();
            repo.Save(People);
        }

        private void OnRestore(Object sender, EventArgs e)
        {
            var repo = new PersonRepository();
            var people = repo.GetAll();

            foreach(Person person in people)
            {
                People.Add(person);
            }
        }



        //private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    if(e.SelectedItem == null)
        //    {
        //        return; //catch deselection
        //    }
        //    else
        //    {
        //        Person person = e.SelectedItem as Person;
        //        DisplayAlert("Selected", person.FirstName + person.LastName, "OK");
        //    }
        //}

    }
}
