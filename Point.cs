using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Game
{
    class Point
    {
        public int Vertical { get; set; }
        public int Horizontal { get; set; }

        public Point(int vertical, int horizontal)
        {
            Vertical = vertical;
            Horizontal = horizontal;
        }
    }
}
