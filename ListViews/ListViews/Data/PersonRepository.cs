using ListViews.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListViews.Data
{
   public class PersonRepository: GenericFileRepository<Person>
    {
        public PersonRepository() : base("PesonFile.json")
        {

        }
    }
}
