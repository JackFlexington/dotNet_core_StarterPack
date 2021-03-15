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
List<double> grades = new List<double>(); // Alternatively: List<double> grades = new List<double>() { 12.7, 10.3, 6.11 };
grades.Add(56.1); // Add element to list
grades[0] // Access sub zero
Console.WriteList(grades.Count); // Number of values inside of list
```
```C#
```