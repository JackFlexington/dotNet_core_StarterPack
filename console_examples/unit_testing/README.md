# Unit Testing

## Verify
Testing trying to prove the code is behaving correctly.

## Investigate
Explore when things go wrong such as, user failed to enter anything. Or maybe entered special characters ($,#,!,@,etc...)

## Unit Testing
Testing of small blocks of code. (i.e. a singular method)

## Test Runner
Finds all of the unit tests, and executes the test.

## Automation
The codification of testing.

## xUnit.net
Not a part of Dot Net Core, but is available.

## Using the testing
* Creating the unit tests directory via ```dotnet new xunit```
* Executing the unit tests... ```dotnet test``` (While in the GradeBook.Tests directory)

## Building the Unit Test
* ```C# 
  [Fact]
  public void Test1()
  {
    // Arrange
    var x = 5;
    var y = 2;
    var expected = 7;

    // Actual
    var actual = x * y;

    // Assert
    Assert.Equal(expected, actual);
  }
  ```

# Notes:
* Name of the directory that houses the MUST match the projects name... I think?
  * Ex. ```/dotnet/GradeBook/test/GradeBook.Tests/``` is a valid naming convention
