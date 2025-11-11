using static System.Console;

internal class Program
{
    static void Main()
    {
        WriteLine( string.Compare( ReadLine(), ReadLine(), System.StringComparison.Ordinal ) == 0
            ? "OK" : "NG" );
        return;
    }
}
