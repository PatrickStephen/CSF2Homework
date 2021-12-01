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
          
            Student2 s2 = new Student2("Harry", "Potter", "4", 9.75f);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            #endregion

            #region Vehicle
            Vehicle v1 = new Vehicle();
            v1.Make = "Dodge";
            v1.Model = "Charger";
            v1.Year = 1968;
            v1.Weight = 3505f;

            Vehicle v2 = new Vehicle("Chevy", "Bel-Air", 1955, 3153);
            Console.WriteLine(v1);
            Console.WriteLine(v2);

            //Vehicle v
            #endregion

        }
    }
}
