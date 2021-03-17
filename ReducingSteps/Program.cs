using System;

namespace ReducingSteps
{
    class Program
    {

        static int NumberOfSteps(int num)
        {
            int i = 0;
           
            if (num % 2 == 0)
            {
                while (num != 0)
                {
                    num /= 2;
                    i++;

                    if (num % 2 != 0)
                    {
                        num -= 1;
                        i++;
                    }
                }
            }
            return i;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfSteps(14)); 
        }
    }
}
