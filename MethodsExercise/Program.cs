using System;

namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
       public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }
        static void Main(string[] args)
        {

            var amountOfCars = Sum(2, 4);
            var amountOfCookies = Multiply(5, 4);
            var amountOfChips = Divide(3, 9);
            var amountOfHouses = Subtract(4, 8);
            var amountOfDonuts = Modulus(8, 12);

    // -------------------- Exercise 1 -------------------//
            // Name: Kevin
            // Color: Black
            // Animal: Elephant
            // Band: Earth,Wind, and Fire

            Console.WriteLine("Hello, What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}! Do you mind if I ask you favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"I love {color} also. What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal} are amazing! What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thank you {userName}, here is a summary of your profile!");
            Console.WriteLine("-----------------------");
        
            Console.WriteLine($"Name; {userName}");
            Console.WriteLine($"Favorite Color; {color}");
            Console.WriteLine($"Favorite Animal; {animal}");
            Console.WriteLine($"Favorite Band; {band}");


        }
    }
}
