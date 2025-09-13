// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] a = System.Array.ConvertAll( ReadLine().Split(), int.Parse );
        WriteLine( Gcd( a[0], a[1] ) );
        return;
    }

    /// <summary>
    /// ユークリッドの互除法
    /// https://algo-method.com/descriptions/124
    /// </summary>
    /// <returns>最大公約数</returns>
    static int Gcd( int a, int b )
    {
        return b == 0 ? a : Gcd( b, a % b );
    }
}
