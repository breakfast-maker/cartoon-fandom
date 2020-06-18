using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fandom.WebAPI.Database
{
    public class ContentType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Content> Contents { get; set; }
    }
}
