// 実行時間 240ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();
        int[] d = new int[n[0] + 1];
        int[] l = Repeat( -1, n[0] + 1 ).ToArray();
        var g = new List<int>[n[0] + 1];
        var q = new Queue<int>();

        foreach( int i in Range( 0, n[0] + 1 ) ) {
            g[i] = new List<int>();
        }
        foreach( int _ in Range( 0, n[0] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            d[a[0]]++;
            d[a[1]]++;
            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        l[n[1]] = 0;
        q.Enqueue( n[1] );
        while( 0 < q.Count ) {
            int c = q.Dequeue();

            foreach( int i in g[c].Where( x => l[x] == -1 ) ) {
                l[i] = l[c] + 1;
                q.Enqueue( i );
            }
        }
        WriteLine( d[n[1]] < 2 ? 5 * l[n[2]] : 10 + 5 * l[n[2]] );
        return;
    }
}
