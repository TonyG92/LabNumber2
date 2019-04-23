using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, area, perimeter;
            string response = "y";

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            //Area of a rectangle: A = width * height
            //Perimeter of a rectangle: P = 2*(width + height)
            // If you type anything other then "y" the program ends.
            while (response == "y")
            {

                Console.WriteLine("Enter Length: ");
                length = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width: ");
                width = double.Parse(Console.ReadLine());

                area = length * width;
                perimeter = 2 * (length + width);

                Console.WriteLine("Area: {0}", area);
                Console.WriteLine("Perimeter: {0}", perimeter);

                Console.WriteLine("Continue? (y/n): ");

                response = Console.ReadLine();
            }

        }
    }
}
