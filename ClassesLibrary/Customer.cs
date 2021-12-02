using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        //frugal / fields
        
        //people / properties
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInfo { get; set; }

        //collect / constructors (ctors)
        public Customer(string customerId, string firstName, string lastName, ContactInfo contactInfo)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            ContactInfo = contactInfo;
        }//end FQ CTOR

        //money / methods
        public Customer() { }
        public override string ToString()
        {
           
            return string.Format($"\nCustomerId: {CustomerId}\n" +
                $"Name is {FirstName} {LastName}\n" +
                $"{ContactInfo}\n");
        }
    }
}
