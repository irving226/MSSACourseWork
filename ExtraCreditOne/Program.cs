using System;

namespace ExtraCreditOne
{
    class Program
    {
        static void AreaOfCircle()
        {
            double radius;
            while (true)
            {
                Console.WriteLine("Welcome to Math on Steroids! Lets warm up by find the area & circumference" +
          "of a circle. Enter a radius: ");
                radius = int.Parse(Console.ReadLine());
                if (radius <= 0)
                    Console.WriteLine("Invalid interger. Please try again.");

                else break;

            }


            double circumference = 2 * Math.PI * radius;
            double area = (radius * radius) * Math.PI;
            Console.WriteLine($"Perfect! The circumference is {circumference},and the area is: {area}");
        }

        static void AreaOfTriangle()
        {
            bool input = false;
            while (input == false)
            {
                Console.WriteLine("Lets find the area of a triangle. Enter a value for A: ");
                double a = int.Parse(Console.ReadLine());

                if (a <= 0)
                {
                    Console.WriteLine("Invalid interger. Please try again.");
                    break;
                }

                Console.WriteLine("Enter a value for B: ");
                double b = int.Parse(Console.ReadLine());

                if (b <= 0)
                {

                    Console.WriteLine("Invalid interger. Please try again.");
                    break;
                }

                Console.WriteLine("Enter a value for C: ");
                double c = int.Parse(Console.ReadLine());
                if (c <= 0)
                {

                    Console.WriteLine("Invalid interger. Please try again.");
                    break;
                }
                double halfCir = (a + b + c) / 2;
                double triangleAreaMultiplication = halfCir * (halfCir - a) * (halfCir - b) * (halfCir - c);
                double triangleAreaSquared = Math.Sqrt(triangleAreaMultiplication);
                Console.WriteLine($"The area of the triangle is {triangleAreaSquared}");
                input = true;
            }
        }


        static void Main(string[] args)
        {
            AreaOfTriangle();
        }
    }
}
