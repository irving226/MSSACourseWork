using System;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = "Giraffe";
           
            AnimalSound(animal);



        }

        //calls two parameter method with a default sound
        static void AnimalSound(string animal, string sound="quack")
        {
            
           
            Console.WriteLine($"The {animal} goes {sound}!");




        }


    }
}
