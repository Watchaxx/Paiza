// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nax = ReadLine().Trim().Split().Select( int.Parse ).ToArray();
        int[] d = Repeat( -1, nax[0] + 1 ).ToArray();
        var g = new List<int>[nax[0] + 1];
        var q = new Queue<int>( nax[0] );

        d[nax[1]] = 0;
        foreach( int i in Range( 1, nax[0] ) ) {
            g[i] = new List<int>( nax[0] );
        }
        foreach( int _ in Range( 0, nax[0] - 1 ) ) {
            int[] a = ReadLine().Trim().Split().Select( int.Parse ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        q.Enqueue( nax[1] );
        while( 0 < q.Count ) {
            int v = q.Dequeue();

            foreach( int i in g[v].Where( i => d[i] == -1 ) ) {
                d[i] = d[v] + 1;
                q.Enqueue( i );
            }
        }
        foreach( int i in Range( 0, nax[0] + 1 ).Where( i => d[i] == nax[2] ) ) {
            WriteLine( i );
        }
        return;
    }
}
