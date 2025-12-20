// 実行時間 30ms
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
        var g = new List<int>[n[0]];
        var q = new Queue<int>();

        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = new List<int>();
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            d[a[1]]++;
        }
        foreach( int i in Range( 0, n[0] ).Where( x => d[x] == 0 ) ) {
            f++;
            q.Enqueue( i );
        }
        while( 0 < q.Count ) {
            int t = q.Dequeue();

            foreach( int i in g[t] ) {
                d[i]--;
                if( d[i] == 0 ) {
                    f++;
                    q.Enqueue( i );
                }
            }
        }
        WriteLine( f != n[0] ? "Yes" : "No" );
        return;
    }
}
