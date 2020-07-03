using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fandom.WebAPI.Database
{
    public class Episode
    {
        public int Id { get; set; }

        public string Title { get; set; }

        //public byte[] Thumbnail { get; set; }

        public int NoOfSeason { get; set; }

        public int OrdinalNumber { get; set; }

        public string Summary { get; set; }

        public string VideoLink { get; set; }

        public long Duration { get; set; }

        public int Viewcount { get; set; }

        public bool IsAssignedToSeason { get; set; } = false;

        public int SeasonId { get; set; }
        public Season Season { get; set; }

        public ICollection<UserEpisode> UsersEpisodes { get; set; }
        public ICollection<EpisodeSong> EpisodesSongs { get; set; }
        public ICollection<EpisodeLocation> EpisodesLocations { get; set; }
        public ICollection<EpisodeCharacter> EpisodesCharacters { get; set; }


    }
}
