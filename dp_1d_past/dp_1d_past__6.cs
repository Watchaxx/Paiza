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
