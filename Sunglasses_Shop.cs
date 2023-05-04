using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_ObjectsAllTheWayDown
{
    internal class Sunglasses_Shop
    {
        //Containment-- need-a relationship
        //Sunglasses shop contains a list of the stock (of glasses)
        //field
        List<Glasses> _stock;

        public Sunglasses_Shop()
        {
            _stock= new List<Glasses>();
        }

        //constructor
        //public Sunglasses_Shop(List<Glasses> stock)
        //{
        //    stock = _stock;
        //}

        //property
        internal List<Glasses> Stock { get => _stock; }

        public void AddGlasses(Glasses stock)
        {
            _stock.Add(stock);
        }

        public void AddGlasses(LensShape Style) {
            Glasses glasses = new Glasses(Style);
            _stock.Add(glasses);
        }


        public override string ToString()
        {
            return $"{Stock}";
        }

    }//end of class
}
