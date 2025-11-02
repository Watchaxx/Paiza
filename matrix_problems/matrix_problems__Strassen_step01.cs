// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nm = ReadLine().Split().Select( int.Parse ).ToArray();
        int l = nm[0] * nm[1] * nm[0];
        int[][] a = new int[l][];

        foreach( int i in Range( 0, l ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in Range( 0, l ) ) {
            int[] b = ReadLine().Split().Select( int.Parse ).ToArray();

            foreach( int j in Range( 0, nm[1] ) ) {
                a[i][j] += b[j];
            }
        }
        WriteLine( string.Join( System.Environment.NewLine,
            Range( 0, l ).Select( x => string.Join( " ", a[x] ) ) ) );
        return;
    }
}
