using System;
using System.Collections.Generic;
using System.Text;

namespace fandom.Model.Requests
{
   public class EpisodeUserActivityRequest
    {
        public int EpisodeId { get; set; }
        public int UserId { get; set; }
    }
}
