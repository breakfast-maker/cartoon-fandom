using AutoMapper;
using fandom.Model.Models;
using fandom.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fandom.WebAPI.Services
{
    public class TagService : ITagService
    {
        private readonly AppCtx _ctx;
        private readonly IMapper _mapper;

        public TagService(AppCtx ctx,IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public List<MTag> GetAll()
        {
            var result = _ctx.Tags.ToList();
            return _mapper.Map<List<MTag>>(result);
        }

        public MTag GetById(int id)
        {
            var result = _ctx.Tags.Find(id);
            return _mapper.Map<MTag>(result);
        }
    }
}
