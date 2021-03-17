using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            int j = 1;
            int k = 1;
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);


            do
            {
                i = j + k;
                j = i + k;
                k = i + j;
                Console.WriteLine(i);
                Console.WriteLine(j); 
                Console.WriteLine(k);

            } while (i < 20);
        }
    }
}
