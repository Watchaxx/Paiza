// 実行時間 160ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        const long mod = 1000000007L;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = new int[n[0]];
        long o = 0L;
        long[] s = Repeat( 1L, n[0] ).ToArray();
        var g = new List<int>[n[0]];
        var q = new Queue<int>();

        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = new List<int>();
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] p = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[p[1]].Add( p[0] );
            d[p[0]]++;
        }
        foreach( int i in Range( 0, n[0] ).Where( x => d[x] == 0 ) ) {
            q.Enqueue( i );
        }
        while( 0 < q.Count ) {
            int t = q.Dequeue();

            foreach( int i in g[t] ) {
                d[i]--;
                s[i] += s[t];
                s[i] %= mod;
                if( d[i] == 0 ) {
                    q.Enqueue( i );
                }
            }
        }
        foreach( int _ in Range( 0, n[2] ) ) {
            o += s[int.Parse( ReadLine() ) - 1];
            o %= mod;
        }
        WriteLine( o );
        return;
    }
}
