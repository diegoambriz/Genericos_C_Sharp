using System;
using System.Linq;

namespace FruitOrchard
{
    class Program
    {
        static void Main(string[] args)
        {
            var appleTree = new FruitTree<Apple>();
            var box = new Box<Apple>(40000);
            box.FillBox(appleTree);
            var apples = box.ToList();
            Console.WriteLine($"En la caja han cabido {box.Count()} manzanas");
            Console.WriteLine($"La manzana mas grande pesa {apples.Max(i => i.Weight)}.");
            Console.WriteLine($"Esta caja pesa {apples.Sum(i => i.Weight)}");
            var smallApples = apples.Where(i => i.Weight < 250);
            Console.WriteLine($"Hay {smallApples.Count()} manzanas que pesan menos de 250");

            Console.ReadLine();
            
            /*var apple = new Apple { Weight = 35};
            var otherApple = new Apple { Weight = 6 };

            box.Add(apple);
            box.Add(otherApple);
            var tree = new FruitTree<Apple>();
            var apple = tree.CreateFruit();*/

            /*var otherTree = new FruitTree<Rabbit>();
            var rabbit = otherTree.CreateFruit();*/
        }
    }
}
