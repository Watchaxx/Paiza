// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] a = System.Array.ConvertAll( ReadLine().Split(), int.Parse );
        WriteLine( a[0] / Gcd( a[0], a[1] ) * a[1] );
        return;
    }

    static int Gcd( int a, int b )
    {
        return b == 0 ? a : Gcd( b, a % b );
    }
}
