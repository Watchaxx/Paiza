// 実行時間 530ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int m = 1 << n;
        int[][] a = new int[n][];
        long[][] d = new long[n + 1][];

        foreach( int i in Range( 0, n ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
            d[i] = Repeat( long.MinValue / 2, m ).ToArray();
        }
        d[n] = Repeat( long.MinValue / 2, m ).ToArray();
        d[0][0] = 0L;
        foreach( int i in Range( 1, n ) ) {
            foreach( int j in Range( 0, m ) ) {
                foreach( int k in Range( 0, n ).Where( x => ( ( j >> x ) & 1 ) == 0 ) ) {
                    int t = j | ( 1 << k );

                    d[i][t] = System.Math.Max( d[i][t], d[i - 1][j] + a[i - 1][k] );
                }
            }
        }
        WriteLine( d[n][m - 1] );
        return;
    }
}
