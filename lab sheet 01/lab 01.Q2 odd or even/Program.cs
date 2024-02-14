using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_day_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lets check the number is odd or even");

            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine($"enter the number{i}: ");
                int number = Convert.ToInt32(Console.ReadLine());
                
                if (number % 2 == 0)
                {
                    Console.WriteLine("even");
                }
                else
                { 
                    Console.WriteLine("odd");
                }
            }
        } 
    }
}
