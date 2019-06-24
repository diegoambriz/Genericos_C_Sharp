using System;
using System.Collections.Generic;
using System.Text;

namespace FruitOrchard
{
    public class FruitTree<T>where T : Fruit, new()
    {
        public T CreateFruit()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            return new T { Weight = rnd.Next(180, 301) };
        }
    }
}
