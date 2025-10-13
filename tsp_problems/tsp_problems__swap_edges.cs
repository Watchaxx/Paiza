// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] p = new int[n];
        int[][] x = new int[n][];

        foreach( int i in Range( 0, n ) ) {
            x[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in Range( 0, n ) ) {
            p[i] = int.Parse( ReadLine() );
        }

        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        double d1 = Euclidean( x[p[a[0]]], x[p[a[1]]] ) + Euclidean( x[p[( a[0] + 1 ) % n]], x[p[( a[1] + 1 ) % n]] );
        double d2 = Euclidean( x[p[a[0]]], x[p[( a[0] + 1 ) % n]] ) + Euclidean( x[p[a[1]]], x[p[( a[1] + 1 ) % n]] );

        if( d1 < d2 ) {
            int l = a[1] - a[0];
            int s = a[0] + 1;

            System.Array.Copy( p.Skip( s ).Take( l ).Reverse().ToArray(), 0, p, s, l );
            WriteLine( "Yes" );
            WriteLine( string.Join( System.Environment.NewLine, p ) );
        } else {
            WriteLine( "No" );
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
