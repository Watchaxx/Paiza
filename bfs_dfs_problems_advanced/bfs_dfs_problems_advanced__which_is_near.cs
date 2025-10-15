// 実行時間 230ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nmxy = ReadLine().Split().Select( int.Parse ).ToArray();
        var g = new List<int>[nmxy[0]];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, nmxy[0] ) ) {
            g[i] = new List<int>();
        }
        foreach( int _ in Range( 0, nmxy[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }

        int[] dx = Bfs( nmxy[2] - 1, g );
        int[] dy = Bfs( nmxy[3] - 1, g );

        foreach( int i in Range( 0, nmxy[0] ) ) {
            WriteLine( dx[i] < dy[i] ? "X is closer" : dy[i] < dx[i] ? "Y is closer" : "Same" );
        }
        Out.Flush();
        return;
    }

    static int[] Bfs( int x, List<int>[] g )
    {
        int[] r = Repeat( -1, g.GetLength( 0 ) ).ToArray();
        var q = new Queue<int>();

        r[x] = 0;
        q.Enqueue( x );
        while( 0 < q.Count ) {
            int c = q.Dequeue();

            foreach( int i in g[c].Where( a => r[a] == -1 ) ) {
                r[i] = r[c] + 1;
                q.Enqueue( i );
            }
        }
        return r;
    }
}
