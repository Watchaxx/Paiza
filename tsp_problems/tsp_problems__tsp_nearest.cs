// 実行時間 680ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int c = 0;
        int n = int.Parse( ReadLine() );
        int[][] a = new int[n][];
        bool[] b = new bool[n];

        foreach( int i in Range( 0, n ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int _ in Range( 0, n ) ) {
            double md = double.MaxValue;
            int mi = 0;

            b[c] = true;
            WriteLine( c );
            foreach( int i in Range( 1, n - 1 ).Where( x => b[x] != true ) ) {
                double t = Euclidean( a[c], a[i] );

                if( t < md ) {
                    md = t;
                    mi = i;
                }
            }
            c = mi;
        }
        return;
    }

    static double Euclidean( int[] x, int[] y )
    {
        double a = x[0] - y[0];
        double b = x[1] - y[1];
        return System.Math.Sqrt( a * a + b * b );
    }
}
