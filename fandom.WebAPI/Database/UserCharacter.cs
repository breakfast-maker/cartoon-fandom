using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fandom.WebAPI.Database
{
    public class UserCharacter
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int CharacterId { get; set; }
        public Character Character { get; set; }
    }
}
