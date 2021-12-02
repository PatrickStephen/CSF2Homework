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

            #region Login
            Login l1 = new Login();
            l1.UserName = "username";
            l1.PassWord = "password";

            Login l2 = new Login("USERNAME", "PASSWORD");
            Console.WriteLine(l1);
            Console.WriteLine(l2);
            #endregion

            #region Contact Info
            ContactInfo c1 = new ContactInfo();
            c1.StreetAddress = "4 Privet Dr";
            c1.City = "St.Louis";
            c1.State = "MO";
            c1.Zip = "65432";
            c1.Phone = "123-456-7890";
            c1.Email = "harry@gmail.com";

            ContactInfo c2 = new ContactInfo("Hogwarts", "Hidden", "Hidden", "Hidden", "Wizards don't have phones", "Harry@mail.owl");
            Console.WriteLine(c1);           
            Console.WriteLine(c2);
            #endregion

            #region Customer
            Customer C1 = new Customer();
            C1.CustomerId = "1234";
            C1.FirstName = "Harry";
            C1.LastName = "Potter";
            C1.ContactInfo = c1;

            Customer C2 = new Customer("1234", "Harry", "Potter", c2);

            Console.WriteLine(C1);
            Console.WriteLine(C2);
            #endregion

            #region CreditCardAccount
            CreditCardAccount a1 = new CreditCardAccount();
            a1.AccountNbr = 12345;
            a1.CustomerInfo = C1;
            a1.Balance = 10;
            a1.IsPastDue = false;
            a1.AnnualInterestRate = 1.2m;

            CreditCardAccount a2 = new CreditCardAccount(67890, C2, 200000, false, 9.8m);

            Console.WriteLine(a1);
            Console.WriteLine(a2);
            #endregion

            #region Book
            Book b1 = new Book();
            b1.Title = "Harry Potter: Philosopher Stone";
            b1.Author = "J.K. Rowling";
            b1.NbrOfPages = 223;

            Book b2 = new Book("Harry Potter: The Chamber of Secrets", "J.K. Rowling", 251);

            Console.WriteLine(b1);
            Console.WriteLine();
            Console.WriteLine(b2);


            #endregion  
        }


    }
}
