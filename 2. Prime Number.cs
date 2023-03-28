// 2. Prime Number
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primenumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n;
            int a = 0;
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++) // i start 1 , check karange till input 
            {
                if (n % i == 0) // input divided by i if gives remainder 0 , a ++ 
                {
                    a++; // n kitne numbers se divisible hai 
                }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("{0} is  not a Prime Number", n);
            }
            Console.ReadLine();

        }
    }
}
