// 実行時間 370ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int m = 1 << n;
        long o = long.MaxValue;
        long[] x = new long[n];
        long[] y = new long[n];
        long[][] d = new long[m][];

        foreach( int i in Range( 0, m ) ) {
            d[i] = Repeat( long.MaxValue / 2, n ).ToArray();
        }
        foreach( int i in Range( 0, n ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            x[i] = t[0];
            y[i] = t[1];
            d[1 << i][i] = Abs( t[0] ) + Abs( t[1] );
        }
        foreach( int i in Range( 0, m ) ) {
            foreach( int j in Range( 0, n ).Where( z => Is0( i, z ) != true ) ) {
                foreach( int k in Range( 0, n ).Where( z => Is0( i, z ) == true ) ) {
                    int t = i | ( 1 << k );

                    d[t][k] = Min( d[t][k], d[i][j] + Abs( x[j] - x[k] ) + Abs( y[j] - y[k] ) );
                }
            }
        }
        foreach( int i in Range( 0, n ) ) {
            o = Min( o, d[m - 1][i] + Abs( x[i] ) + Abs( y[i] ) );
        }
        WriteLine( o );
        return;
    }

    static bool Is0( int a, int b )
    {
        return ( ( a >> b ) & 1 ) == 0;
    }
}
