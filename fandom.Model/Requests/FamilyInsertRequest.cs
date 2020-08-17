using System;
using System.Collections.Generic;
using System.Text;

namespace fandom.Model.Requests
{
    public class FamilyInsertRequest
    {
        public string Name { get; set; }

        public byte[] Thumbnail { get; set; }
    }
}
