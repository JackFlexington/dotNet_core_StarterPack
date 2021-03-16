```C#
// String interpretation
Console.WriteLine($"Hello, {args[0]}!");
// $ = allows you to insert {variable} values into string. (Like BASH)

// Number formatting
Console.WriteLine($"{result:N2}"); // If used on a double, sets precision of displaying value
```

```C#
// Initialize array of double datatype, plus assignment.
double[] numbers = new double[3] { 12.7, 10.3, 6.11 }; 

// Assign sub-element of array
numbers[0] = 3.14; 
```
```C#
// Implicitly assign datatypes, must provide some value.
var number = 3.14;
```
```C#
// For each
foreach(double number in numbers)
{
    Console.WriteLine("Perform instruction here");
}
```
```C#
// Namespace
using System.Collections.Generic; // Include this for short-hand List invokation ability.
// Create new list of double datatype
List<double> grades = new List<double>(); 
// Alternatively: List<double> grades = new List<double>() { 12.7, 10.3, 6.11 };
// Alternatively: var grades = new List<double>();

grades.Add(56.1); // Add element to list
grades[0] // Access sub zero
Console.WriteList(grades.Count); // Number of values inside of list
```
```C#
namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write primary business logic for "Main" method of class "Program", that resides in the "Gradebook" domain.
            // Reasons why: Well, you can assume that the code/programs that manage the cafe's inventory isn't going to be within this namespace.
        }
    }
}
```

```C#
// Static - Explicitly means this isn't an Object and is only accessible via the parent Class. (Ex. Program.Main(args)... see above code block for context)
// Public - Object is accessible from outside of Class code
// Private - Object is only accessible from inside of Class code
```
```C#
// Double Libraries
var highGrade = double.MinValue;
// Math Libraries
highGrade = Math.Max(number, highGrade);
```
```C#
```
```C#
```