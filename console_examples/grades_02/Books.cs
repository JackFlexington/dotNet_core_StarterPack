// Libraries
using System;
using System.Collections.Generic; // Include this for short-hand List invokation ability.

namespace Gradebook
{
    class Book
    {
        // Constructor
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name; // this = object being operated on.
        } // End constructor

        // Field names
        private List<double> grades = new List<double>();
        private String name;
        
        // Methods
        public void AddGrade(double grade)
        {
            Console.WriteLine($"Adding grade {grade}");
            grades.Add(grade);
        } // End AddGrade

        public void ShowStats()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }

            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");
            Console.WriteLine($"Highest grade is {highGrade}");
            Console.WriteLine($"Lowest grade is {lowGrade}");
            Console.WriteLine($"Gradebook's name is {name}");
        } // End ShowStats

    } // End class Book
} // End namespace Gradebook