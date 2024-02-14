using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_rushid_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (number > 0) 
            {
                
                for (; number >= 1; number--) 
                {
                    sum = sum + number;
                }
            }
            else 
            {
                Console.WriteLine("ERROR");
             }
            Console.WriteLine($"the answer is {sum} ");
            Console.ReadLine();
        }
    }
}
