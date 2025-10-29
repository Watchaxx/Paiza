// 実行時間 40ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[][] a = new int[n][];
        int[][] b = new int[n][];
        int[][] c = new int[n][];

        foreach( int i in Range( 0, n ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in Range( 0, n ) ) {
            b[i] = ReadLine().Split().Select( int.Parse ).ToArray();
            c[i] = new int[n];
        }
        foreach( int i in Range( 0, n ) ) {
            foreach( int j in Range( 0, n ) ) {
                foreach( int k in Range( 0, n ) ) {
                    c[i][j] += a[i][k] * b[k][j];
                }
            }
            WriteLine( string.Join( " ", c[i] ) );
        }
        return;
    }
}
