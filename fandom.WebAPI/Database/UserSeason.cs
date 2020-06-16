using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fandom.WebAPI.Database
{
    public class UserSeason
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int SeasonId { get; set; }
        public Season Season { get; set; }
    }
}
