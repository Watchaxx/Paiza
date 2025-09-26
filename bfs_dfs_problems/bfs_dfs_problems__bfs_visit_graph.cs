// 実行時間 40ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        bool[] b = Repeat( true, n[0] ).ToArray();
        var g = new List<int>[n[0]];
        var q = new Queue<int>();

        b[n[2] - 1] = false;
        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = new List<int>();
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        foreach( var l in g ) {
            l.Sort();
        }
        q.Enqueue( n[2] - 1 );
        while( 0 < q.Count ) {
            int s = q.Dequeue();

            WriteLine( s + 1 );
            foreach( int i in g[s].Where( x => b[x] ) ) {
                b[i] = false;
                q.Enqueue( i );
            }
        }
        return;
    }
}
