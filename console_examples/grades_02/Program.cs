// Libraries
using System;
using System.Collections.Generic; // Include this for short-hand List invokation ability.

namespace Gradebook
{
    class Program
    {
        // Methods
        static void Main(string[] args)
        {
            var book = new Book("Jacob's grade book");
            book.AddGrade(89.1);
            book.AddGrade(78.2);
            book.AddGrade(75.3);
            book.ShowStats();
        } // End main
    } // End class Program
} // End namespace Gradebook