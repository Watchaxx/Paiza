// 実行時間 40ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        bool[][] b = new bool[n[0] + 1][];

        foreach( int i in Range( 0, n[0] + 1 ) ) {
            b[i] = new bool[n[1] + 1];
        }
        b[0][0] = true;
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, n[1] + 1 ) ) {
                if( b[i][j] != true ) {
                    continue;
                }
                b[i + 1][j] = true;
                if( a[i] + j <= n[1] ) {
                    b[i + 1][a[i] + j] = true;
                }
            }
        }
        WriteLine( b[n[0]][n[1]] ? "Yes" : "No" );
        return;
    }
}
