/*--------------------------------------------------------*/

Console.WriteLine("Signed integral types");

Console.WriteLine($"sbyte: {(sbyte.MinValue),20} to {(sbyte.MaxValue),20}");
Console.WriteLine($"short: {(short.MinValue),20} to {(short.MaxValue),20}");
Console.WriteLine($"int:   {(int.MinValue),20} to {(int.MaxValue),20}");
Console.WriteLine($"long:  {(long.MinValue),20} to {(long.MaxValue),20}");

/*--------------------------------------------------------*/

Console.WriteLine("Unsigned integral types");

Console.WriteLine($"byte:   {(byte.MinValue)} to {(byte.MaxValue)}");
Console.WriteLine($"ushort: {(ushort.MinValue)} to {(ushort.MaxValue)}");
Console.WriteLine($"uint:   {(uint.MinValue)} to {(uint.MaxValue)}");
Console.WriteLine($"ulong:  {(ulong.MinValue)} to {(ulong.MaxValue)}");

/*--------------------------------------------------------*/

// Integer literals
uint uintNumber = 123U;      // Unsigned int
long longNumber = 123L;      // Long
ulong ulongNumber = 123UL;   // Unsigned long

/*--------------------------------------------------------*/
