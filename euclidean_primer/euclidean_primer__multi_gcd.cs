// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int a = int.Parse( ReadLine() );

        for( int _ = 1; _ < n; _++ ) {
            int b = int.Parse( ReadLine() );

            a = Gcd( a, b );
        }
        WriteLine( a );
        return;
    }

    static int Gcd( int a, int b )
    {
        return b == 0 ? a : Gcd( b, a % b );
    }
}
