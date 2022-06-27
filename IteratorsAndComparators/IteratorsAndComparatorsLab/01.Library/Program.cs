using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, new List<string>() { "George Orwell" });
            Book bookTwo = new Book("The Documents in the Case", 2002, new List<string>() { "Dorothy Sayers", "Robert Eustace" });
            Book bookThree = new Book("The Documents in the Case", 1930, new List<string>());

            Library libraryOne = new Library(new List<Book>());
            Library libraryTwo = new Library(new List<Book>() { bookOne, bookTwo, bookThree });

            
        }
    }
}
