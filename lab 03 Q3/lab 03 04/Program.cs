using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03_04
{
    public class Course
    {
        private string courseName;
        private string instructorName;
        private double grade;

        public string GetCourseName()
        {
            return courseName;
        }

        public string GetInstructorName()
        {
            return instructorName;
        }

        public void SetCourseName(string courseN)
        {
            courseName = courseN;
        }

       public void SetInstructorName(string instructorN)
        {
            if (instructorName != "")
            {
                instructorName = instructorN;
            }
        }  

        public void SetGrade(double G) 
        {
            G = grade; 
        }
    
        public string CalculateLetterGrade(double G)
        {
            if(G>75)
            {
                return "A";
            } 
            else if(G>65)
            { 
                return "B";
            }
            else if (G > 55)
            {
                return "C";
            }
            else if(G > 45)
            { 
                return "D";
            }
            else
            {
                return "E";
            }
        }

        public void PrintCourseName()
        {
            Console.WriteLine("Course name is" + courseName);
            Console.WriteLine("Instructor name is" + instructorName);
            Console.WriteLine("Calculate grade " + CalculateLetterGrade(grade));
        }
    
    
    
    }

   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NSBM lab practicals");
            Course course1 = new Course();
            course1.SetCourseName("C#");

            Course instructor1 = new Course();
            instructor1.SetInstructorName("Naduni");

            course1.SetGrade(67);

            course1.PrintCourseName();
        }
    }
}
