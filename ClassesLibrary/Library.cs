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
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public List<Book> Books { get; set; }

        //collect / constructors (ctors)
        public Library(string libraryName, string streetAddress, string city, string state, string zip, List<Book> books)
        {
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Books = books;
        }

        //money / methods
        public Library() { }
        public override string ToString()
        {
            string booksInStock = "";
            foreach (Book b in Books)
            {
                booksInStock += b.Title + "\n";
            }//end foreach

            return string.Format("\n{0}\n" +
                                 "{1}\n" +
                                 "{2}\n" +
                                 "{3}\n" +
                                 "{4}\n" +
                                 "\nThe books we have are: {5}\n",
                                 LibraryName,
                                 StreetAddress,
                                 City,
                                 State,
                                 Zip,
                                 booksInStock);
        }

    }
}
