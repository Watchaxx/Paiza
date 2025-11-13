// 実行時間 50ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        const int mod = 1000000007;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[n[0]];
        int[][] d = new int[n[0] + 1][];

        foreach( int i in Range( 0, n[0] ) ) {
            a[i] = int.Parse( ReadLine() );
            d[i] = new int[n[1] + 1];
        }
        d[n[0]] = new int[n[1] + 1];
        d[0][0] = 1;
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, n[1] + 1 ) ) {
                d[i + 1][j] = ( d[i + 1][j] + d[i][j] ) % mod;
                if( j + a[i] <= n[1] ) {
                    d[i + 1][j + a[i]] = ( d[i + 1][j + a[i]] + d[i][j] ) % mod;
                }
            }
        }
        WriteLine( d[n[0]][n[1]] );
        return;
    }
}
