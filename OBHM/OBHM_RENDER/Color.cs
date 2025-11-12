using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBHM.RENDER
{
    public struct Color
    {
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }
        public byte A { get; set; }

        public static Color White => new Color { R = 255, G = 255, B = 255, A = 255 };
        public static Color Red => new Color { R = 255, G = 0, B = 0, A = 255 };
        public static Color LightBlue => new Color { R = 0, G = 0, B = 255, A = 255 };
    }
}
