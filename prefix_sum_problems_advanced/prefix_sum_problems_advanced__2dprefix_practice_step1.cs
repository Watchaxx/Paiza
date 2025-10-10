// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int o = 0;
        int[][] a = new int[n[0]][];
        int[][] b = new int[n[0] + 1][];

        foreach( int i in Range( 0, n[0] ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in Range( 0, n[0] + 1 ) ) {
            b[i] = new int[n[0] + 1];
        }
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, n[0] ) ) {
                b[i + 1][j + 1] = b[i + 1][j] + b[i][j + 1] - b[i][j] + a[i][j];
            }
        }
        foreach( int i in Range( 0, n[0] - n[1] + 1 ) ) {
            foreach( int j in Range( 0, n[0] - n[2] + 1 ) ) {
                o = System.Math.Max( o, b[j + n[2]][i + n[1]] - b[j][i + n[1]] - b[j + n[2]][i] + b[j][i] );
            }
        }
        WriteLine( o );
        return;
    }
}
