using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler100
{
    /// <summary>
    /// Multiples of 3 and 5:
    /// 
    /// Question: If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    ///Find the sum of all the multiples of 3 or 5 below the provided parameter value number.
    /// </summary>
    public static class Problem1
    {
        public static void Solve()
        {
            Console.WriteLine("Type in the number:");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(MultiplesOf3And5(number));
        }

        public static int MultiplesOf3And5(int number)
        {
            int sum = 0;
            for (var i = number; i >= 3; i--)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }
            return sum;
        }
    }
}
