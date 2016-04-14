using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Enter the Number:- ");
                string InputNumber = Console.ReadLine();
                long result = Factorial(int.Parse(InputNumber));
                Console.WriteLine(result.ToString());
            }
        }

        static long Factorial(long number)
        {
            if (number <= 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }
    }
}
