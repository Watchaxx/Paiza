// 実行時間 1840ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        string[] t = ReadLine().Split();
        int n = int.Parse( t[0] );
        int[] a = new int[n];
        long k = long.Parse( t[1] );
        long l = 0L;
        long r = 1L << 50;

        foreach( int i in Range( 0, n ) ) {
            a[i] = int.Parse( ReadLine() );
        }
        while( 1 < r - l ) {
            long m = ( l + r ) / 2L;
            long s = 0L;

            foreach( int i in Range( 0, n ) ) {
                s += (long)System.Math.Ceiling( m / (decimal)a[i] );
            }
            if( s <= k ) {
                l = m;
            } else {
                r = m;
            }
        }
        WriteLine( l );
        return;
    }
}
