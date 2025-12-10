// 実行時間 210ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

class Program
{
    static bool[] v;
    static Lst[] g2;

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var g = new Lst[n[0]];

        v = new bool[n[0]];
        g2 = new Lst[n[0]];
        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = new Lst();
            g2[i] = new Lst();
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
        }
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in g[i] ) {
                g2[i].Add( j );
                g2[j].Add( i );
            }
        }
        Dfs( 0 );
        WriteLine( v.All( x => x ) ? "Yes" : "No" );
        return;
    }

    static void Dfs( int c )
    {
        v[c] = true;
        foreach( int i in g2[c].Where( x => v[x] != true ) ) {
            Dfs( i );
        }
        return;
    }
}
