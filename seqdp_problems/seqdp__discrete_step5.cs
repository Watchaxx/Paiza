// 実行時間 640ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] b = ReadLine().Split().Select( int.Parse ).ToArray();
        long[] d = Repeat( -1L, n + 1 ).ToArray();

        d[0] = 0L;
        foreach( int i in Range( 0, n ).Where( x => d[x] != -1 ) ) {
            int j = Min( n, i + a[i] );

            d[j] = Max( d[j], d[i] + a[i] );
            j = Min( n, i + b[i] );
            d[j] = Max( d[j], d[i] + b[i] );
        }
        WriteLine( d[n] );
        return;
    }
}
