// 実行時間 10ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        ulong o = 1;

        foreach( int _ in Range( 0, n ) ) {
            ulong a = ulong.Parse( ReadLine() );

            o = o * a / Gcd( o, a );
        }
        WriteLine( o );
        return;
    }

    static ulong Gcd( ulong a, ulong b )
    {
        return b == 0 ? a : Gcd( b, a % b );
    }
}
