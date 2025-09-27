// 実行時間 30ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = Repeat( -1, n[0] ).ToArray();
        var g = new List<int>[n[0]];
        var q = new Queue<int>();

        d[n[2] - 1] = 0;
        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = new List<int>();
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        q.Enqueue( n[2] - 1 );
        while( 0 < q.Count ) {
            int s = q.Dequeue();

            foreach( int i in g[s].Where( x => d[x] < 0 ) ) {
                d[i] = d[s] + 1;
                q.Enqueue( i );
            }
        }
        WriteLine( d[n[3] - 1] );
        return;
    }
}
