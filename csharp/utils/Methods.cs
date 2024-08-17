/*

When an argument is passed to a method, value type variables have their values copied into the method. Each variable has its own copy of the value, so the original variable isn't modified.

With reference types, the address of the value is passed into the method. The variable given to the method references the value at that address, so operations on that variable affect the value that is referenced by the other.

*/

int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}");

void Multiply(int a, int b, int c)
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}

int[] numbers = { 1, 2, 3, 4, 5 };

// Named parameters
PrintArray(array: numbers);
Clear(array: numbers);
PrintArray(array: numbers);

void PrintArray(int[] array)
{
    foreach (int a in array)
        Console.Write($"{a} ");
    Console.WriteLine();
}

void Clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = 0;
}
