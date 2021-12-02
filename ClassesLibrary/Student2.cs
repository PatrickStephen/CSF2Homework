using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Student2
    {       
        //Frugal / Fields
        //private datatype _camelCase
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        //People / Properties
        //public datatype PascalCase
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }//end FirstName

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }//end LastName

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }//end ID

        public float Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }//end Gpa

        //Collect / Constructors (ctor)
        //public ClassName(datatype paramerName)
        public Student2(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Gpa = gpa;
        }//end FQ CTOR

        //money / methods
        public Student2() { }
        public override string ToString()
        {
            return string.Format("Student is: {0} {1}\n" +
                                 "ID: {2}\n" +
                                 "GPA: {3:f}\n",
                                 FirstName,
                                 LastName,
                                 Id,
                                 Gpa);
        }//end ToString()
    }
}
