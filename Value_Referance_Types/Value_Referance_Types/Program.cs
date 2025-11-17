using System;

namespace Value_Referance_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            //Sum(a,b);
            Sum(ref a, ref b);
            Console.WriteLine($"a:{a}, b:{b}");

        }

        static void Sum(int x, int y)
        {
            int temp = x;
            x = y;
            y= temp;
            Console.WriteLine($"a:{x}, b:{y}");

        }

        /// <summary>
        /// It keeps ref types
        /// </summary>
        /// <param name="x">firs referance number</param>
        /// <param name="y">second referance number</param>
        static void Sum(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"a:{x}, b:{y}");

        }
    }
    }

