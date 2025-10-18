// 実行時間 300ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;
using Tpl = System.Tuple<int, int>;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        bool[] v = new bool[n];
        Lst[] g = new Lst[n];

        foreach( int i in Range( 0, n ) ) {
            g[i] = new Lst();
        }
        foreach( int i in Range( 0, n - 1 ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        WriteLine( Dfs( 0, v, g ).Item2 );
        return;
    }

    static Tpl Dfs( int n, bool[] v, Lst[] g )
    {
        int c = 0;
        int s = 0;

        v[n] = true;
        foreach( int i in g[n].Where( x => v[x] != true ) ) {
            Tpl t = Dfs( i, v, g );

            c += t.Item1;
            s += t.Item2;
        }
        return 2 <= c ? new Tpl( 0, s + 2 ) : new Tpl( 1, s + c );
    }
}
