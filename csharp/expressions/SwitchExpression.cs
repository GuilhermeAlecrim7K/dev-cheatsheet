// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/switch-expression

int aNumber = 23;
string myString = aNumber switch
{
    0 => "zero",
    <= 10 => "lower than or equal to ten and not zero",
    100 => "a hundred",
    _ => "if all else fails"
};
Console.WriteLine(myString); // prints `if all else fails`
