// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        ulong[] a = System.Array.ConvertAll( ReadLine().Split(), ulong.Parse );
        WriteLine( a[0] * a[1] / Gcd( a[0], a[1] ) );
        return;
    }

    static ulong Gcd( ulong a, ulong b )
    {
        return b == 0 ? a : Gcd( b, a % b );
    }
}
