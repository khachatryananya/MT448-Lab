using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    using System;

    class Program
    {
        static int ToMultiplicate(int x, int n = 2)
        {
            return x * n;
        }

        static double ToMultiplicate(double x, int n = 2)
        {
            return x * n;
        }

        static string ToMultiplicate(string x, int n = 2)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += x;
            }
            return result;
        }

        static void Main()
        {

            Console.WriteLine("--- Int Testing ---");
            Console.WriteLine(ToMultiplicate(6));
            Console.WriteLine(ToMultiplicate(6, 3));

            Console.WriteLine("\n--- Double Testing ---");
            Console.WriteLine(ToMultiplicate(1.5));
            Console.WriteLine(ToMultiplicate(3.5, 6));

            Console.WriteLine("\n--- String Testing ---");
            Console.WriteLine(ToMultiplicate("hello"));
            Console.WriteLine(ToMultiplicate("hi", 2));
        }
    }
}
