// 実行時間 250ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int p = 0;
        int q = ( 1 << n ) - 1;
        int[] r = new int[n];
        int[][] a = new int[n][];
        int[][] b = new int[n][];
        double[][] d = new double[n][];

        foreach( int i in Range( 0, n ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
            b[i] = new int[1 << n];
            d[i] = Repeat( double.MaxValue, 1 << n ).ToArray();
        }
        foreach( int i in Range( 0, n ) ) {
            b[i][1 << i] = 0;
            d[i][1 << i] = Euclidean( a[0], a[i] );
        }
        foreach( int i in Range( 0, 1 << n ) ) {
            foreach( int j in Range( 0, n ) ) {
                if( ( i >> j & 1 ) == 0 ) {
                    continue;
                }
                foreach( int k in Range( 0, n ) ) {
                    if( ( i >> k & 1 ) == 1 ) {
                        continue;
                    }

                    double t = d[j][i] + Euclidean( a[j], a[k] );

                    if( t < d[k][i | ( 1 << k )] ) {
                        b[k][i | ( 1 << k )] = j;
                        d[k][i | ( 1 << k )] = t;
                    }
                }
            }
        }
        foreach( int i in Range( 0, n ) ) {
            r[i] = b[p][q];
            q ^= 1 << p;
            p = r[i];
        }
        WriteLine( d[0][( 1 << n ) - 1] );
        WriteLine( string.Join( " ", r ) );
        return;
    }

    static double Euclidean( int[] x, int[] y )
    {
        double a = x[0] - y[0];
        double b = x[1] - y[1];
        return System.Math.Sqrt( a * a + b * b );
    }
}
