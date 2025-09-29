// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] c = Repeat( -1, n[0] ).ToArray();
        Lst[] g = new Lst[n[0]];

        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = new Lst();
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        foreach( int i in Range( 0, n[0] ).Where( x => c[x] < 0 ) ) {
            Dfs( i, o, c, g );
            o++;
        }
        WriteLine( o );
        return;
    }

    static void Dfs( int v, int l, int[] c, Lst[] g )
    {
        c[v] = l;
        foreach( int i in g[v].Where( x => c[x] < 0 ) ) {
            Dfs( i, l, c, g );
        }
        return;
    }
}
