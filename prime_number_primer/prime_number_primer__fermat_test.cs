// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );

        if( n % 2 == 0 ) {
            WriteLine( "NO" );
            return;
        }
        WriteLine( System.Math.Pow( 2d, n - 1 ) % n == 1 ? "YES" : "NO" );
        return;
    }
}
