using ListViews.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListViews.ViewModel
{
    class EntryPageViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  PhoneNumber { get; set; }
        public decimal Age { get; set; }

        public void AddToPeople()
        {
            Person person = new Person
            {
                FirstName = FirstName,
                LastName = LastName,
                PhoneNumber = PhoneNumber,
                Age = Age
            };
            App.DataBase.SavePersonAsync(person);
        }
    }
}
