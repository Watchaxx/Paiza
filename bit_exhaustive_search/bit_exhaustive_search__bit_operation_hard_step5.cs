// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        long n = long.Parse( ReadLine() );

        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            WriteLine( n ^ Pow( 2L, int.Parse( ReadLine() ) ) );
        }
        return;
    }

    static long Pow( long x, int y )
    {
        const long mod = 10000000000;
        long b = x % mod;
        long r = 1L;

        while( 0 < y ) {
            if( ( y & 1 ) != 0 ) {
                r = r * b % mod;
            }
            b = b * b % mod;
            y >>= 1;
        }
        return r;
    }
}
