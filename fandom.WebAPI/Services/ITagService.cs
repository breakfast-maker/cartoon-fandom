using fandom.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fandom.WebAPI.Services
{
   public interface ITagService
    {
        public List<MTag> GetAll();
        public MTag GetById(int id);
    }
}
