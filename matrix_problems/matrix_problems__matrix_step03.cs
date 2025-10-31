// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] hw = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] a = new int[hw[0]][];
        int[][] b = new int[hw[2]][];
        int[][] c = new int[hw[0]][];

        foreach( int i in Range( 0, hw[0] ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
            c[i] = new int[hw[3]];
        }
        foreach( int i in Range( 0, hw[2] ) ) {
            b[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in Range( 0, hw[0] ) ) {
            foreach( int j in Range( 0, hw[3] ) ) {
                int s = 0;

                foreach( int k in Range( 0, hw[1] ) ) {
                    s += a[i][k] * b[k][j];
                }
                c[i][j] = s;
            }
        }
        WriteLine( string.Join( System.Environment.NewLine,
            Range( 0, hw[0] ).Select( x => string.Join( " ", c[x] ) ) ) );
        return;
    }
}
