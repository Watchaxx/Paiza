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
        string[] fi = System.IO.File.ReadAllLines( @"R:\test-case_mondai__1.txt" );
        int[] n = fi[0].Split().Select( int.Parse ).ToArray();

        v = new bool[n[0]];
        g = new Lst[n[0]];
        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = new Lst();
        }
        foreach( int _ in Range( 1, n[1] ) ) {
            int[] a = fi[_].Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        Dfs( 0 );
        WriteLine( v.All( x => x ) ? "Yes" : "No" );
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
