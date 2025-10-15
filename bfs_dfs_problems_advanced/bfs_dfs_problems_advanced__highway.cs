// 実行時間 220ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] t = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] l = Repeat( -1, n[0] ).ToArray();
        var g = new List<int>[n[0]];
        var q = new Queue<int>();

        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = new List<int>();
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        l[0] = 0;
        q.Enqueue( 0 );
        while( 0 < q.Count ) {
            int c = q.Dequeue();

            foreach( int i in g[c].Where( x => l[x] == -1 ) ) {
                l[i] = l[c] + 1;
                q.Enqueue( i );
            }
        }
        WriteLine( Range( 0, n[0] ).Where( x => 5 * l[x] < t[x] ).Count() );
        return;
    }
}
