using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class ContactInfo
    {
        //frugal / fields
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;
        private string _phone;
        private string _email;

        //people / properties
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
            
        //collect / constructors (ctors)
        public ContactInfo(string streetAddress, string city, string state, string zip, string phone, string email)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }
        //money / methods
        public ContactInfo() { }
        public override string ToString()
        {
            return string.Format("Their contact info is: {0}\n" +
                                 "{1}" +
                                 " {2}\n" +
                                 "{3}\n" +
                                 "{4}\n" +
                                 "{5}\n",
                                 StreetAddress,
                                 City,
                                 State,
                                 Zip,
                                 Phone,
                                 Email);
        }

    }
}
