// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int o = 0;

        foreach( int _ in Range( 0, n - 1 ).Where( x => a[x] == a[x + 1] ) ) {
            o++;
        }
        WriteLine( o );
        return;
    }
}
