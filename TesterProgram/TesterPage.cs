using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class TesterPage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CSF2 Homework Packet");
            Console.Title = "CSF2 Homework Lab";
            Console.WriteLine();

            #region Student
            Student2 s1 = new Student2();
            s1.FirstName = "John";
            s1.LastName = "Wick";
            s1.Id = "1234";
            s1.Gpa = 3.5f;

            Console.WriteLine($"{s1.FirstName} {s1.LastName}'s school ID # is {s1.Id}. They have a GPA of {s1.Gpa}");

            //Student2 s2 = new Student2();
            //s2.FirstName = "Harry";
            //s2.LastName = "Potter";
            //s2.Id = "4";
            //s2.Gpa = 9.75f;

            Student2 s2 = new Student2("Harry", "Potter", "4", 9.75f);
            Console.WriteLine(s2);
            #endregion



        }
    }
}
