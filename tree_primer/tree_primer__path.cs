// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nab = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] p = Repeat( -1, nab[0] ).ToArray();
        int b = nab[2] - 1;
        var o = new List<int>( nab[0] );
        var g = new List<int>[nab[0]];
        var q = new Queue<int>( nab[0] );

        foreach( int i in Range( 0, nab[0] ) ) {
            g[i] = new List<int>( nab[0] );
        }
        foreach( int _ in Range( 0, nab[0] - 1 ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        p[nab[1] - 1] = -2;
        q.Enqueue( nab[1] - 1 );
        while( 0 < q.Count ) {
            int c = q.Dequeue();

            foreach( int i in g[c].Where( i => p[i] == -1 ) ) {
                p[i] = c;
                q.Enqueue( i );
            }
        }
        while( p[b] != -2 ) {
            o.Add( b );
            b = p[b];
        }
        o.Add( b );
        WriteLine( string.Join( System.Environment.NewLine, o.Select( x => x + 1 ).Reverse() ) );
        return;
    }
}
