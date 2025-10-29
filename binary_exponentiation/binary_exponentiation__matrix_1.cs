// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[][] a = new int[n][];
        int[][] b = new int[n][];

        foreach( int i in Range( 0, n ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in Range( 0, n ) ) {
            b[i] = ReadLine().Split().Select( int.Parse ).ToArray();
            foreach( int j in Range( 0, n ) ) {
                a[i][j] += b[i][j];
            }
            WriteLine( string.Join( " ", a[i] ) );
        }
        return;
    }
}
