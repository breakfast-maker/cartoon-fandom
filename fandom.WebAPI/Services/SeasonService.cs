using AutoMapper;
using fandom.Model.Models;
using fandom.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fandom.WebAPI.Services
{
    public class SeasonService : BaseService<MSeason, object, Season>
    {
        private readonly AppCtx ctx;
        private readonly IMapper _mapper;

        public SeasonService(AppCtx context, IMapper mapper) : base(context, mapper)
        {
            ctx = context;
            _mapper = mapper;
        }

        public override MSeason GetById(int id)
        {
            var result = ctx.Seasons.Include(x => x.Episodes).Where(x => x.Id == id).FirstOrDefault();
            return _mapper.Map<MSeason>(result);
        }

    }
}
