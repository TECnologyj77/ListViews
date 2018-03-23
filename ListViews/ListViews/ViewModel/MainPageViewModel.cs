using ListViews.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using static System.Math;

namespace ListViews.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();
        public ICommand ItemSelectedCommand { get; private set; }

        public string selectedItemText;

        public event PropertyChangedEventHandler PropertyChanged;


        public string SelectedItemText
        {
            get { return selectedItemText; }
            set { selectedItemText = value; RaisePropertyChanged(); }
        }


        public MainPageViewModel()
        {
            Random rand = new Random();
            Person person = new Person
            {
                FirstName = "Thomas",
                LastName = " Carney ",
                Age = (decimal)(35 + rand.NextDouble()),
                PhoneNumber = "724-888-4949"
            };
            People.Add(person);
            PopulatePeople();

            ItemSelectedCommand = new Command<Person>(HandleItemSelected);
        }

        private async void PopulatePeople()
        {
            List<Person> people = await App.DataBase.GetPeopleAsync();
            foreach(Person person in people)
            {
                People.Add(person);
            }
        }


        private void HandleItemSelected(Person person)
        {
            SelectedItemText = $"{person.FirstName} {person.LastName}";
        }

        protected void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
            }
        }

    }
}
