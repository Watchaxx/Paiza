// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int k = int.Parse( ReadLine() );
        int[] d = new int[33];

        foreach( int i in Range( 1, 3 ) ) {
            d[i] = 1;
        }
        foreach( int i in Range( 4, System.Math.Max( k - 3, 0 ) ) ) {
            d[i] = d[i - 1] + d[i - 2] + d[i - 3];
        }
        WriteLine( d[k] );
        return;
    }
}
