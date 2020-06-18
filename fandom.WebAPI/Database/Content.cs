using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fandom.WebAPI.Database
{
    public class Content
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }

        public int ContetTypeId { get; set; }
        public ContentType ContentType { get; set; }

        public int CharacterId { get; set; }
        public Character Character { get; set; }


    }
}
