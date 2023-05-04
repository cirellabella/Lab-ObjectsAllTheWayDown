using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_ObjectsAllTheWayDown
{
    internal class LensShape
    {
        //field
        public enum Shape { catEye, square, round, rectangle, aviator, oval, geometric, heart };
        public Shape _style;

        public LensShape(Shape style)
        {
            _style = style;
        }

        public Shape Style { get => _style ; }

        public override string ToString()
        {
            return $"Style: {Style}";
        }
    }
}
