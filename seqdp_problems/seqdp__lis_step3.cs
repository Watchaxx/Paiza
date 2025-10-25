// 実行時間 60ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = Repeat( int.MaxValue, n + 1 ).ToArray();

        d[0] = 0;
        foreach( int i in Range( 0, n ) ) {
            int j = BisectLeft( d, a[i] );
            d[j] = System.Math.Min( d[j], a[i] );
        }
        WriteLine( BisectLeft( d, int.MaxValue ) - 1 );
        return;
    }

    static int BisectLeft( int[] a, int t )
    {
        int l = 0;
        int r = a.Length;

        while( l < r ) {
            int m = ( l + r ) / 2;

            if( a[m] < t ) {
                l = m + 1;
            } else {
                r = m;
            }
        }
        return l;
    }
}
