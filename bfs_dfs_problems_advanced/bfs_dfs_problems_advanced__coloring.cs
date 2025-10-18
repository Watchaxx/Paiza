// 実行時間 370ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        bool[] b = new bool[n];
        Lst[] g = new Lst[n];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        b[0] = true;
        foreach( int i in Range( 0, n ) ) {
            g[i] = new Lst();
        }
        foreach( int i in Range( 0, n - 1 ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        Dfs( 0, b, g );
        WriteLine( 2 );
        foreach( bool v in b ) {
            WriteLine( v ? 1 : 2 );
        }
        Out.Flush();
        return;
    }

    static void Dfs( int c, bool[] b, Lst[] g )
    {
        foreach( int i in g[c].Where( x => b[x] != true ) ) {
            b[i] = !b[c];
            Dfs( i, b, g );
        }
        return;
    }
}
