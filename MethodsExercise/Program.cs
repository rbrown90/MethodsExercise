using System;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Name: Kevin
            // Color: Black
            // Animal: Elephant
            // Band: Earth,Wing, and Fire

            Console.WriteLine("Hello, What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine("$Hello {userName}! Do you mind if I ask you favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine("$I love {color} also. What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("{animal} are amazing! What is your favorite band?");
            var band = Console.ReadLine();

        

            Console.WriteLine($"Name; {userName}");
            Console.WriteLine($"Favorite Color; {color}");
            Console.WriteLine($"Favorite Animal; {animal}");
            Console.WriteLine($"Favorite Band; {band}");
        }
    }
}
