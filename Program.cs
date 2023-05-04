using static Lab_ObjectsAllTheWayDown.LensShape;

namespace Lab_ObjectsAllTheWayDown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a new sunglasses shop
            Sunglasses_Shop rayban = new Sunglasses_Shop();

            //create a new lens Shape and pass a couple shapes through
            LensShape ls = new LensShape(Shape.aviator);
            LensShape shape = new LensShape(Shape.catEye);

            //add those new glasses to the rayban shop
            rayban.AddGlasses(new Glasses(shape));
            rayban.AddGlasses(new Glasses(ls));

            //
            Glasses glasses = new Glasses(shape);
            
            Console.WriteLine(glasses);
            Console.WriteLine(shape);

            foreach (Glasses g in rayban.Stock)
            {
                Console.WriteLine(g);
            }

        }
    }
}