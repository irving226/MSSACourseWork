using System;

namespace ReducingSteps
{
    class Program
    {
        static int NumberOfSteps(int num)
        {
            int i = 0;
            while(num>0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                    i++;
                }
                else
                {
                    num -= 1;
                    i++;
                }
            }

            return i;
        }

        static void Main(string[] args)
        {
           Console.WriteLine(NumberOfSteps(14));
            Console.WriteLine(NumberOfSteps(8));
            Console.WriteLine(NumberOfSteps(123));
            Console.WriteLine(NumberOfSteps(2147483647));
        }
    }
}
