// 実行時間 50ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[n[0]];
        int[][] d = new int[n[0] + 1][];

        foreach( int i in Range( 0, n[0] ) ) {
            a[i] = int.Parse( ReadLine() );
            d[i] = Repeat( int.MaxValue, n[2] + 1 ).ToArray();
        }
        d[n[0]] = Repeat( int.MaxValue, n[2] + 1 ).ToArray();
        d[0][0] = 0;
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, n[2] + 1 ).Where( x => d[i][x] != int.MaxValue ) ) {
                d[i + 1][j] = System.Math.Min( d[i + 1][j], d[i][j] );
                if( a[i] + j <= n[2] ) {
                    d[i + 1][j + a[i]] = System.Math.Min( d[i + 1][j + a[i]], d[i][j] + 1 );
                }
            }
        }
        WriteLine( d[n[0]][n[2]] <= n[1] ? "Yes" : "No" );
        return;
    }
}
