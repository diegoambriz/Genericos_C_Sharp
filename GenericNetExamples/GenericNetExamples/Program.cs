using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericNetExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            queue.Enqueue("Message 1");
            queue.Enqueue("Message 2");
            queue.Enqueue("Message 3");
            bool itemDequeued;
            do
            {
                itemDequeued = queue.TryDequeue(out var item);
                if (itemDequeued)
                {
                    Console.WriteLine(item);
                }
            } while (itemDequeued);
            Console.ReadLine();

            /*var dict = new Dictionary<string, int> { { "Diego", 1993 }, { "Jorge", 1985 }, { "Pedro", 1995 } };
            dict.Add("Sergio", 2003);

            if (dict.ContainsKey("Diego"))
            {
                Console.WriteLine($"Diego nacio en {dict["Diego"]}.");
            }
            Console.ReadLine();*/

            /*var lstNames = new List<string> { "Diego", "Jorge", "Luis"};
            lstNames.Add("Ana");

            lstNames.RemoveAt(0);
            lstNames.Remove("Ana");
            lstNames.Insert(0, "Ramiro");

            var firstName = lstNames[0];*/
        }
    }
}
