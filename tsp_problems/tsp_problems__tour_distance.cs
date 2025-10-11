// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        double o = 0d;
        int n = int.Parse( ReadLine() );
        int[][] a = new int[n][];

        foreach( int i in Range( 0, n ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }

        int[] p = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

        foreach( int i in Range( 0, n - 1 ) ) {
            o += Euclidean( a[p[i]][0], a[p[i]][1], a[p[i + 1]][0], a[p[i + 1]][1] );
        }
        WriteLine( o += Euclidean( a[p[n - 1]][0], a[p[n - 1]][1], a[p[0]][0], a[p[0]][1] ) );
        return;
    }

    static double Euclidean( double x1, double y1, double x2, double y2 )
    {
        double x = x1 - x2;
        double y = y1 - y2;
        return System.Math.Sqrt( x * x + y * y );
    }
}
