// 実行時間 270ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[][] a = new int[n][];
        double[][] d = new double[n][];

        foreach( int i in Range( 0, n ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
            d[i] = Repeat( double.MaxValue, 1 << n ).ToArray();
        }
        foreach( int i in Range( 0, n ) ) {
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

                    d[k][i | ( 1 << k )] = System.Math.Min( d[k][i | ( 1 << k )], t );
                }
            }
        }
        WriteLine( d[0][( 1 << n ) - 1] );
        return;
    }

    static double Euclidean( int[] x, int[] y )
    {
        double a = x[0] - y[0];
        double b = x[1] - y[1];
        return System.Math.Sqrt( a * a + b * b );
    }
}
