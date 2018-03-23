using ListViews.Model;
using ListViews.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EntryPage : ContentPage
	{
        private List<Person> people = new List<Person>();
        private static int ids = 0;
		public EntryPage ()
		{
			InitializeComponent ();
		}

        private void AddEntry(object sender, EventArgs e)
        {
            var person = new Person
            {
                ID = ids++,
                FirstName = FirstNameEntry.Text,
                LastName = LastNameEntry.Text,
                Age = Decimal.Parse(AgeEntry.Text),
                PhoneNumber = PhoneNumberEntry.Text
            };

            FirstNameEntry.Text = string.Empty;
            LastNameEntry.Text = string.Empty;
            AgeEntry.Text = string.Empty;
            PhoneNumberEntry.Text = string.Empty;

            people.Add(person);

            DisplayAlert("Person Added", person.FirstName + " has been added", "Ok");

        }

        private void GoToList(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage(people), true);
        }

	}
}