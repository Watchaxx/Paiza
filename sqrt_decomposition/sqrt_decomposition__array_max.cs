// 実行時間 50ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = int.MinValue;

        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            o = System.Math.Max( o, int.Parse( ReadLine() ) );
        }
        WriteLine( o );
        return;
    }
}
