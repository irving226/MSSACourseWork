using System;

namespace BulletProofConsoleOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            IntMethod();
            doubleMethod();
        }

        static  int IntMethod()
        {
            int userInput = 0;
           int validator = 0;
            while(validator==0)

            try
            {
            
                Console.WriteLine("Enter an integer");
                 userInput = int.Parse(Console.ReadLine());
                    validator = 1;
                    
                }
            catch(Exception e)
            {
                    Console.WriteLine(e.Message);

            }
            return userInput;

        }

        static double doubleMethod()
        {

            
            int validator = 0;
            double userInput = 0;
            while(validator==0)
            try
            {
                Console.WriteLine("Enter a double");
                userInput = double.Parse(Console.ReadLine());
                    
                    validator = 1;
                   

                }
                catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return userInput;


        }
    }
}
