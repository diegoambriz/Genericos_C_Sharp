using System;

namespace ToyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory<Doll> factory = new DollFactory();
            var boxes = BoxHelper.GenerateBoxes<Doll>(50, factory.MakeElement);
            /*var doll = new Doll();
            var box = new Box<Doll>();
            box.Put(doll);

            var box2 = new Box<Car>();
            box2.Put(new Car());*/
        }
    }
}
