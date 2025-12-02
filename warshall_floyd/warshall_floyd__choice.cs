// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

class Program
{
    static void Main()
    {
        int m = 999;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] a = new int[n[0]][];
        var l = new Lst();

        foreach( int i in Range( 0, n[0] ) ) {
            a[i] = Repeat( 999, n[0] ).ToArray();
            a[i][i] = 0;
        }
        foreach( int i in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            a[t[0]][t[1]] = t[2] + 1;
        }
        foreach( int i in Range( 1, n[0] ).Where( x => x != n[2] && x != n[3] ) ) {
            int len = a[n[2] - 1][i - 1] + a[i - 1][n[3] - 1];

            if( len < m ) {
                m = len;
                l = new Lst { i };
            } else if( len == m ) {
                l.Add( i );
            }
        }
        WriteLine( 0 < l.Count ? string.Join( " ", l ) : "999" );
        return;
    }
}
