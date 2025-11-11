// 実行時間 180ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int m = 1 << n;
        long[] a = ReadLine().Split().Select( long.Parse ).ToArray();
        long[] d = new long[m];
        long[] e = new long[m];

        foreach( int i in Range( 0, m ) ) {
            long p = 0L;

            foreach( int j in Range( 0, n ).Where( x => ( ( i >> x ) & 1 ) != 0 ) ) {
                p ^= a[j];
            }
            e[i] = p * PopCnt( i );
        }
        foreach( int i in Range( 0, m ) ) {
            foreach( int j in Range( 0, m ).Where( x => ( i & x ) == x ) ) {
                d[i] = System.Math.Max( d[i], d[i ^ j] + e[j] );
            }
        }
        WriteLine( d[m - 1] );
        return;
    }

    static int PopCnt( int i )
    {
        int r = 0;

        while( 0 < i ) {
            if( ( i & 1 ) != 0 ) {
                r++;
            }
            i >>= 1;
        }
        return r;
    }
}
