// 実行時間 1580ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int s = ( 1 << n ) - 1;
        int v = 0;
        int[][] a = new int[n][];
        int[][] d = new int[1 << n][];
        int[][] f = new int[1 << n][];
        var l = new System.Collections.Generic.List<int>();

        foreach( int i in Range( 0, n ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in Range( 0, 1 << n ) ) {
            d[i] = Repeat( 1 << 16, n ).ToArray();
            f[i] = Repeat( -1, n ).ToArray();
        }
        d[0][0] = 0;
        foreach( int i in Range( 0, 1 << n ) ) {
            foreach( int j in Range( 0, n ) ) {
                int c = d[i][j];

                if( c == 1 << 16 ) {
                    continue;
                }
                foreach( int k in Range( 0, n ).Where( x =>
                ( i & ( 1 << x ) ) == 0 && j != x && c + a[j][x] < d[i | ( 1 << x )][x] ) ) {
                    d[i | ( 1 << k )][k] = c + a[j][k];
                    f[i | ( 1 << k )][k] = j;
                }
            }
        }
        WriteLine( d[s][0] );
        while( 0 < s ) {
            int u = f[s][v];

            l.Add( v + 1 );
            s ^= 1 << v;
            v = u;
        }
        l.Add( 1 );
        l.Reverse();
        WriteLine( string.Join( " ", l ) );
        return;
    }
}
