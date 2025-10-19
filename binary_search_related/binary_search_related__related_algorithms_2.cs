// 実行時間 410ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static int n;
    static int[] a;
    static int[] b;

    static void Main()
    {
        double l = -1e9;
        double r =  1e9;

        n = int.Parse( ReadLine() );
        a = new int[n];
        b = new int[n];
        foreach( int i in Range( 0, n ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            a[i] = t[0];
            b[i] = t[1];
        }
        while( true ) {
            double m1 = l + ( r - l ) / 3;
            double m2 = r - ( r - l ) / 3;
            double f1 = Func( m1 );
            double f2 = Func( m2 );

            if( f2 < f1 ) {
                l = m1;
            } else {
                r = m2;
            }
            if( r - l < 1e-6 && Abs( f1 - f2 ) < 1e-6 ) {
                break;
            }
        }
        WriteLine( $"{l:f10} {Func( l ):f10}" );
        return;
    }

    static double Func( double d )
    {
        double r = -1e18;

        foreach( int i in Range( 0, n ) ) {
            r = Max( r, a[i] * d + b[i] );
        }
        return r;
    }
}
