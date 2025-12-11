// 実行時間 220ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

class Program
{
    static bool[] V;
    static Lst[] G;

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = new int[n[0]];
        int[] dI = new int[n[0]];
        int[] dO = new int[n[0]];
        Lst[] g = new Lst[n[0]];

        V = new bool[n[0]];
        G = new Lst[n[0]];
        foreach( int i in Range( 0, n[0] ) ) {
            G[i] = new Lst();
            g[i] = new Lst();
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            G[a[0]].Add( a[1] );
        }
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in G[i] ) {
                g[i].Add( j );
                g[j].Add( i );
            }
        }
        Dfs( 0, g );
        if( V.Any( x => !x ) ) {
            WriteLine( "No" );
            return;
        }
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in G[i] ) {
                dI[j]++;
                dO[i]++;
            }
        }
        WriteLine( Range( 0, n[0] ).All( x => dI[x] == dO[x] ) ? "Yes" : "No" );
        return;
    }

    static void Dfs( int c, Lst[] g )
    {
        V[c] = true;
        foreach( int i in g[c].Where( x => V[x] != true ) ) {
            Dfs( i, g );
        }
        return;
    }
}
