using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5! means 5 x 4 x 3 x 2 x 1
            Console.Write("Please enter a number to be \"factorialised\": ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Please enter a number to be \"factorialised\": ");
            }

            // Use a for loop to calaculate n!
            /*
            int factorial = 1;
            for(int i = n; i > 0; i--)
            {
                factorial *= i;
            }
            */

            int factorial = FindFactorial(n);

            // Display the result
            Console.WriteLine($"{n} factorial is {factorial}");

            Console.ReadLine();
        }

        static int FindFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * FindFactorial(n-1);
        }
    }
}
