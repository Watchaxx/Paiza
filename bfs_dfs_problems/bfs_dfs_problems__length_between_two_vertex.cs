// 実行時間 220ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nx = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();
        int[] d = Repeat( -1, nx[0] + 1 ).ToArray();
        var g = new List<int>[nx[0] + 1];
        var q = new Queue<int>();

        d[nx[1]] = 0;
        foreach( int i in Range( 0, nx[0] + 1 ) ) {
            g[i] = new List<int>();
        }
        foreach( int _ in Range( 0, nx[0] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        q.Enqueue( nx[1] );
        while( 0 < q.Count ) {
            int s = q.Dequeue();

            foreach( int i in g[s].Where( x => d[x] == -1 ) ) {
                d[i] = d[s] + 1;
                q.Enqueue( i );
            }
        }
        WriteLine( d[nx[2]] );
        return;
    }
}
