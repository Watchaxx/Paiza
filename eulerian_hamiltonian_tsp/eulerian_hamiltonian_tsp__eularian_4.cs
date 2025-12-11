// 実行時間 210ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

class Program
{
    static bool[] v;
    static Lst[] g;

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = new int[n[0]];

        v = new bool[n[0]];
        g = new Lst[n[0]];
        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = new Lst();
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        Dfs( 0 );
        if( v.Any( x => !x ) ) {
            WriteLine( "No" );
            return;
        }
        foreach( int i in Range( 0, n[0] ) ) {
            d[i] = g[i].Count;
        }
        WriteLine( d.All( x => ( x & 1 ) != 1 ) ? "Yes" : "No" );
        return;
    }

    static void Dfs( int c )
    {
        v[c] = true;
        foreach( int i in g[c].Where( x => v[x] != true ) ) {
            Dfs( i );
        }
        return;
    }
}
