using AutoMapper;
using fandom.Model.Models;
using fandom.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fandom.WebAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppCtx _ctx;
        private readonly IMapper _mapper;

        public CategoryService(AppCtx ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public List<MCategory> GetAll()
        {
            var result = _ctx.Categories.ToList();
            return _mapper.Map<List<MCategory>>(result);
        }

        public MCategory GetById(int id)
        {
            var result = _ctx.Categories.Find(id);
            return _mapper.Map<MCategory>(result);
        }
    }
}
