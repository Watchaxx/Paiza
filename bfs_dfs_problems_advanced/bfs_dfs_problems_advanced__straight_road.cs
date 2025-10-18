// 実行時間 240ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

internal class Program
{
    static void Main()
    {
        int o = 1;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] v = Repeat( -1, n[0] ).ToArray();
        var g = new Lst[n[0]];

        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = new Lst();
        }
        foreach( int i in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        foreach( Lst l in g.Where( x => x.Count != 2 ) ) {
            l.Clear();
        }
        foreach( int i in Range( 0, n[0] ).Where( x => v[x] == -1 && g[x].Count == 2 ) ) {
            o = System.Math.Max( o, Dfs( i, i, -1, v, g ) - 1 );
        }
        WriteLine( o );
        return;
    }

    static int Dfs( int c, int i, int p, int[] v, Lst[] g )
    {
        if( v[c] == i ) {
            return c == i ? 0 : 1;
        }

        int r = 1;

        v[c] = i;
        foreach( int n in g[c].Where( x => x != p ) ) {
            r += Dfs( n, i, c, v, g );
        }
        return r;
    }
}
