// 実行時間 330ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 1;
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = Repeat( -1, n ).ToArray();

        d[0] = 1;
        foreach( int i in Range( 1, n - 1 ) ) {
            d[i] = a[i - 1] < a[i] ? d[i - 1] + 1 : 1;
            o = System.Math.Max( o, d[i] );
        }
        WriteLine( o );
        return;
    }
}
