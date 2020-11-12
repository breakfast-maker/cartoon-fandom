using fandom.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace fandom.Model.Requests
{
   public class CharacterUpdateRequest
    {
        public MCharacterMediaFile MediaFile { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Biography { get; set; }
        public string Occupation { get; set; }
    }
}
