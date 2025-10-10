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
        int[][] b = new int[n[0] + 1][];

        foreach( int i in Range( 0, n[0] ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
            b[i] = new int[n[0] + 1];
        }
        b[n[0]] = new int[n[0] + 1];
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] x = ReadLine().Split().Select( z => int.Parse( z ) - 1 ).ToArray();

            b[x[1]][x[0]]++;
            b[x[1] + n[2]][x[0] + n[2]]++;
            b[x[1]][x[0] + n[2]]--;
            b[x[1] + n[2]][x[0]]--;
        }
        foreach( int i in Range( 0, n[0] + 1 ) ) {
            foreach( int j in Range( 1, n[0] ) ) {
                b[i][j] += b[i][j - 1];
            }
        }
        foreach( int i in Range( 1, n[0] ) ) {
            foreach( int j in Range( 0, n[0] + 1 ) ) {
                b[i][j] += b[i - 1][j];
            }
        }
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, n[0] ) ) {
                if( a[i][j] <= b[i][j] ) {
                    o++;
                }
            }
        }
        WriteLine( o );
        return;
    }
}
