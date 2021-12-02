using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {
        //frugal / fields

        //people / properties
        public string Title { get; set; }
        public string Author { get; set; }
        public int NbrOfPages { get; set; }

        //collect / constructors (ctors)
        public Book(string title, string author, int nbrOfPages)
        {
            Title = title;
            Author = author;
            NbrOfPages = nbrOfPages;
        }
        //money / methods
        public Book() { }
        public override string ToString()
        {
            return string.Format("{0}\n" +
                                 "written by {1}\n" +
                                 "with {2} pages",
                                 Title,
                                 Author,
                                 NbrOfPages);
        }
    }
}
