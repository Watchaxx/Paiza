// 実行時間 10ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        ReadLine();
        WriteLine( ReadLine().Contains( 'W' ) ? "Yes" : "No" );
        return;
    }
}
