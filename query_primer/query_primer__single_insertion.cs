using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var l = new System.Collections.Generic.List<int>( n[0] + 1 );

        foreach( int i in Enumerable.Range( 1, n[0] ) ) {
            l.Add( int.Parse( ReadLine() ) );
            if( i == n[1] ) {
                l.Add( n[2] );
            }
        }
        WriteLine( string.Join( System.Environment.NewLine, l ) );
        return;
    }
}
