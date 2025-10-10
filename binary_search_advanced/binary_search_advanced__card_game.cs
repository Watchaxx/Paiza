// 実行時間 1360ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = new int[n];
        int[] b = new int[n];
        int[] c = new int[n];
        long l = -( 1 << 24 );
        long r = 1 << 24;

        foreach( int i in Range( 0, n ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            a[i] = t[0];
            b[i] = t[1];
            c[i] = t[2];
        }
        System.Array.Sort( c );
        while( 1 < r - l ) {
            int p = 0;
            long m = ( l + r ) / 2;
            long[] d = new long[n];

            foreach( int i in Range( 0, n ) ) {
                d[i] = a[i] * m + b[i];
            }
            System.Array.Sort( d );
            foreach( long _ in d.Where( x => c[p] < x ) ) {
                p++;
            }
            if( n / 2 < p ) {
                r = m;
            } else {
                l = m;
            }
        }
        WriteLine( r );
        return;
    }
}
