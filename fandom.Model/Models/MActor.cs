using System;
using System.Collections.Generic;
using System.Text;

namespace fandom.Model
{
    public class MActor
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Biography { get; set; }

        public int Age { get; set; }

        public DateTime BirthDate { get; set; }

        public string Occupation { get; set; }

        public string WikipediaLink { get; set; }

        public ICollection<MCharacter> Narations { get; set; }


    }
}
