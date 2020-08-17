using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fandom.Model;
using fandom.Model.Requests;
using fandom.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fandom.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyController : ControllerBase
    {
        private readonly IFamilyService _service;
        public FamilyController(IFamilyService service)
        {
            _service = service;
        }

        [HttpGet]
      public  List<MFamily> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
      public  MFamily GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
      public  MFamily Insert(FamilyInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}
