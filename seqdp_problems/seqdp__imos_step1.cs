// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        long[] d = new long[n + 1];

        d[0] = 1;
        foreach( int i in Range( 0, n ) ) {
            for( int j = 1; j <= System.Math.Min( a[i], n - i ); j++ ) {
                d[i + j] = ( d[i] + d[i + j] ) % 10000000000;
            }
        }
        WriteLine( d[n] );
        return;
    }
}
