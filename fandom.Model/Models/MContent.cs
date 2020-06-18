using System;
using System.Collections.Generic;
using System.Text;

namespace fandom.Model
{
   public class MContent
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }

        public MContentType ContentType { get; set; }

    }
}
