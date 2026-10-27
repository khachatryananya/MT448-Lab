using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void A(in int x)
    {
        Console.WriteLine($"A (in): {x}");
    }

    static void B(out int x)
    {
        x = 50; 
    }
    static void C(ref int x)
    {
        x += 20; 
    }

    static int SumValues(params int[] numbers)
    {
        int sum = 0;
        foreach (var n in numbers)
        {
            sum += n;
        }
        return sum;
    }

    static void D(int number = 100) 
    {
        Console.WriteLine($"D (default): {number}");
    }

    static void Main()
    {
       
        int a = 15; 
        A(in a);

        
        int b;
        B(out b);
        Console.WriteLine($"B (out): {b}"); 

        
        int c = 30; 
        C(ref c);
        Console.WriteLine($"C (ref): {c}"); 

        int total = SumValues(5, 10, 15, 20, 25); 
        Console.WriteLine($"SumValues (params): {total}");
        D();   
        D(500); 
    }
}
