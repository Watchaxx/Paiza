// 実行時間 380ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<(int, int)>;

class Program
{
    static long[] Memo = new long[100001];

    static void Main()
    {
        int n = int.Parse( ReadLine() );
        var g = new Lst[n];

        foreach( int i in Range( 0, n ) ) {
            g[i] = new Lst();
        }
        foreach( int _ in Range( 0, n - 1 ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[t[0]].Add( (t[1], t[2] + 1) );
            g[t[1]].Add( (t[0], t[2] + 1) );
        }
        Dfs( 0, -1, g );
        WriteLine( string.Join( System.Environment.NewLine, Memo.Take( n ) ) );
        return;
    }

    static void Dfs( int n, int p, Lst[] g )
    {
        foreach( var i in g[n].Where( x => x.Item1 != p ) ) {
            Memo[i.Item1] = Memo[n] + i.Item2;
            Dfs( i.Item1, n, g );
        }
        return;
    }
}
