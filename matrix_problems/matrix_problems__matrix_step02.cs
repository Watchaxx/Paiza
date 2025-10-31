// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] hw = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] a = new int[hw[0]][];

        foreach( int i in Range( 0, hw[0] ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in Range( 0, hw[0] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            foreach( int j in Range( 0, hw[1] ) ) {
                a[i][j] -= t[j];
            }
        }
        foreach( int[] i in a ) {
            WriteLine( string.Join( " ", i ) );
        }
        return;
    }
}
