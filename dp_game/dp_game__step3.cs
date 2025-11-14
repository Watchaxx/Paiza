// 実行時間 590ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        long[] s = new long[n + 1];

        foreach( int i in Range( 0, n ) ) {
            s[i + 1] = a[i] + s[i];
        }
        foreach( int i in Range( 0, n - 1 ) ) {
            long r = s[n] - s[i];
            long b = BisectLeft( s, s[i] + ( r + 1 ) / 2 );

            WriteLine( b == n + 1 ? Abs( r - a[n - 1] - a[n - 1] )
                : b == i + 1 ? Abs( a[i] - ( r - a[i] ) )
                : Min( Abs( s[b] - s[i] - ( r - ( s[b] - s[i] ) ) ),
                    Abs( s[b - 1] - s[i] - ( r - ( s[b - 1] - s[i] ) ) ) ) );
        }
        return;
    }

    static long BisectLeft( long[] a, long t )
    {
        long l = 0;
        long r = a.Length;

        while( l < r ) {
            long m = ( l + r ) / 2L;

            if( a[m] < t ) {
                l = m + 1;
            } else {
                r = m;
            }
        }
        return l;
    }
}
