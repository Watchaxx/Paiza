// 実行時間 310ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        long[] s = new long[n];
        string[] a = new string[n];
        Lst[] g = new Lst[n];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n ) ) {
            string[] nsnc = ReadLine().Split();

            a[i] = nsnc[0];
            s[i] = long.Parse( nsnc[1] );
            g[i] = new Lst();
            g[i].AddRange( nsnc.Skip( 3 ).Select( x => int.Parse( x ) - 1 ) );
        }
        Dfs( 0, s, g );
        foreach( int i in Range( 0, n ) ) {
            WriteLine( $"{a[i]} {s[i]}" );
        }
        Out.Flush();
        return;
    }

    static void Dfs( int c, long[] s, Lst[] g )
    {
        foreach( int i in g[c] ) {
            Dfs( i, s, g );
            s[c] += s[i];
        }
        return;
    }
}
