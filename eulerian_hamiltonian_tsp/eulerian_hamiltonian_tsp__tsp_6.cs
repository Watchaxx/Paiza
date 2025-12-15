// 実行時間 3010ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

class Program
{
    static void Main()
    {
        const int inf = 1 << 30;
        int n = int.Parse( ReadLine() );
        int m = 1 << n;
        int o = inf;
        int[] b = new int[n];
        int[] c = new int[n];
        int[] p = new int[m];
        int[][] a = new int[n][];

        foreach( int i in Range( 0, n ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in Range( 0, n ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            b[i] = t[0];
            c[i] = t[1];
        }
        foreach( int i in Range( 1, m - 1 ) ) {
            p[i] = p[i >> 1] + ( i & 1 );
        }
        foreach( int z in Range( 0, n ) ) {
            int[][] d = new int[m][];

            foreach( int i in Range( 0, m ) ) {
                d[i] = Repeat( inf, n ).ToArray();
            }
            d[0][z] = 0;
            foreach( int i in Range( 0, m ) ) {
                foreach( int j in Range( 0, n ) ) {
                    int e = d[i][j];

                    if( e == inf ) {
                        continue;
                    }
                    foreach( int k in Range( 0, n ) ) {
                        if( ( ( i & ( 1 << k ) ) != 0 ) || j == k ) {
                            continue;
                        }

                        int t = a[j][k];
                        int u = i | ( 1 << k );

                        if( b[k] < p[i] + 1 ) {
                            t += c[k];
                        }
                        d[u][k] = Min( d[u][k], e + t );
                    }
                }
            }
            o = Min( o, d[m - 1][z] );
        }
        WriteLine( o );
        return;
    }
}
