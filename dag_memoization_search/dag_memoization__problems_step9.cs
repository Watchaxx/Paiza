// 実行時間 40ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    const long mod = 1000000007L;

    static void Main()
    {
        int n = int.Parse( ReadLine() );

        foreach( int _ in Range( 0, n - 1 ) ) {
            ReadLine();
        }
        WriteLine( 3 * Pow( 2L, n - 1 ) % mod );
        return;
    }

    static long Pow( long x, int n )
    {
        long r = 1L;

        while( 0 < n ) {
            if( ( n & 1 ) != 0 ) {
                r = r * x % mod;
            }
            x = x * x % mod;
            n >>= 1;
        }
        return r;
    }
}
