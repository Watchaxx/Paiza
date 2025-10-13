// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static uint State { get; set; } = 813u;

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] p = new int[n[0]];
        int[][] x = new int[n[0]][];

        foreach( int i in Range( 0, n[0] ) ) {
            x[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in Range( 0, n[0] ) ) {
            p[i] = int.Parse( ReadLine() );
        }
        TwoOpt( n[0], n[1], p, x );
        WriteLine( string.Join( System.Environment.NewLine, p ) );
        return;
    }

    static double Euclidean( int[] x, int[] y )
    {
        double a = x[0] - y[0];
        double b = x[1] - y[1];
        return System.Math.Sqrt( a * a + b * b );
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

    static void TwoOpt( int n, int q, int[] p, int[][] x )
    {
        foreach( int _ in Range( 0, q ) ) {
            int a = 0;
            int b = 0;

            PickTwo( ref a, ref b, n );

            double d1 = Euclidean( x[p[a]], x[p[b]] ) + Euclidean( x[p[( a + 1 ) % n]], x[p[( b + 1 ) % n]] );
            double d2 = Euclidean( x[p[a]], x[p[( a + 1 ) % n]] ) + Euclidean( x[p[b]], x[p[( b + 1 ) % n]] );

            if( d1 < d2 ) {
                int k = a + 1;
                int l = b - a;

                System.Array.Copy( p.Skip( k ).Take( l ).Reverse().ToArray(), 0, p, k, l );
            }
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
