using System;
using System.Collections.Generic;
using System.Text;

namespace ToyFactory
{
    public static class BoxHelper
    {
        public static List<Box<T>> GenerateBoxes<T>(int numberOfBoxes, Func<T> getContent)
        {
            var lstBoxes = new List<Box<T>>();

            for (int i =0; i < numberOfBoxes; i++)
            {
                var box = new Box<T>();
                box.Put(getContent());
                lstBoxes.Add(box);
            }

            return lstBoxes;
        }
    }
}
