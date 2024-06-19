/*
    float
        - Ranges from 1.5 x 10⁻⁴⁵ to 3.4 x 10³⁸
        - 7 digit precision
*/
float myFloatLiteral = 0.25F;

/*
    double
        - Ranges from 5.0 x 10⁻³²⁴ to 1.7 x 10³⁰⁸
        - 15~16 digit precision
*/
double myDoubleLiteral = 0.625;

/*
    decimal
        - Ranges from -7.9 x 10⁻²⁸ to 7.9 x 10²⁸
        - 28 digit precision
*/
decimal myDecimalLiteral = 12.39816m;

/* Formatting floating point values */
double myValue = 12345.6789;
Console.WriteLine($"{myValue:F2}"); // 12345.68 -> rounded
Console.WriteLine(myValue.ToString("F2"));
Console.WriteLine(string.Format("{0:F2}", myValue));

/* Custom Formats */

//F => fixed point notation
Console.WriteLine($"{myValue:F2}"); // 12345.68

//E => exponential
Console.WriteLine($"{myValue:E2}"); // 1.23E+004

//N => number
Console.WriteLine($"{myValue:N2}"); // 12,345.68

//P => percentage
Console.WriteLine($"{myValue:P2}"); // 1,234,567.89 %
