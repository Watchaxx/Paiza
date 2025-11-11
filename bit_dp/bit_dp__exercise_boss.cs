// 実行時間 440ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static void Main()
    {
        const int m = 8;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] p = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] a = new int[n[0]][];
        long[][][] d = new long[n[0] + 1][][];

        foreach( int i in Range( 0, n[0] ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
            d[i] = new long[n[1] + 1][];
            foreach( int j in Range( 0, n[1] + 1 ) ) {
                d[i][j] = Repeat( long.MinValue, m ).ToArray();
            }
        }
        d[n[0]] = new long[n[1] + 1][];
        foreach( int i in Range( 0, n[1] + 1 ) ) {
            d[n[0]][i] = Repeat( long.MinValue, m ).ToArray();
        }
        d[0][0][0] = 0L;
        foreach( int i in Range( 1, n[0] ) ) {
            int t = 0;

            foreach( int j in Range( 0, 3 ).Where( x => p[x] <= a[i - 1][x] ) ) {
                t |= 1 << j;
            }
            foreach( int j in Range( 0, n[1] + 1 ) ) {
                foreach( int k in Range( 0, m ) ) {
                    d[i][j][k] = Max( d[i][j][k], d[i - 1][j][k] );
                    if( 0 < j ) {
                        d[i][j][k | t] = Max( d[i][j][k | t], d[i - 1][j - 1][k] + Sum( a[i - 1] ) );
                    }
                }
            }
        }
        WriteLine( 0 <= d[n[0]][n[1]][m - 1] ? d[n[0]][n[1]][m - 1] : -1 );
        return;
    }

    static long Sum( int[] a )
    {
        long r = 0L;

        foreach( long l in a ) {
            r += l;
        }
        return r;
    }
}
