// 実行時間 60ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        const long mod = 1000000007L;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        bool[][] b = new bool[n[1]][];
        long[][] d = new long[n[1]][];

        foreach( int i in Range( 0, n[1] ) ) {
            b[i] = new bool[n[0]];
            d[i] = new long[n[0]];
        }
        d[0][0] = 1;
        foreach( int _ in Range( 0, n[2] ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            b[t[1]][t[0]] = true;
        }
        foreach( int i in Range( 0, n[1] ) ) {
            foreach( int j in Range( 0, n[0] ).Where( x => b[i][x] != true ) ) {
                if( j + 1 < n[0] && b[i][j + 1] != true ) {
                    d[i][j + 1] = ( d[i][j + 1] + d[i][j] ) % mod;
                }
                if( i + 1 < n[1] && b[i + 1][j] != true ) {
                    d[i + 1][j] = ( d[i + 1][j] + d[i][j] ) % mod;
                }
            }
        }
        WriteLine( d[n[1] - 1][n[0] - 1] );
        return;
    }
}
