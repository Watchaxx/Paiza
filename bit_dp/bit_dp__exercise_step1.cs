// 実行時間 220ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        const int mod = 1000000000;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int m = 1 << n[0];
        long[][] d = new long[n[1] + 1][];

        foreach( int i in Range( 0, n[1] + 1 ) ) {
            d[i] = new long[m];
        }
        d[0][0] = 1L;
        foreach( int i in Range( 1, n[1] ) ) {
            int t = 0;
            int[] a = ReadLine().Split().Skip( 1 ).Select( x => int.Parse( x ) - 1 ).ToArray();

            foreach( int j in a ) {
                t |= 1 << j;
            }
            foreach( int j in Range( 0, m ) ) {
                d[i][j] += d[i - 1][j];
                d[i][j | t] += d[i - 1][j];
                d[i][j] %= mod;
                d[i][j | t] %= mod;
            }
        }
        WriteLine( d[n[1]][m - 1] );
        return;
    }
}
