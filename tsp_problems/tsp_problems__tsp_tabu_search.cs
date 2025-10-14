// 実行時間 230ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
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
        TabuSearch( n[0], n[1], n[2], p, x );
        WriteLine( string.Join( System.Environment.NewLine, p ) );
        return;
    }

    static double Euclidean( int[] x, int[] y )
    {
        double a = x[0] - y[0];
        double b = x[1] - y[1];
        return System.Math.Sqrt( a * a + b * b );
    }

    static double GetLen( int n, int[] t, int[][] p )
    {
        double l = 0d;

        foreach( int i in Range( 0, n ) ) {
            l += Euclidean( p[t[i]], p[t[( i + 1 ) % n]] );
        }
        return l;
    }

    static void TabuSearch( int n, int q, int tl, int[] t, int[][] p )
    {
        int[] tb = new int[n];
        System.Array.Copy( t, tb, n );
        double l = GetLen( n, tb, p );
        var qu = new System.Collections.Generic.Queue<int>();

        foreach( int _ in Range( 0, q ) ) {
            double d = int.MaxValue / 2d;
            double tmp = 0d;
            int ba = 0;
            int bb = 0;
            int rl = 0;
            int rs = 0;

            foreach( int i in Range( 0, n ) ) {
                if( qu.Contains( t[i] ) == true ) {
                    continue;
                }
                for( int j = i + 2; j < n; j++ ) {
                    if( i == 0 && j == n - 1 ) {
                        continue;
                    }

                    double d1 = Euclidean( p[t[i]], p[t[j]] ) + Euclidean( p[t[( i + 1 ) % n]], p[t[( j + 1 ) % n]] );
                    double d2 = Euclidean( p[t[i]], p[t[( i + 1 ) % n]] ) + Euclidean( p[t[j]], p[t[( j + 1 ) % n]] );

                    tmp = d1 - d2;
                    if( tmp < d ) {
                        ba = i;
                        bb = j;
                        d = tmp;
                    }
                }
            }
            qu.Enqueue( t[ba] );
            if( tl < qu.Count ) {
                qu.Dequeue();
            }
            rl = bb - ba;
            rs = ba + 1;
            System.Array.Copy( t.Skip( rs ).Take( rl ).Reverse().ToArray(), 0, t, rs, rl );
            tmp = GetLen( n, t, p );
            if( tmp < l ) {
                l = tmp;
                System.Array.Copy( t, tb, n );
            }
        }
        return;
    }
}
