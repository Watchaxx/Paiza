// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        const long mod = 10000000000;
        int n = int.Parse( ReadLine() );
        long[] a = new long[n + 1];

        if( n == 1 ) {
            WriteLine( 1 );
            return;
        }
        a[1] = 1;
        a[2] = 2;
        foreach( int i in Range( 3, n - 2 ) ) {
            a[i] = ( a[i - 1] % mod + a[i - 2] % mod ) % mod;
        }
        WriteLine( a[n] );
        return;
    }
}
