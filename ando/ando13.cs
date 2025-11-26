// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        long l = n;

        foreach( int i in Range( 2, n - 2 ) ) {
            l *= i;
            while( l % 10 == 0 ) {
                l /= 10;
            }
            l %= 10000000000;
        }
        WriteLine( l % 1000000000L );
        return;
    }
}
