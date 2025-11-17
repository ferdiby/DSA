using System;
using System.Collections.Generic;

namespace List_Example_For_Referance_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new List<string>()
            {
                "Ankara",
                "İstanbul",
                "İzmir",
                "Adana"
            };

            cities.ForEach(c => Console.WriteLine(c));
            Console.WriteLine("--------------------------------");
            cities.Remove("Ankara");
            cities.ForEach(c => Console.WriteLine(c));
            cities.Add("Trabzon");
            cities.Sort();

            var names = new List<string>()
            {
                "Ali",
                "Veli",
                "Deli"
            };

            Console.WriteLine("Changin lists!!!\n");
            var tempList = new List<string>();
            tempList = names;
            names = cities;
            cities = tempList;

            Console.Write("Names: ");
            names.ForEach(i => Console.Write(" " + i));
            Console.WriteLine();
            Console.Write("Cities: ");
            cities.ForEach((c) => Console.Write(" " + c));

            Console.WriteLine();



        }
    }
}
