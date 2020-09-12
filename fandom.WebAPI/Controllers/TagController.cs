using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fandom.Model.Models;
using fandom.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fandom.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ITagService _service;
        public TagController(ITagService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public MTag GetById(int id) => _service.GetById(id);

        [HttpGet]
        public List<MTag> GetAll() => _service.GetAll();
    }
}
