using fandom.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fandom.WebAPI.Services
{
    public interface ICategoryService
    {
        public List<MCategory> GetAll();
        public MCategory GetById(int id);
    }
}
