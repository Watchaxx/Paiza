// 実行時間 110ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        const long mod = 10000000000;
        int[] l = ReadLine().Split().Select( int.Parse ).ToArray();
        int m = System.Math.Max( l[1], l[2] ) + 1;
        long o = 0L;
        long[][] d = new long[2][];

        foreach( int i in Range( 0, 2 ) ) {
            d[i] = new long[m];
        }
        d[0][1] = 1L;
        d[1][1] = 1L;
        foreach( int i in Range( 1, l[0] - 1 ) ) {
            long[][] e = new long[2][];

            foreach( int j in Range( 0, 2 ) ) {
                e[j] = new long[m];
            }
            foreach( int j in Range( 1, l[1] ) ) {
                if( j + 1 <= l[1] ) {
                    e[0][j + 1] = ( d[0][j] + e[0][j + 1] ) % mod;
                }
                e[1][1] = ( d[0][j] + e[1][1] ) % mod;
            }
            foreach( int j in Range( 1, l[2] ) ) {
                if( j + 1 <= l[2] ) {
                    e[1][j + 1] = ( d[1][j] + e[1][j + 1] ) % mod;
                }
                e[0][1] = ( d[1][j] + e[0][1] ) % mod;
            }
            foreach( int j in Range( 0, 2 ) ) {
                e[j].CopyTo( d[j], 0 );
            }
        }
        foreach( long[] i in d ) {
            foreach( long j in i ) {
                o = ( o + j ) % mod;
            }
        }
        WriteLine( o );
        return;
    }
}
