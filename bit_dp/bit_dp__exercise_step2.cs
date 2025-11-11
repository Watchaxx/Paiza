// 実行時間 850ms
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
            foreach( int j in Range( 0, n ).Where( x => Is0( i, x ) ) ) {
                foreach( int k in Range( j + 1, n - j - 1 ).Where( x => Is0( i, x ) ) ) {
                    int t = i | ( 1 << j ) | ( 1 << k );

                    d[t] = System.Math.Max( d[t], d[i] + a[j][k] );
                }
            }
        }
        WriteLine( d[m - 1] );
        return;
    }

    static bool Is0( int a, int b )
    {
        return ( ( a >> b ) & 1 ) == 0;
    }
}
