// 実行時間 20ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        const long mod = 10000000L;
        int[] x = System.Array.ConvertAll( ReadLine().Split(), int.Parse );
        long b = x[0] % mod;
        long r = 1L;

        while( 0 < x[1] ) {
            if( ( x[1] & 1 ) == 1 ) {
                r = r * b % mod;
            }
            b = b * b % mod;
            x[1] >>= 1;
        }
        WriteLine( r );
        return;
    }
}
