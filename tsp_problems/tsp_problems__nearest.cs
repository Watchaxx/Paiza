// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        double md = double.MaxValue;
        int mi = 0;
        int n = int.Parse( ReadLine() );
        int[] p = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int i in Range( 1, n - 1 ) ) {
            double t = Euclidean( p, ReadLine().Split().Select( int.Parse ).ToArray() );

            if( t < md ) {
                md = t;
                mi = i;
            }
        }
        WriteLine( mi );
        return;
    }

    static double Euclidean( int[] x, int[] y )
    {
        double a = x[0] - y[0];
        double b = x[1] - y[1];
        return System.Math.Sqrt( a * a + b * b );
    }
}
