// Verbatim string literals
var s = @"c:\source";
Console.WriteLine(s);

// Unicode escape characters (UTF-16)
// Kon' nichiwa
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F");

// String interpolation
Console.WriteLine($"The path I set earlier: {s}");

// Combining verbatim and string interpolation
string projectName = "MyProject";
Console.WriteLine(@$"C:\Output\{projectName}\Data");

// C# is smart
int willBeConvertedToStringOnConcatenation = 1;
Console.WriteLine("This is the number " + willBeConvertedToStringOnConcatenation + " C# cheatsheet.");
// prints -> This is the number 1 C# cheatsheet.

// C# can't be so smart
int anotherInt = 1;
Console.WriteLine("1 + 1 = " + willBeConvertedToStringOnConcatenation + anotherInt);
// prints -> 1 + 1 = 11
// Since both ints are converted to string, they are concatenated, not added.
//Here's a fix:
Console.WriteLine("1 + 1 = " + (willBeConvertedToStringOnConcatenation + anotherInt));
