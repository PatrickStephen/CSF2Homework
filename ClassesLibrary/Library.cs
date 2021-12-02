using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library
    {
        //frugal / fields

        //people / properties
        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        //collect / constructors (ctors)
        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }

        //money / methods
        public Library() { }
        public override string ToString()
        {
            string booksNeeded = "";
            foreach (Book b in Books)
            {
                booksNeeded += b + "\n";
            }//end foreach

            return string.Format("\nThe books we have are: {0}\n" +
                                 "{1}\n" +
                                 "{2}\n" +
                                 "{3}\n" +
                                 "{4}\n" +
                                 "{5}\n",
                                 booksNeeded,
                                 LibraryName,
                                 StreetAddress,
                                 City,
                                 State,
                                 Zip);
        }

    }
}
