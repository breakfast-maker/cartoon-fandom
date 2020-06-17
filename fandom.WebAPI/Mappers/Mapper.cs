using AutoMapper;
using fandom.Model;
using fandom.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fandom.WebAPI.Mappers
{
    public class Mapper : Profile
    {
      public Mapper()
        {
            CreateMap<User, MUser>();
        }
    }
}
