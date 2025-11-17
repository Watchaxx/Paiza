// 実行時間 520ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    const int bit = 32;

    static void Main()
    {
        const long mod = 998244353L;
        long o = 0L;
        long[] c = new long[bit + 1];
        long[] d = new long[bit + 1];

        c[0] = 1L;
        d[0] = 1L;
        foreach( int i in Range( 1, int.Parse( ReadLine() ) ) ) {
            c[PopCnt( i )]++;
        }
        foreach( int i in Range( 1, bit ) ) {
            long p = 0L;

            foreach( int j in Range( 0, i ) ) {
                p += d[j];
                p %= mod;
            }
            d[i] += c[i] * p % mod;
            d[i] %= mod;
        }
        foreach( int i in Range( 1, bit - 1 ) ) {
            o += d[i];
            o %= mod;
        }
        WriteLine( o );
        return;
    }

    static int PopCnt( int n )
    {
        return Range( 0, bit ).Where( x => 0 < ( ( n >> x ) & 1 ) ).Count();
    }
}
