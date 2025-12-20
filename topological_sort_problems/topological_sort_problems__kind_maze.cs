// 実行時間 140ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int f = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = new int[n[0]];
        long[] r = new long[n[0]];
        var o = new List<int>();
        var g = new List<int>[n[0]];
        var q = new Queue<int>();

        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = new List<int>();
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[t[0]].Add( t[1] );
            d[t[1]]++;
        }
        foreach( int i in Range( 0, n[0] ).Where( x => d[x] == 0 ) ) {
            f++;
            r[i] = 1L;
            q.Enqueue( i );
        }
        while( 0 < q.Count ) {
            int t = q.Dequeue();

            if( g[t].Count == 0 ) {
                o.Add( t );
                continue;
            }
            foreach( int i in g[t] ) {
                d[i]--;
                r[i] += r[t];
                r[i] %= 1000000007L;
                if( d[i] == 0 ) {
                    f++;
                    q.Enqueue( i );
                }
            }
        }
        if( f == n[0] ) {
            WriteLine( "Yes" );
            WriteLine( string.Join( System.Environment.NewLine, o.OrderBy( x => x ).Select( x => $"{x + 1} {r[x]}" ) ) );
        } else {
            WriteLine( "No" );
        }
        return;
    }
}
