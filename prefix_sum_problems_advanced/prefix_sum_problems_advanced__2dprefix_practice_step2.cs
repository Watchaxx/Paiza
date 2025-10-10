// 実行時間 430ms
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
        }
        foreach( int i in Range( 0, n[0] + 1 ) ) {
            b[i] = new int[n[0] + 1];
        }
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, n[0] ) ) {
                b[i + 1][j + 1] = b[i + 1][j] + b[i][j + 1] - b[i][j] + a[i][j];
            }
        }
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, n[0] ) ) {
                foreach( int k in Range( i, n[0] - i ) ) {
                    foreach( int l in Range( j, n[0] - j ) ) {
                        if( ( k - i + 1 ) * ( l - j + 1 ) <= n[1] ) {
                            o = System.Math.Max( o, b[k + 1][l + 1] - b[i][l + 1] - b[k + 1][j] + b[i][j] );
                        }
                    }
                }
            }
        }
        WriteLine( o );
        return;
    }
}
