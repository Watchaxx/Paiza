// 実行時間 210ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 0;
        var g = new Lst[n];

        foreach( int i in Range( 0, n ) ) {
            g[i] = new Lst();
        }
        foreach( int i in Range( 0, n - 1 ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        foreach( int i in Range( 0, n ) ) {
            bool[] b = new bool[n];

            o = System.Math.Max( o, Dfs( i, i, b, g ) );
        }
        WriteLine( o );
        return;
    }

    static int Dfs( int c, int s, bool[] b, Lst[] g )
    {
        Lst l = new Lst();

        b[c] = true;
        foreach( int i in g[c].Where( x => b[x] != true ) ) {
            l.Add( Dfs( i, s, b, g ) + 1 );
        }
        return c == s
            ? l.Count <  3 ? 0 : l.OrderByDescending( x => x ).Take( 3 ).Sum()
            : l.Count == 0 ? 0 : l.OrderByDescending( x => x ).First();
    }
}
