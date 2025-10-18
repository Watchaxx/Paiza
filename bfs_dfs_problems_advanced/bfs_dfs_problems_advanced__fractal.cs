// 実行時間 350ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var g  = new List<int>[n[0]];
        var gr = new List<int>[n[0]];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n[0] ) ) {
            g[i]  = new List<int>();
            gr[i] = new List<int>();
        }
        foreach( int i in Range( 0, n[0] - 1 ) ) {
            int[] p = ReadLine().Split().Select( int.Parse ).ToArray();

            p[0]--;
            if( p[1] == 1 ) {
                g[p[0]].Add( 0 );
                gr[0].Add( p[0] );
            } else {
                g[p[0]].Add( i + 1 );
                gr[i + 1].Add( p[0] );
            }
        }

        int[] d  = Bfs( 0, g );
        int[] dr = Bfs( 0, gr );

        foreach( int i in Range( 0, n[1] ) ) {
            int[] x = ReadLine().Split().Select( a => int.Parse( a ) - 1 ).ToArray();

            if( d[x[1]] == -1 || dr[x[0]] == -1 ) {
                WriteLine( -1 );
            } else {
                WriteLine( d[x[1]] + dr[x[0]] );
            }
        }
        Out.Flush();
        return;
    }

    static int[] Bfs( int x, List<int>[] g )
    {
        int[] r = Repeat( -1, g.Length ).ToArray();
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
