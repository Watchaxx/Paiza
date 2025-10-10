// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var l = new System.Collections.Generic.List<bool>( Repeat( false, n[0] ) );

        l[0] = true;
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] q = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            if( q[0] == 0 ) {
                bool t = l[q[1]];
                l[q[1]] = l[q[2]];
                l[q[2]] = t;
            } else if( q[0] == 1 ) {
                l.Insert( q[2], false );
            }
        }
        WriteLine( l.IndexOf( true ) + 1 );
        return;
    }
}
