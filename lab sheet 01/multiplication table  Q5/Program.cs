using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table__Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to display the multiplication table of the number");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine($"{i+1} x {x} = {(i+1)*x}");
            }
        }
    }
}
