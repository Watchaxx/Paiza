// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        bool[] s = new bool[n[0]];
        var g = new Lst[n[0]];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = new Lst();
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        foreach( var l in g ) {
            l.Sort();
        }
        Dfs( n[2] - 1, s, g );
        Out.Flush();
        return;
    }

    static void Dfs( int v, bool[] s, Lst[] g )
    {
        s[v] = true;
        WriteLine( v + 1 );
        foreach( int w in g[v].Where( x => s[x] != true ) ) {
            Dfs( w, s, g );
        }
        return;
    }
}
