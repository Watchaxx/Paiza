// 実行時間 160ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] d = new int[n + 1][];
        int ma = a.Max();

        foreach( int i in Range( 0, n + 1 ) ) {
            d[i] = Repeat( int.MaxValue, ma + 1 ).ToArray();
        }
        foreach( int i in Range( 0, ma + 1 ) ) {
            d[1][i] = Abs( a[0] - i );
        }
        foreach( int i in Range( 2, n - 1 ) ) {
            foreach( int j in Range( 0, ma + 1 ) ) {
                d[i][0] = Min( d[i][0], d[i - 1][j] + Abs( a[i - 1] - j ) );
            }
            foreach( int j in Range( 1, ma ) ) {
                foreach( int k in Range( 1, ma ) ) {
                    d[i][j] = Min( d[i][j], d[i - 1][k] + Abs( a[i - 1] - ( j + k ) ) );
                }
            }
        }
        WriteLine( d[n][0] );
        return;
    }
}
