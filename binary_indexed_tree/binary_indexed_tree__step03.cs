// 実行時間 150ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        long[] bit = new long[n + 1];

        foreach( int i in Range( 1, n ) ) {
            int k = Div2( i );

            for( long j = i - Pow( 2, k ); j < i; j++ ) {
                bit[i] += a[j];
            }
        }
        WriteLine( string.Join( " ", bit ) );
        return;
    }

    static int Div2( int i )
    {
        int k = 0;

        while( i % 2 == 0 ) {
            k++;
            i /= 2;
        }
        return k;
    }

    static long Pow( long x, int y )
    {
        long b = x;
        long r = 1L;

        while( 0 < y ) {
            if( ( y & 1 ) == 1 ) {
                r *= b;
            }
            b *= b;
            y >>= 1;
        }
        return r;
    }
}
