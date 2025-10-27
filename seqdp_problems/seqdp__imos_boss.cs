// 実行時間 400ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        const long mod = 10000000000;
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        long[] d = new long[n + 2];

        d[0] = 1;
        d[1] = -1;
        foreach( int i in Range( 0, n + 1 ) ) {
            if( 0 < i ) {
                d[i] = ( d[i] + d[i - 1] ) % mod;
            }
            if( d[i] < 0 ) {
                d[i] += mod;
            }
            if( n <= i ) {
                continue;
            }

            int r = System.Math.Min( i + a[i] + 1, n + 1 );

            d[i + 1] = ( d[i] + d[i + 1] ) % mod;
            d[r] = ( d[r] - d[i] ) % mod;
        }
        WriteLine( d[n] );
        return;
    }
}
