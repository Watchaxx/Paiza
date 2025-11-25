// 実行時間 10ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 1;

        foreach( int i in Range( 1, n ) ) {
            o *= i;
        }
        WriteLine( o );
        return;
    }
}
