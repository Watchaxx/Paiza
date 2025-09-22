// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nr = ReadLine().Split().Select( int.Parse ).ToArray();
        var g = new List<int>[nr[0]];

        foreach( int i in Range( 0, nr[0] ) ) {
            g[i] = new List<int>( nr[0] );
        }
        foreach( int _ in Range( 0, nr[0] - 1 ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }

        int[] kr = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = Repeat( -1, nr[0] ).ToArray();
        var q = new Queue<int>( nr[0] );

        d[kr[1] - 1] = 0;
        q.Enqueue( kr[1] - 1 );
        while( 0 < q.Count ) {
            int c = q.Dequeue();

            foreach( int i in g[c].Where( x => d[x] == -1 ) ) {
                d[i] = d[c] + 1;
                q.Enqueue( i );
            }
        }
        foreach( int _ in Range( 0, kr[0] ) ) {
            int v = int.Parse( ReadLine() ) - 1;

            foreach( int i in g[v].Where( x => d[x] + 1 == d[v] ) ) {
                WriteLine( i + 1 );
            }
        }
        return;
    }
}
