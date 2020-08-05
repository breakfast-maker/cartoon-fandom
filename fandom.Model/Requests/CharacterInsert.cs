using System;
using System.Collections.Generic;
using System.Text;

namespace fandom.Model.Requests
{
   public class CharacterInsert
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Biography { get; set; }

        public int Age { get; set; }

        public DateTime BirthDate { get; set; }

        public string Occupation { get; set; }


    }
}
