using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fandom.WebAPI.Database
{
    public class Family
    {
        public int Id { get; set; }

        [Required, MaxLength(75)]
        public string Name { get; set; }

        public ICollection<Character> Members { get; set; }
    }
}
