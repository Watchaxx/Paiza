//  実行時間 160ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] c = new int[n];
        Lst[] g = new Lst[n];

        foreach( int i in Range( 0, n ) ) {
            int[] r = ReadLine().Split().Select( int.Parse ).ToArray();

            c[i] = r[0];
            g[i] = new Lst();
            g[i].AddRange( r.Skip( 2 ).Select( x => x - 1 ) );
        }
        WriteLine( Dfs( 0, c, g ) );
        return;
    }

    static long Dfs( int n, int[] c, Lst[] g )
    {
        long s = 0;

        foreach( int i in g[n] ) {
            s += Dfs( i, c, g );
        }
        return g[n].Count == 0 ? c[n] : System.Math.Min( c[n], s );
    }
}
