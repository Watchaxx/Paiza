// 実行時間 230ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

class Program
{
    static Lst[] G;

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();

        G = new Lst[n[0]];
        foreach( int i in Range( 0, n[0] ) ) {
            G[i] = new Lst();
        }
        foreach( int i in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            G[a[0]].Add( a[1] );
        }
        WriteLine( string.Join( System.Environment.NewLine, ConstructEulerianPath() ) );
        return;
    }

    static Lst ConstructEulerianPath()
    {
        int n = G.Length;
        int s = 0;
        int[] dI = new int[n];
        int[] dO = new int[n];
        Lst p = new Lst();

        foreach( int i in Range( 0, n ) ) {
            foreach( int j in G[i] ) {
                dI[j]++;
                dO[i]++;
            }
        }
        foreach( int i in Range( 0, n ).Where( x => dI[x] + 1 == dO[x] ) ) {
            s = i;
            break;
        }
        Dfs( s, p );
        p.Reverse();
        return p;
    }

    static void Dfs( int v, Lst p )
    {
        while( 0 < G[v].Count ) {
            int t = G[v].Last();

            G[v].RemoveAt( G[v].Count - 1 );
            Dfs( t, p );
        }
        p.Add( v + 1 );
        return;
    }
}
