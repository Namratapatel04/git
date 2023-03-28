// 1. Fibonacci Series
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c, len;

            Console.WriteLine("Enter no of elements");
            len = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("..............");
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}