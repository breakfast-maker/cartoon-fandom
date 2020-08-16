using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fandom.WindowsForms.Utils
{
    public static class ImageWorker
    {
       public static Image ConvertFromByteArray(byte[] array)
        {
            using(var ms = new MemoryStream(array))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
