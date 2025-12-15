// 実行時間 3280ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[][] a = new int[n][];
        int[][] d = new int[1 << n][];

        foreach( int i in Range( 0, n ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in Range( 0, 1 << n ) ) {
            d[i] = Repeat( 1 << 16, n ).ToArray();
        }
        d[0][0] = 0;
        foreach( int i in Range( 0, 1 << n ) ) {
            foreach( int j in Range( 0, n ) ) {
                int c = d[i][j];

                if( c == 1 << 16 ) {
                    continue;
                }
                foreach( int k in Range( 0, n ).Where( x => ( i & ( 1 << x ) ) == 0 && j != x ) ) {
                    d[i | ( 1 << k )][k] = new[] { d[i | ( 1 << k )][k], c + a[j][k] }.Min();
                }
            }
        }
        WriteLine( d[( 1 << n ) - 1][0] );
        return;
    }
}
