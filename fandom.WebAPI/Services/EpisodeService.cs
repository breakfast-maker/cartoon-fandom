using AutoMapper;
using fandom.Model.Models;
using fandom.Model.Requests;
using fandom.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace fandom.WebAPI.Services
{
    public class EpisodeService : IEpisodeService
    {
        private readonly AppCtx ctx;
        private readonly IMapper _mapper;

        public EpisodeService(AppCtx context, IMapper mapper)
        {
            ctx = context;
            _mapper = mapper;
        }

        public List<MEpisode> Get(EpisodesSeasonRequest request)
        {

            var result = new List<Episode>();

            if(request.SeasonId != null)
            {
                var query = ctx.Episodes.Include(x => x.Season).Where(x => x.SeasonId == request.SeasonId).ToList();
                result = query;
            }
            else if(request.isAssigned != null)
            {
                if (request.isAssigned == true)
                {
                    var query2 = ctx.Episodes.Include(x => x.Season).Where(x => x.Season != null).ToList();
                    result = query2;
                }
                else
                {
                    var query3 = ctx.Episodes.Include(x => x.Season).Where(x => x.Season == null).ToList();
                    result = query3;
                }
            }
            else
            {
                var query4 = ctx.Episodes.Include(x => x.Season).ToList();
                result = query4;
            }

            return _mapper.Map<List<MEpisode>>(result);
        }

        public MEpisode GetById(int episodeId)
        {
            var result = ctx.Episodes.Find(episodeId);
            return _mapper.Map<MEpisode>(result);
        }
    }
}
