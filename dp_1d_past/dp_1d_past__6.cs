// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int r = 0;

        while( 0 < n ) {
            if( 0 < ( n & 1 ) ) {
                r++;
            }
            n >>= 1;
        }
        WriteLine( r );
        return;
    }
}

// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        WriteLine( Range( 0, 32 ).Where( x => 0 < ( ( n >> x ) & 1 ) ).Count() );
        return;
    }
}
