using System.Text;

string s = "example";
// Strings are immutable in C#. Therefore, a StringBuilder object will be used to perform the inversion.
StringBuilder sb = new(s);

for (int i = 0; i < s.Length / 2; i++)
{
    char temp = sb[i];
    sb[i] = sb[sb.Length - 1 - i];
    sb[sb.Length - 1 - i] = temp;

    // The solution below uses a tuple to switch the values
    //(sb[sb.Length - 1 - i], sb[i]) = (sb[i], sb[sb.Length - 1 - i]);
}
Console.Write(sb.ToString());
Console.WriteLine();
