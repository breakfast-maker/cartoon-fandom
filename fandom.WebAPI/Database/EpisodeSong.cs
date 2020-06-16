using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fandom.WebAPI.Database
{
    public class EpisodeSong
    {
        public int EpisodeId { get; set; }

        public Episode Episode { get; set; }

        public int SongId { get; set; }

        public Song Song { get; set; }
    }
}
