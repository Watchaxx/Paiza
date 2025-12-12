// 実行時間 240ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static List<(int, int)>[] G;

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();

        G = new List<(int, int)>[n[0]];
        foreach( int i in Range( 0, n[0] ) ) {
            G[i] = new List<(int, int)>();
        }
        foreach( int i in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();
            int ca = G[a[0]].Count;
            int cb = G[a[1]].Count;

            G[a[0]].Add( (a[1], cb) );
            G[a[1]].Add( (a[0], ca) );
        }
        WriteLine( string.Join( System.Environment.NewLine, ConstructEulerianPath() ) );
        return;
    }

    static List<int> ConstructEulerianPath()
    {
        int n = G.Length;
        int s = 0;
        int[] d = new int[G.Length];
        var p = new List<int>();

        foreach( int i in Range( 0, n ) ) {
            d[i] = G[i].Count;
        }
        foreach( int i in Range( 0, n ).Where( x => ( d[x] & 1 ) != 0 ) ) {
            s = i;
            break;
        }
        Dfs( s, p );
        p.Reverse();
        return p;
    }

    static void Dfs( int v, List<int> p )
    {
        while( 0 < G[v].Count ) {
            var t = G[v].Last();

            G[v].RemoveAt( G[v].Count - 1 );
            if( t.Item1 == -1 ) {
                continue;
            }
            G[t.Item1][t.Item2] = (-1, G[t.Item1][t.Item2].Item2);
            Dfs( t.Item1, p );
        }
        p.Add( v + 1 );
        return;
    }
}
