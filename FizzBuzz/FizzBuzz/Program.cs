using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 100) {
                
                if (i % 3 == 0 && i % 5 == 0)
                {
                 
                    Console.WriteLine($"{i} FizzBuzz ");
                    i++;
                    continue;
                }
                else if (i % 3 == 0)
                {
                  
                    Console.WriteLine($"{i} Fizz ");
                  
                    i++;
                    continue;

                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} Buzz ");
                    i++;
                    continue;

                }
                else
                    Console.WriteLine(i);
                i++;

            }
        }
    }
}
