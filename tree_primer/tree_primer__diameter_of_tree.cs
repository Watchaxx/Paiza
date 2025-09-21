// 実行時間 20ms
using System;
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int x = -1;
        int[] d = Repeat( -1, n + 1 ).ToArray();
        var g = new List<int>[n + 1];
        var q = new Queue<int>( n );

        foreach( int i in Range( 1, n ) ) {
            g[i] = new List<int>( n );
        }
        foreach( int _ in Range( 0, n - 1 ) ) {
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        foreach( int i in Range( 1, n ).Where( i => 0 < g[i].Count ) ) {
            d[i] = 0;
            q.Enqueue( i );
            break;
        }
        while( 0 < q.Count ) {
            int c = q.Dequeue();

            foreach( int i in g[c].Where( i => d[i] == -1 ) ) {
                d[i] = d[c] + 1;
                x = Math.Max( x, d[i] );
                q.Enqueue( i );
            }
        }
        x = Array.IndexOf( d, x );
        d = Repeat( -1, n + 1 ).ToArray();
        d[x] = 0;
        q.Enqueue( x );
        x = -1;
        while( 0 < q.Count ) {
            int c = q.Dequeue();

            foreach( int i in g[c].Where( i => d[i] == -1 ) ) {
                d[i] = d[c] + 1;
                x = Math.Max( x, d[i] );
                q.Enqueue( i );
            }
        }
        WriteLine( x );
        return;
    }
}
