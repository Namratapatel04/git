// 4. Factorial
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num =Convert.ToInt32( Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= num ; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Result is : {0} " , fact);
            Console .ReadLine ();
        }
    }
}
