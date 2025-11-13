// 実行時間 90ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[n[0]];
        int[] m = new int[n[0]];
        int[][] d = new int[n[0] + 1][];

        foreach( int i in Range( 0, n[0] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            a[i] = t[0];
            m[i] = t[1];
            d[i] = Repeat( -1, n[1] + 1 ).ToArray();
        }
        d[n[0]] = Repeat( -1, n[1] + 1 ).ToArray();
        d[0][0] = 0;
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, n[1] + 1 ) ) {
                d[i + 1][j] = 0 <= d[i][j] ? m[i]
                    : j < a[i] || d[i + 1][j - a[i]] <= 0 ? -1
                    : d[i + 1][j - a[i]] - 1;
            }
        }
        WriteLine( 0 <= d[n[0]][n[1]] ? "Yes" : "No" );
        return;
    }
}
