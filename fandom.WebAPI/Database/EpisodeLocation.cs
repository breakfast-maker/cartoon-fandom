using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fandom.WebAPI.Database
{
    public class EpisodeLocation
    {
        public int EpisodeId { get; set; }

        public Episode Episode { get; set; }

        public int LocationId { get; set; }

        public Location Location { get; set; }
    }
}
