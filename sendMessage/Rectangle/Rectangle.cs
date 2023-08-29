using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sendMessage.Rectangle
{
    public class Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public int Area()
        {
            return Length * Width;
        }
    }
}