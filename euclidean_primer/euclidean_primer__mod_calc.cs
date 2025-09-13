using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        string[] r = ReadLine().Split( ' ' );
        int a = int.Parse( r[0] );
        int b = int.Parse( r[2] );

        switch( r[1] ) {
        case "+":
            WriteLine( ( a % n + b % n ) % n );
            break;
        case "-":
            WriteLine( ( a % n - b % n + n ) % n );
            break;
        case "*":
            WriteLine( ( a % n ) * ( b % n ) % n );
            break;
        case "^":
            ulong o = 1;

            foreach( int _ in Range( 0, b ) ) {
                o *= (ulong)a;
                o %= (ulong)n;
            }
            WriteLine( o );
            break;
        }
        return;
    }
}
