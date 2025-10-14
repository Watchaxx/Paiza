// 実行時間 40ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static uint State { get; set; } = 813u;

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
        SimulatedAnnealing( n, p, x );
        WriteLine( string.Join( System.Environment.NewLine, p ) );
        return;
    }

    static double Euclidean( int[] x, int[] y )
    {
        return Sqrt( Pow( x[0] - y[0], 2d ) + Pow( x[1] - y[1], 2d ) );
    }

    static void PickTwo( ref int a, ref int b, int n )
    {
        while( true ) {
            a = (int)( XorShift32() % n );
            b = (int)( XorShift32() % n );
            if( b < a ) {
                int t = a;
                a = b;
                b = t;
            }
            if( ( b <= a + 1 ) || ( a == 0 && b == n - 1 ) ) {
                continue;
            }
            return;
        }
    }

    static double Rnd()
    {
        return ( XorShift32() - 1 ) / 4294967294d;
    }

    static void SimulatedAnnealing( int n, int[] t, int[][] p )
    {
        double z = 1000d;

        while( 0.1 <= z ) {
            int a = 0;
            int b = 0;

            PickTwo( ref a, ref b, n );

            double d1 = Euclidean( p[t[a]], p[t[b]] ) + Euclidean( p[t[( a + 1 ) % n]], p[t[( b + 1 ) % n]] );
            double d2 = Euclidean( p[t[a]], p[t[( a + 1 ) % n]] ) + Euclidean( p[t[b]], p[t[( b + 1 ) % n]] );

            if( d1 < d2 || Rnd() <= Exp( ( d2 - d1 ) / z ) ) {
                int l = b - a;
                int s = a + 1;

                System.Array.Copy( t.Skip( s ).Take( l ).Reverse().ToArray(), 0, t, s, l );
            }
            z *= 0.99;
        }
        return;
    }

    static uint XorShift32()
    {
        uint x = State;

        x ^= x << 13;
        x ^= x >> 17;
        x ^= x << 5;
        return State = x;
    }
}
