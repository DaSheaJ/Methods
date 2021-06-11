using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------Exercise 1---------------------------
            //Name: DaShea
            //Favorite Color: Purple
            //Favorite Animal: Wolf
            //Favorite artist: Beyonce

            Console.WriteLine("Hello - what is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi,{userName}  what is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color}  is an ugly color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal}  Awesome, and who is your favorite artist?");
            var artist = Console.ReadLine();





        }
    }
}
