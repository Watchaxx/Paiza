// 実行時間 240ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nx = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = Repeat( -1, nx[0] ).ToArray();
        var g = new List<int>[nx[0]];
        var q = new Queue<int>();

        nx[1]--;
        d[nx[1]] = 0;
        foreach( int i in Range( 0, nx[0] ) ) {
            g[i] = new List<int>();
        }
        foreach( int _ in Range( 0, nx[0] - 1 ) ) {
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
        // d.Select( ( x, i ) => (x, i) ).Where( x => x.x == nx[2] ).ToList().ForEach( x => WriteLine( x.i + 1 ) );
        foreach( int i in Range( 0, nx[0] ).Where( x => d[x] == nx[2] ) ) {
            WriteLine( i + 1 );
        }
        return;
    }
}
