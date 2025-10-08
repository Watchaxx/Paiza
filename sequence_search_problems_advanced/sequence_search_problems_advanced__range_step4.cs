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

        foreach( int i in Range( 0, n - 2 ) ) {
            if( a[i] < a[i + 1] && a[i + 1] > a[i + 2] ) {
                o++;
            } else if( a[i] > a[i + 1] && a[i + 1] < a[i + 2] ) {
                o++;
            }
        }
        WriteLine( o );
        return;
    }
}
