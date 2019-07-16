using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)

        {
            RoomCalc();
        }
        static void RoomCalc()
        {

            Console.WriteLine("What is the width of the classroom?");
            double roomWidth = double.Parse(Console.ReadLine());

            Console.WriteLine("What is length of the classroom?");
            double roomLength = double.Parse(Console.ReadLine());

            Console.WriteLine("What is height of the classroom?");
            double roomHeight = double.Parse(Console.ReadLine());

            double area = roomLength * roomWidth;
            double volume = roomHeight * roomLength * roomWidth;
            double perimeter = (roomLength + roomWidth) * 2;
            Console.WriteLine("The width is: " + roomWidth);
            Console.WriteLine("The length is: " + roomLength);
            Console.WriteLine("The height is: " + roomHeight);
            Console.WriteLine("The area is: " + area);
            Console.WriteLine("The permiter is: " + perimeter);


            Console.WriteLine("Would you like to keep measuring rooms? (Y/N)");
            char userAnswer = char.Parse(Console.ReadLine());

            if (userAnswer == 'Y' | userAnswer == 'y')
            {
                RoomCalc();
            }

            else
            {
                Console.WriteLine("Have a good day");

            }




            Console.ReadKey();
        }
    }
}
