using System;

namespace UpdatedMathematicalFormulas
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
            Console.WriteLine($"Perfect! The circumference is " + String.Format("{0:0.##}", circumference) + $" and the area is:" + String.Format("{0:0.##}", area));
        }

        static void VolumeOfHemisphere()
        {
            double radius;
            bool input = false;
            while (input == false)
            {
                Console.WriteLine("Lets compute the volume of a hemisphere. Enter a radius:");
                radius = int.Parse(Console.ReadLine()); //add int check
                double formula = 4 / 3.0 * Math.PI * Math.Pow(radius, 3);
                double divisor = 2;
                double volume = formula / divisor;
                Console.WriteLine($"Success! The volume is: {volume:0.##}");
                input = true;
            }
        }

        static void AreaOfTriangle()
        {
            bool input= false;
            while (input==false)
            {
                Console.WriteLine("Lets find the area of a triangle. Enter a value for A: ");
                double a = double.Parse(Console.ReadLine());

                if (a > 0)
                {
                    Console.WriteLine("Enter a value for B: ");
                    double b= double.Parse(Console.ReadLine());
                    if (b > 0)
                    {
                        Console.WriteLine("Enter a value for C:");
                        double c = double.Parse(Console.ReadLine());
                        if (c > 0)
                        {
                            double p = (a + b + c) / 2;
                            double triangleAreaMultiplication = (p * (p - a) * (p - b) * (p - c));
                            double triangleAreaSquared = Math.Sqrt(triangleAreaMultiplication);
                            Console.WriteLine($"The area of the triangle is {triangleAreaSquared}");
                            input = true;
                        }
                        else continue;
                    }
                    else continue;
                }
                else continue;

               
               
            }
        }
            static void QuadEquation(double a, double b, double c)
            {

            Console.WriteLine("A: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("B: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("C: ");
            c = double.Parse(Console.ReadLine());

            double discriminant = Math.Pow(b, 2) - 4 * a * c;
                double topSolution = -b + Math.Sqrt(discriminant);
                double bottomSolution = 2 * a;
                double xOne = topSolution / bottomSolution;





                double otherTop = -b - Math.Sqrt(discriminant);
                double xTwo = otherTop / bottomSolution;

                Console.WriteLine(discriminant);
                Console.WriteLine(xOne);

                Console.WriteLine(xTwo);

            }
            static void Main(string[] args)
            {

            QuadEquation(3, 5, 2);
            //AreaOfTriangle();
            //AreaOfCircle();
           // VolumeOfHemisphere();
            }
        }
    }

