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
            List<double> grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1); 

            var result = 0.0;

            foreach(var number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");
        } // End main
    } // End class Program
} // End namespace Gradebook