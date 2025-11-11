using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int i = 0;

        foreach( int _ in Range( 0, 5 ).Where( x =>
        string.Compare( ReadLine(), "Attack", System.StringComparison.Ordinal ) == 0 ) ) {
            i++;
        }
        WriteLine( 100 * i );
        return;
    }
}
