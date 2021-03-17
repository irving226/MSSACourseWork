using System;

namespace GeometricAreasAndPerimeters
{
    class Program
    {
        static void Main(string[] args)
        {
  
            double circle1Radius = 1.0;
            double circle1Area = GetArea(circle1Radius); // 3.14159...
            double circle1Perimeter = GetPerimeter(circle1Radius); // 6.28318...
            Console.WriteLine("Circle 1      Area: " + circle1Area);
            Console.WriteLine("Circle 1 Perimeter: " + circle1Perimeter);
            Console.WriteLine();

            double rectangleLength = 2.0;
            double rectangleWidth = 3.0;
            double rectangleArea = GetArea(rectangleLength, rectangleWidth);
            double rectanglePerimeter = GetPerimeter(rectangleLength, rectangleWidth);
            Console.WriteLine("Rectangle      Area: {0}", rectangleArea);
            Console.WriteLine("Rectangle Perimeter: {0}", rectanglePerimeter);
            Console.WriteLine();

            double triangleSideA = 4.0;
            double triangleSideB = 5.0;
            double triangleSideC = 6.0;
            double triangleArea = GetArea(triangleSideA, triangleSideB, triangleSideC);
            double trianglePerimeter = GetPerimeter(triangleSideA, triangleSideB, triangleSideC);
            Console.WriteLine($"Triangle      Area: {triangleArea}");
            Console.WriteLine($"Triangle Perimeter: {trianglePerimeter}");
            Console.WriteLine();

            (circle1Area, circle1Perimeter) = GetAreaAndPerimeter(1.0);
            Console.WriteLine($"Circle 1      Area: {circle1Area}");
            Console.WriteLine($"Circle 1 Perimeter: {circle1Perimeter}");
            Console.WriteLine();
        }

        static double GetArea(double radius) // Circle
        {
            
         
            radius = Math.PI * (radius * radius);

            return radius;
        }

        static double GetArea(double length, double width) // Rectangle
        {
            double rectangleArea = length * width;
            return rectangleArea;
        }

        static double GetArea(double a, double b, double c) // Triangle
        {

            double heronOne = a + b + c;
            double heronTwo = 2; 
                double s = heronOne / heronTwo;

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c)); 
        }

        static double GetPerimeter(double radius) // Circle
        {
            radius = 2 * (Math.PI * radius);
            return radius;
        }

        static double GetPerimeter(double length, double width) // Rectangle
        {
            double rectanglePerimeter = 2* (length + width);
            return rectanglePerimeter;
        }

        static double GetPerimeter(double a, double b, double c) // Triangle
        {
            return a + b + c;
        }

        static (double area, double perimeter) GetAreaAndPerimeter(double radius) // Circle
        {
            GetArea(radius);
            GetPerimeter(radius);
            return( GetArea(radius), GetPerimeter(radius));
        }

        static (double area, double perimeter) GetAreaAndPerimeter(double length, double width) // Rectangle
        {
            return (GetArea(length, width), GetPerimeter(length, width));
        }

        static (double area, double perimeter) GetAreaAndPerimeter(double a, double b, double c) // Triangle
        {
            return (GetArea(a, b, c), GetPerimeter(a,b,c));
        }
    }
    
}
