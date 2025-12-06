// 実行時間 390ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static int[] Tree;

    static void Main()
    {
        int[] k = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int n = 1 << k[0];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        Tree = new int[2 * n - 1];
        foreach( int i in Range( 0, n ) ) {
            Tree[i + n - 1] = a[i];
        }
        Dfs( 0, n );
        foreach( int _ in Range( 0, k[1] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            WriteLine( RngMax( 0, ( t[0] - 1 ) + ( n - 1 ), ( t[1] - 1 ) + ( n - 1 ), n ) );
        }
        Out.Flush();
        return;
    }

    static int Dfs( int c, int n )
    {
        return n < c + 2 ? Tree[c] : Tree[c] = new[] { Dfs( 2 * c + 1, n ), Dfs( 2 * c + 2, n ) }.Max();
    }

    static int RngMax( int c, int l, int r, int n )
    {
        int il = c;
        int ir = c;

        while( 2 * il + 1 < Tree.Length ) {
            il = 2 * il + 1;
        }
        while( 2 * ir + 2 < Tree.Length ) {
            ir = 2 * ir + 2;
        }
        if( ir < l || r < il ) {
            return 0;
        } else if( l <= il && ir <= r ) {
            return Tree[c];
        } else {
            int m = 0;

            m = new[] { m, RngMax( 2 * c + 1, l, r, n ) }.Max();
            m = new[] { m, RngMax( 2 * c + 2, l, r, n ) }.Max();
            return m;
        }
    }
}
