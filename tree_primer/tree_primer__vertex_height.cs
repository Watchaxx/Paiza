// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;
using Tpl = System.Tuple<int, int>;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = Repeat( -1, n[0] ).ToArray();
        var g = new List<int>[n[0]];
        var q = new Queue<int>( n[0] );
        Tpl[] e = new Tpl[n[0] - 1];

        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = new List<int>( n[0] );
        }
        foreach( int i in Range( 0, n[0] - 1 ) ) {
            int[] a = ReadLine().Trim().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            e[i] = new Tpl( a[0], a[1] );
            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        d[n[1] - 1] = 0;
        q.Enqueue( n[1] - 1 );
        while( 0 < q.Count ) {
            int c = q.Dequeue();

            foreach( int i in g[c].Where( i => d[i] == -1 ) ) {
                d[i] = d[c] + 1;
                q.Enqueue( i );
            }
        }
        foreach( int i in Range( 0, n[0] - 1 ) ) {
            WriteLine( d[e[i].Item1] < d[e[i].Item2] ? 'A' : 'B' );
        }
        return;
    }
}
