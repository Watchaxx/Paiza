using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int _ in Enumerable.Range( 0, n[0] ) ) {
            if( int.Parse( ReadLine() ) == n[1] ) {
                WriteLine( "YES" );
                return;
            }
        }
        WriteLine( "NO" );
        return;
    }
}
