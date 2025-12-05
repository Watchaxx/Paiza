// 実行時間 380ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

class Program
{
    static Lst[] g;

    static void Main()
    {
        int f = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = new int[n[0]];
        int[] e = new int[n[0]];

        g = new Lst[n[0]];
        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = new Lst();
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[t[0]].Add( t[1] );
            g[t[1]].Add( t[0] );
        }
        Dfs( 0, -1, e );
        foreach( int i in Range( 1, n[0] - 1 ).Where( x => e[f] < e[x] ) ) {
            f = i;
        }
        Dfs( f, -1, d );
        f = 0;
        foreach( int i in Range( 1, n[0] - 1 ).Where( x => d[f] < d[x] ) ) {
            f = i;
        }
        WriteLine( d[f] );
        return;
    }

    static void Dfs( int n, int p, int[] a )
    {
        foreach( int i in g[n].Where( x => x != p ) ) {
            a[i] = a[n] + 1;
            Dfs( i, n, a );
        }
        return;
    }
}
