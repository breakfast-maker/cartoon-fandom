using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fandom.WebAPI.Database
{
    public class LocationType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Location> Locations { get; set; }
    }
}
