// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static int dfs = 0;
    static int y = 0;

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int bfs = 0;
        bool[] bb = new bool[n[0]];
        bool[] bd = new bool[n[0]];
        var g = new List<int>[n[0]];
        var q = new Queue<int>();

        y = n[2] - 1;
        bb[n[1] - 1] = true;
        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = new List<int>();
        }
        foreach( int _ in Range( 0, n[0] - 1 ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        foreach( var l in g ) {
            l.Sort();
        }
        q.Enqueue( n[1] - 1 );
        while( 0 < q.Count ) {
            int v = q.Dequeue();

            if( v == y ) {
                break;
            } else {
                bfs++;
            }
            foreach( int i in g[v].Where( x => bb[x] != true ) ) {
                bb[i] = true;
                q.Enqueue( i );
            }
        }
        Dfs( n[1] - 1, bd, g );
        WriteLine( bfs < dfs ? "bfs" : dfs < bfs ? "dfs" : "same" );
        return;
    }

    static void Dfs( int v, bool[] s, List<int>[] g )
    {
        s[v] = true;
        if( s[y] != true ) {
            dfs++;
        }
        foreach( int i in g[v].Where( x => s[x] != true ) ) {
            Dfs( i, s, g );
        }
        return;
    }
}
