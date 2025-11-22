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
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[t[0]].Add( t[1] );
            g[t[1]].Add( t[0] );
        }
        WriteLine( string.Join( System.Environment.NewLine,
            Range( 0, n[0] ).Select( x => string.Join( " ", g[x].Select( y => y + 1 ) ) ) ) );
        return;
    }
}
