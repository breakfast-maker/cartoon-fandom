using System;
using System.Collections.Generic;
using System.Text;

namespace fandom.Model.Models
{
   public class MMediaFile
    {
        public int MediaFileId { get; set; }

        public string FileName { get; set; }
        public string Path { get; set; }
        public byte[] Thumbnail { get; set; }
    }
}
