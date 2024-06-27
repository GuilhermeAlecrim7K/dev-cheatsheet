using System.Collections.Immutable;

public class Program
{
    // This array is readonly. Its reference can't be changed. However, the elements can still be modified.
    private static readonly string[] ReadOnlyArray = { "zero", "one", "two", "three" };

    // The elements of an ImmutableArray on the other hand cannot be modified.
    private static readonly ImmutableArray<string> MyImmutableArray = ImmutableArray.Create(["One", "Two"]);

    public static void Main()
    {
        ReadOnlyArray[0] = "new value";
        Console.WriteLine(string.Join(',', ReadOnlyArray));

        // Compilation error
        // MyImmutableArray[0] = "Zero";
        Console.WriteLine(string.Join(';', MyImmutableArray));
    }
}
