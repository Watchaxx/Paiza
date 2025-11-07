// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int x = int.Parse( ReadLine() );
        WriteLine( Range( 0, 32 ).Count( z => ( ( x >> z ) & 1 ) == 1 ) );
        return;
    }
}
