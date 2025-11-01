// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 0;

        foreach( int i in Range( 0, n ) ) {
            o += ReadLine().Split().Select( int.Parse ).Sum();
        }
        WriteLine( o / 2 );
        return;
    }
}
