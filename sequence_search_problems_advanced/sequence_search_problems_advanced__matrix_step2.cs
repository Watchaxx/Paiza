// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] a = new int[n[0]][];

        foreach( int i in Range( 0, n[0] ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in Range( 0, n[0] - 1 ) ) {
            foreach( int j in Range( 0, n[1] - 1 ) ) {
                if( a[i][j] == a[i + 1][j] && a[i][j] == a[i][j + 1] && a[i][j] == a[i + 1][j + 1] ) {
                    o++;
                }
            }
        }
        WriteLine( o );
        return;
    }
}
