using AutoMapper;
using fandom.Model.Models;
using fandom.Model.Requests;
using fandom.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fandom.WebAPI.Services
{
    public class SeasonService : ISeasonService
    {
        private readonly AppCtx ctx;
        private readonly IMapper _mapper;

        public SeasonService(AppCtx context, IMapper mapper) 
        {
            ctx = context;
            _mapper = mapper;
        }

        public  List<MSeason> Get(object search)
        {
            var list = ctx.Set<Season>().ToList();

            return _mapper.Map<List<MSeason>>(list);
        }

        public  MSeason GetById(int id)
        {
            var result = ctx.Seasons.Where(x => x.Id == id).FirstOrDefault();
            return _mapper.Map<MSeason>(result);
        }

        public MSeason Insert(SeasonInsertRequest request)
        {
            var episodes = request.Episodes.OrderBy(x => x.AirDate).ToList();
            var ordinalNumber = ctx.Seasons.Count() + 1;
            var season = new Season
            {
                NoOfEpisodes = episodes.Count(),
                OrdinalNumber = ordinalNumber,
                PremiereDate = (DateTime)episodes.First().AirDate,
                Summary = "test test",
                Episodes = new List<Episode>()

            };

            for(int i = 0; i <= episodes.Count()-1; i++)
            {
                episodes[i].SeasonEpisodeNumber = i + 1;
            }


            ctx.Seasons.Add(season);

            season.Episodes = _mapper.Map<List<Episode>>(episodes);


            ctx.SaveChanges();

            return _mapper.Map<MSeason>(season);
        }
    }
}
