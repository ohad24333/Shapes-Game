using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Game
{
    abstract class Shape
    {
        abstract public int Top { get; set; }
        abstract public int Left { get; set; }
        abstract public char TheChar { get; set; }



    }
        public enum ShapeEnum
        {
            Line,
            Squer,
            Triangle,
            Rectangle
        }

}
