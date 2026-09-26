// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int o = 0;
        int[] xyn = ReadLine().Split().Select( int.Parse ).ToArray();
        var h = new SortedSet<int>();
        var l = new List<int>( xyn[0] * xyn[1] );

        foreach( int _ in Range( 0, xyn[1] ) ) {
            l.AddRange( ReadLine().Trim().Split().Select( int.Parse ) );
        }
        foreach( int _ in Range( 0, xyn[2] ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            foreach( int y in Range( t[1], t[3] - t[1] + 1 ) ) {
                foreach( int x in Range( t[0], t[2] - t[0] + 1 ) ) {
                    h.Add( x + xyn[0] * y );
                }
            }
        }
        foreach( int i in h ) {
            o += l[i];
        }
        WriteLine( o );
        return;
    }
}
