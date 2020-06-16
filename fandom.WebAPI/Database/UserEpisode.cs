using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fandom.WebAPI.Database
{
    public class UserEpisode
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int EpisodeId { get; set; }
        public Episode Episode { get; set; }
    }
}
