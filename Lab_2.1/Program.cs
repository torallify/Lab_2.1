using System;

namespace Lab_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            string userContinue = null;
            do
            {
                Console.WriteLine();
                Console.Write("Enter Length: ");
                double inputLength = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Width: ");
                double inputWidth = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Height: ");
                double inputHeight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                double perimeter = 2 * (inputLength + inputWidth);
                Console.WriteLine("Perimeter: " + perimeter);

                double area = inputWidth * inputLength;
                Console.WriteLine("Area: " + area);

                double volume = inputLength * inputHeight * inputWidth;
                Console.WriteLine("Volume: " + volume);

                string roomSize = null;
                if (area <= 250)
                {
                    roomSize = "small-sized";
                }
                else if (area > 250 && area < 650)
                {
                    roomSize = "medium-sized";
                }
                else if(area > 650)
                {
                    roomSize = "large-sized";
                }

                Console.WriteLine("This is a " + roomSize + " room.");
                Console.WriteLine();

                Console.Write("Would you like to continue? (y/n) ");
                userContinue = Console.ReadLine().ToLower();
                

            } while (userContinue == "y" || userContinue == "yes");

            Console.WriteLine();
            Console.WriteLine("Thank you for using the Room Detail Generator!");
        }
    }
}
