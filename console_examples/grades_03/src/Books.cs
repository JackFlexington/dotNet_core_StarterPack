// Libraries
using System;
using System.Collections.Generic; // Include this for short-hand List invokation ability.

namespace Gradebook
{
    public class Book
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

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach(var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }

            result.Average /= grades.Count;
            return result;
        } // End GetStatistics
    } // End class Book
} // End namespace Gradebook