// 実行時間 120ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        const long mod = 10000000000;
        int l = int.Parse( ReadLine() );
        long[][] d = new long[l + 1][];

        foreach( int i in Range( 0, l + 1 ) ) {
            d[i] = new long[l + 1];
        }
        d[0][0] = 1L;
        foreach( int i in Range( 0, l ) ) {
            foreach( int j in Range( 0, l ) ) {
                if( j + 1 <= l ) {
                    d[i + 1][j + 1] = ( d[i][j] + d[i + 1][j + 1] ) % mod;
                }
                if( 0 <= j - 1 ) {
                    d[i + 1][j - 1] = ( d[i][j] + d[i + 1][j - 1] ) % mod;
                }
            }
        }
        WriteLine( d[l][0] );
        return;
    }
}
