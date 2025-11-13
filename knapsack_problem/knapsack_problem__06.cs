// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[n[0]];
        bool[][] d = new bool[n[0] + 1][];

        foreach( int i in Range( 0, n[0] ) ) {
            a[i] = int.Parse( ReadLine() );
            d[i] = new bool[n[1] + 1];
        }
        d[n[0]] = new bool[n[1] + 1];
        d[0][0] = true;
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, n[1] + 1 ) ) {
                if( d[i][j] == true ) {
                    d[i + 1][j] = true;
                }
                if( a[i] <= j && d[i + 1][j - a[i]] == true ) {
                    d[i + 1][j] = true;
                }
            }
        }
        WriteLine( d[n[0]][n[1]] ? "Yes" : "No" );
        return;
    }
}
