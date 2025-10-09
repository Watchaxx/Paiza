// 実行時間 20ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] a = System.Array.ConvertAll( ReadLine().Split(), int.Parse );
        WriteLine( a[2] % Gcd( a[0], a[1] ) == 0 ? "Yes" : "No" );
        return;
    }

    static int Gcd( int a, int b )
    {
        return b == 0 ? a : Gcd( b, a % b );
    }
}
