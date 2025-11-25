// 実行時間 10ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = 0;
        int y = 0;

        foreach( int _ in Range( 0, 5 ) ) {
            if( string.Compare( ReadLine(), "yes", System.StringComparison.Ordinal ) == 0 ) {
                y++;
            } else {
                n++;
            }
        }
        WriteLine( n < y ? "yes" : "no" );
        return;
    }
}
