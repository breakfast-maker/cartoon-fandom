using AutoMapper;
using fandom.Model;
using fandom.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fandom.WebAPI.Services
{
    public class UsersService : IUsersService
    {
        private readonly AppCtx _ctx;
        private readonly IMapper _mapper;

        public UsersService(AppCtx context, IMapper mapper)
        {
            _ctx = context;
            _mapper = mapper;
        }

        public List<MUser> Get() {

            var list = _ctx.Users.ToList();

            return _mapper.Map<List<MUser>>(list);
        } 
        
    }
}
