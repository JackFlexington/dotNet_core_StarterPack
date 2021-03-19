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
            var stats = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
        } // End main
    } // End class Program
} // End namespace Gradebook