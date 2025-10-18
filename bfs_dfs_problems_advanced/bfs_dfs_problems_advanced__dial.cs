// 実行時間 1430ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = int.MaxValue;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var g = new List<int>[n[1] * 9];

        foreach( int i in Range( 0, n[1] * 9 ) ) {
            g[i] = new List<int>();
        }
        foreach( int i in Range( 0, n[1] ) ) {
            foreach( int j in Range( 1, 9 ) ) {
                g[Func( i, j )].Add( Func( ( i * 10 + 1 ) % n[1], 1 ) );
                if( j != 9 ) {
                    g[Func( i, j )].Add( Func( ( i + 1 ) % n[1], j + 1 ) );
                }
            }
        }

        int[] d = Bfs( Func( n[0] % n[1], 9 ), g );

        foreach( int i in Range( 1, 9 ).Where( x => d[Func( n[2], x )] != -1 ) ) {
            o = System.Math.Min( o, d[Func( n[2], i )] );
        }
        WriteLine( o != int.MaxValue ? o : -1 );
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

    static int Func( int a, int b )
    {
        return a * 9 + b - 1;
    }
}
