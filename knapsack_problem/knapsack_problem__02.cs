// 実行時間 40ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        const int mod = 1000;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[n[0]];
        bool[][] d = new bool[n[0] + 1][];

        foreach( int i in Range( 0, n[0] ) ) {
            a[i] = int.Parse( ReadLine() );
            d[i] = new bool[mod];
        }
        d[n[0]] = new bool[mod];
        d[0][0] = true;
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, mod ).Where( x => d[i][x] == true ) ) {
                d[i + 1][j] = true;
                d[i + 1][( a[i] + j ) % mod] = true;
            }
        }
        WriteLine( d[n[0]][n[1]] ? "Yes" : "No" );
        return;
    }
}
