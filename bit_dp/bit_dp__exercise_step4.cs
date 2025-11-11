// 実行時間 340ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int m = 1 << n;
        int[][] a = new int[n][];
        long[] d = new long[m];

        foreach( int i in Range( 0, n ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in Range( 0, m ) ) {
            int c = PopCnt( i );

            foreach( int j in Range( 0, n ).Where( x => ( ( i >> x ) & 1 ) == 0 ) ) {
                d[i | ( 1 << j )] = System.Math.Max( d[i | ( 1 << j )], d[i] + a[c][j] );
            }
        }
        WriteLine( d[m - 1] );
        return;
    }

    static int PopCnt( int i )
    {
        int r = 0;

        while( 0 < i ) {
            if( ( i & 1 ) != 0 ) {
                r++;
            }
            i >>= 1;
        }
        return r;
    }
}
