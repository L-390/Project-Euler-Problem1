using System;

namespace EulerProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int sum = 0;
                    
            while(number <= 1000)
            {
                number += 1;

                if((number % 3) == 0 || (number % 5) == 0)
                {
                    Console.WriteLine(number);
                    sum += number;
                }
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
