// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] x = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int i in Range( 0, x[1] ) ) {
            WriteLine( Pow( x[0], (int)Pow( 2L, i ) ) );
        }
        return;
    }

    static long Pow( long x, int y )
    {
        const long mod = 10000000L;
        long b = x % mod;
        long r = 1L;

        while( 0 < y ) {
            if( ( y & 1 ) == 1 ) {
                r = r * b % mod;
            }
            b = b * b % mod;
            y >>= 1;
        }
        return r;
    }
}
