// 実行時間 90ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] a = new int[n[0]][];

        foreach( int i in Range( 0, n[0] ) ) {
            a[i] = Repeat( 999, n[0] ).ToArray();
            a[i][i] = 0;
        }
        foreach( int i in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            a[t[0]][t[1]] = t[2] + 1;
        }
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, n[0] ) ) {
                foreach( int k in Range( 0, n[0] ) ) {
                    a[j][k] = new[] { a[j][k], a[j][i] + a[i][k] }.Min();
                }
            }
        }
        foreach( int _ in Range( 0, n[2] ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            WriteLine( a[t[0]][t[1]] );
        }
        return;
    }
}
