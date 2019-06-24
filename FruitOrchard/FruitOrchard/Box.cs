using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FruitOrchard
{
    public class Box<T> : IEnumerable<T> where T : IWeighable
    {
        private readonly List<T> lstContent = new List<T>();


        public int MaxWeight { get; private set; }

        public Box(int maxWeight)
        {
            this.MaxWeight = maxWeight;
            lstContent = new List<T>();
        }

        private bool CanAdd(int weight)
        {
            return lstContent.Sum(i => i.Weight) + weight <= MaxWeight;
        }

        public void Add(T item)
        {
            if (lstContent.Contains(item))
            {
                throw new Exception("Este elemento ya está en la caja.");
            }

            if (!CanAdd(item.Weight))
            {
                throw new Exception("No puedo añadir ese peso a la caja. La caja ya pesa demasiado.");
            }
            lstContent.Add(item);
        }

        public bool Remove(T item)
        {
            return lstContent.Remove(item);
        }

        public T this[int i] => lstContent[i];

        public IEnumerator<T> GetEnumerator() => lstContent.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => lstContent.GetEnumerator();

    }
}