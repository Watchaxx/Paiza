// 実行時間 100ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int ma = a.Max();
        int[][] d = new int[n + 1][];

        d[0] = Repeat( 0, ma + 1 ).ToArray();
        foreach( int i in Range( 1, n ) ) {
            d[i] = Repeat( int.MaxValue, ma + 1 ).ToArray();
        }
        foreach( int i in Range( 1, n ) ) {
            foreach( int j in Range( 0, ma + 1 ) ) {
                for( int k = Max( 0, j - 1 ); k <= Min( ma, j + 1 ); k++ ) {
                    d[i][j] = Min( d[i][j], d[i - 1][k] + Abs( a[i - 1] - j ) );
                }
            }
        }
        WriteLine( d[n].Min() );
        return;
    }
}
