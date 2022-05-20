using LinkedLists.Models;
using System;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine(list.GetCount());


            list.Delete(2);
            Console.WriteLine();
            Console.WriteLine(list.GetCount());
            Console.WriteLine();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
