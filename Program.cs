using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Enter the width: ");
            int width = int.Parse(Console.ReadLine());

            int area = length * width;

            Console.WriteLine("The area is " + area + "\n");
        }

            static int Area(int l, int w)
            {
            ar=l*w;
            Console.WriteLine("Enter length and width");
            
            }



        
    }
}
