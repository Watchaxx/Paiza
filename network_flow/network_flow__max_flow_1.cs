// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static int[,] g;

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        bool[] b = new bool[n[0]];

        g = new int[n[0], n[0]];
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0], a[1]] = a[2] + 1;
        }
        Dfs( b, n[0], n[2] - 1 );
        WriteLine( b[n[3] - 1] ? "Yes" : "No" );
        return;
    }

    static void Dfs( bool[] b, int n, int s )
    {
        b[s] = true;
        foreach( int i in Range( 0, n ).Where( x => b[x] != true && 0 < g[s, x] ) ) {
            Dfs( b, n, i );
        }
    }
}
