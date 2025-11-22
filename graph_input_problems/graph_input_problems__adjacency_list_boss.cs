// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var g = new List<int>[n[0]];

        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = new List<int>();
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            g[t[0] - 1].Add( t[2] );
        }
        foreach( var l in g ) {
            WriteLine( 0 < l.Count ? string.Join( " ", l ) : "-1" );
        }
        return;
    }
}
