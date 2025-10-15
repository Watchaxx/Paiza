// 実行時間 230ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nmxyz = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] c = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = Repeat( -1, nmxyz[0] ).ToArray();
        var g = new List<int>[nmxyz[0]];
        var o = new List<int>();
        var q = new Queue<int>();

        d[nmxyz[2] - 1] = 0;
        foreach( int i in Range( 0, nmxyz[0] ) ) {
            g[i] = new List<int>();
        }
        foreach( int _ in Range( 0, nmxyz[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        q.Enqueue( nmxyz[2] - 1 );
        while( 0 < q.Count ) {
            int n = q.Dequeue();

            foreach( int i in g[n].Where( x => d[x] == -1 ) ) {
                d[i] = d[n] + 1;
                q.Enqueue( i );
            }
        }
        foreach( int i in Range( 0, nmxyz[0] ).Where( x => 5 * d[x] <= nmxyz[3] && c[x] == nmxyz[4] ) ) {
            o.Add( i + 1 );
        }
        WriteLine( o.Count );
        WriteLine( string.Join( System.Environment.NewLine, o ) );
        return;
    }
}
