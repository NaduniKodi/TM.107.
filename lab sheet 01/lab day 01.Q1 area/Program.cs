using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_day_01_by_rashid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lets calculate the area of a rectangle");
            

            // get the length 
            Console.WriteLine("Enter the length of the rectangle ");
            double length = Convert.ToDouble(Console.ReadLine());

            // get the width 
            Console.WriteLine("Enter the width of the rectangle ");
            double width = Convert.ToDouble(Console.ReadLine());

            // calculate the area
            double area = CalculateArea(length, width);

            // display the area
            Console.WriteLine($" The area is {area}");
            Console.ReadLine();


        }
        //function to calculate the area
        static double CalculateArea(double length, double width)
        { return length * width; 
        }
    }
}