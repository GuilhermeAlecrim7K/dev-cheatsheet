// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/checked-and-unchecked

/*
The checked and unchecked statements specify the overflow-checking context for integral-type arithmetic operations and conversions.
*/

Example1();
Example2();
Example3();
// Set CheckForOverflowUnderFlow compiler option to change default behavior

static void Example1()
{
    /*
    In a checked context, a System.OverflowException is thrown; if overflow happens in a constant expression, a compile-time error occurs. In an unchecked context, the operation result is truncated by discarding any high-order bits that don't fit in the destination type.
    */
    uint a = uint.MaxValue;

    unchecked
    {
        Console.WriteLine(a + 3);  // output: 2
    }

    try
    {
        checked
        {
            Console.WriteLine(a + 3);
        }
    }
    catch (OverflowException e)
    {
        Console.WriteLine(e.Message);  // output: Arithmetic operation resulted in an overflow.
    }
}

static void Example2()
{
    /*
    To specify the overflow-checking context for an expression, you can also use the checked and unchecked operators, as the following example shows:
    */
    double a = double.MaxValue;

    int b = unchecked((int)a);
    Console.WriteLine(b);  // output: -2147483648

    try
    {
        b = checked((int)a);
    }
    catch (OverflowException e)
    {
        Console.WriteLine(e.Message);  // output: Arithmetic operation resulted in an overflow.
    }
}

static void Example3()
{
    /*
    The checked and unchecked statements and operators only affect the overflow-checking context for those operations that are textually inside the statement block or operator's parentheses, as the following example shows:
    */
    int Multiply(int a, int b) => a * b;

    int factor = 2;

    try
    {
        checked
        {
            Console.WriteLine(Multiply(factor, int.MaxValue));  // output: -2
        }
    }
    catch (OverflowException e)
    {
        Console.WriteLine(e.Message);
    }

    try
    {
        checked
        {
            Console.WriteLine(Multiply(factor, factor * int.MaxValue));
        }
    }
    catch (OverflowException e)
    {
        Console.WriteLine(e.Message);  // output: Arithmetic operation resulted in an overflow.
    }
}         