using System;

namespace Day_1_Deliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, height, area, perimeter, volume;
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!\n");

            string userContinue = "y";
            while (userContinue == "y")
            {
                Console.Write("Enter Length: ");
                length = double.Parse(Console.ReadLine());

                Console.Write("Enter Width: ");
                width = double.Parse(Console.ReadLine());
                
                Console.Write("Enter Height: ");
                height = double.Parse(Console.ReadLine());
                
                area = length * width;
                Console.WriteLine($"Area: {area}");
                
                perimeter = (length * 2) + (width * 2);
                Console.WriteLine($"Perimeter: {perimeter}");
                
                volume = area * height;
                Console.WriteLine($"Volume: {volume}\n");

                userContinue = "";
                while (userContinue != "y" && userContinue != "n")
                {
                    Console.WriteLine("Continue? (y/n)");
                    userContinue = Console.ReadLine().ToLower();
                    Console.WriteLine("");
                }

            }
        }
    }
}
