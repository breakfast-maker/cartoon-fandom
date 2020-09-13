using fandom.Mobile.ViewModels;
using fandom.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace fandom.MobileApp.ViewModels
{
    class EpisodeDetailsViewModel : BaseViewModel
    {
        private readonly APIService _episodeApiService = new APIService("Episode");

        public MEpisode Episode { get; set; }

        public async Task UpdateViewCount()
        {
            await _episodeApiService.Update<MEpisode>(Episode.Id, null);
        }
    }
}
