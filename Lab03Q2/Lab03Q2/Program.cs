using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03Q2
{
    public class Employee
    {
        public int employeeID;
        public string fullName;
        public double salary;

        public Employee(int employeeID, string fullName, double salary)//constructors
        {

            this.employeeID = employeeID;
            this.fullName = fullName;   
            this.salary = salary;

        }

        public int EmployeeID => employeeID;//read only property

        public string FullName//read-write property
        {
            get => fullName;
            set => fullName= value;
        }
        public double Salary
        {
            get => salary;
            set => salary = value;
        }

        public void Displayemployeeinfo()
        {
            Console.WriteLine($"Employee ID:{employeeID}");
            Console.WriteLine($"Full Name:{fullName}");
            Console.WriteLine($"Salary: ${salary}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(101, "John Doe", 50000);

            Console.WriteLine("Employee Information:");
            employee.Displayemployeeinfo();

            Console.WriteLine($"Employee ID:{employee.EmployeeID}");

            employee.FullName = "James Smith";//update fullname
            Console.WriteLine($"Updated Full Name:{employee.fullName}");

            //Attempt modify the salary directly from external code
            //This will work because the salary property has a public setter

            employee.salary = 55000;
            Console.WriteLine($"Updated Salary: ${employee.salary}");

            Console.ReadLine();
        
        
        }
    }
}
