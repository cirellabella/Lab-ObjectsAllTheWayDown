using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_ObjectsAllTheWayDown
{
    internal class Glasses
    {
        //Aggregation-- has-a relationship
        //The glasses (class) has a lens shape/ style
        //field
        LensShape _lensShape;

        public Glasses(LensShape lensShape)
        {
            LensShape = lensShape;
        }

        internal LensShape LensShape { get => _lensShape; set => _lensShape = value; }

        // What would you want to display
        // 
        public override string ToString()
        {
            return $"{GetType().Name} - {LensShape}";
        }

    }
}
