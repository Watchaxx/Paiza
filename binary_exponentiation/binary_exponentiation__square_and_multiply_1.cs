// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        foreach( int i in Range( 0, int.Parse( ReadLine() ) ) ) {
            WriteLine( 1 << i );
        }
        return;
    }
}
