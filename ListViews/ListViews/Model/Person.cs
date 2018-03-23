using ListViews.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListViews.Model
{
   public class Person : IEntity 
    {
        //[PrimaryKey, AutoIncrement] was required for SQLite
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageSource { get; set; }
        public decimal Age { get; set; }
    }
}
