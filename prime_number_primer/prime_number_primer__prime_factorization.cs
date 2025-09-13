using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        var l = new System.Collections.Generic.List<int>();

        for( int i = 2; i * i <= n; i++ ) {
            if( n % i != 0 ) {
                continue;
            }
            while( n % i == 0 ) {
                l.Add( i );
                n /= i;
            }
        }
        if( n != 1 ) {
            l.Add( n );
        }
        WriteLine( string.Join( System.Environment.NewLine, l.OrderBy( x => x ) ) );
        return;
    }
}
