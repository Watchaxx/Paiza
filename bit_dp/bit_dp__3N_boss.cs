// 実行時間 100ms
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

            foreach( int j in Range( 0, n ).Where( x => 0 < ( ( i >> x ) & 1 ) ) ) {
                p ^= a[j];
            }
            e[i] = p * PopCnt( i );
        }
        foreach( int i in Range( 0, m ) ) {
            int t = i;

            while( 0 <= t ) {
                t &= i;
                d[i] = System.Math.Max( d[i], d[i ^ t] + e[t] );
                t--;
            }
        }
        WriteLine( d[m - 1] );
        return;
    }

    static int PopCnt( int i )
    {
        int r = 0;

        while( 0 < i ) {
            if( 0 < ( i & 1 ) ) {
                r++;
            }
            i >>= 1;
        }
        return r;
    }
}
