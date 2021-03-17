using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the first number?:");
            double inputA = double.Parse(Console.ReadLine());
            Console.Write("What is the second number?: ");
            double inputB = double.Parse(Console.ReadLine());
            Console.Write("What operation would you like to perform?: ");
            string inputC = Console.ReadLine();

            //addition
            if (inputC == "+" || inputC.ToUpper() == "ADD" )
            {

                double output = inputA + inputB;
                Console.WriteLine($"{inputA} + {inputB} = {output}");

                

            }
            //subraction
            else if (inputC == "-" || inputC.ToUpper() == "SUB")
            {
                double output = inputA - inputB;
                Console.WriteLine($"{inputA} - {inputB} = {output}");
            }
            //multiplication
            else if (inputC == "*" || inputC.ToUpper() == "MUL")
            {
                double output = inputA * inputB;
                Console.WriteLine($"{inputA} * {inputB} = {output}");
            }
            //division
            else if (inputC == "/" || inputC.ToUpper() == "DIV")
            {
                double output = inputA / inputB;
                Console.WriteLine($"{inputA} / {inputB} = {output}");
            }
            //mod
            else if (inputC == "%" || inputC.ToUpper() == "MOD")
            {
                double output = inputA % inputB;
                Console.WriteLine($"{inputA} % {inputB} = {output}");
            }
            else
                Console.Write("Im sorry, i don't know how to do that..");


        }
    }
}
