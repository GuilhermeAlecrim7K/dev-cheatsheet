//https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

/* Formatting integral type values */
int number = 1234;

// Use String.Format with zero-padding to ensure 6 characters
Console.WriteLine(String.Format("{0:D6}", number));
// Use string interpolation with a width specifier and zero-padding to ensure 6 characters
Console.WriteLine($"{number:000000}");
// Use string interpolation with a width specifier to ensure 6 characters
Console.WriteLine($"{number,6}");

/* Formatting floating point values */
double myValue = 12345.6789;
Console.WriteLine($"{myValue:F2}"); // 12345.68 -> rounded
Console.WriteLine(myValue.ToString("F2"));
Console.WriteLine(string.Format("{0:F2}", myValue));

/* Custom Formats */

//F => fixed point notation
Console.WriteLine($"{myValue:F2}"); // 12345.68

//C => currency notation
//Output depends on current culture
Console.WriteLine($"{myValue:C}"); // $ 12,345.68

//E => exponential
Console.WriteLine($"{myValue:E2}"); // 1.23E+004

//N => number
Console.WriteLine($"{myValue:N2}"); // 12,345.68

//P => percentage
Console.WriteLine($"{myValue:P2}"); // 1,234,567.89 %

// Override culture info for the application
CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");
