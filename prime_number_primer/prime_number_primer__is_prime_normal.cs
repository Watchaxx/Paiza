// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        WriteLine( IsPrime( ulong.Parse( ReadLine() ) ) ? "YES" : "NO" );
        return;
    }

    static bool IsPrime( ulong n )
    {
        if( n <= 2 ) {
            return n == 2;
        }
        if( n % 2 == 0 ) {
            return false;
        }
        for( ulong l = 3; l * l <= n; l += 2 ) {
            if( n % l == 0 ) {
                return false;
            }
        }
        return true;
    }
}
