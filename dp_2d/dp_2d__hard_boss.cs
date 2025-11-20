// 実行時間 110ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] b = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] c = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = ReadLine().Split().Select( int.Parse ).ToArray();
        long[][] p = new long[n + 1][];

        foreach( int i in Range( 0, n + 1 ) ) {
            p[i] = Repeat( long.MinValue / 2, n + 2 ).ToArray();
        }
        p[0][1] = 0L;
        p[0][2] = 0L;
        foreach( int i in Range( 1, n ) ) {
            foreach( int j in Range( 0, n + 2 ) ) {
                if( j + 2 <= n + 1 ) {
                    p[i][j] = Max( p[i][j], p[i - 1][j + 2] + a[i - 1] );
                }
                if( 3 <= j ) {
                    p[i][j] = Max( p[i][j], p[i - 1][j - 2] + b[i - 1] );
                }
                if( 1 <= j ) {
                    p[i][j] = Max( p[i][j], p[i - 1][j] + c[i - 1] );
                }
                if( 2 <= j ) {
                    p[i][j] = Max( p[i][j], p[i - 1][j] + d[i - 1] );
                }
            }
        }
        WriteLine( Max( p[n][0], p[n][1] ) );
        return;
    }
}
