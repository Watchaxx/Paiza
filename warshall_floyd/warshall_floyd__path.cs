// 実行時間 40ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] a = new int[n[0]][];
        int[][] p = new int[n[0]][];

        foreach( int i in Range( 0, n[0] ) ) {
            a[i] = Repeat( 999, n[0] ).ToArray();
            a[i][i] = 0;
            p[i] = Repeat( i + 1, n[0] ).ToArray();
        }
        foreach( int i in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            a[t[0]][t[1]] = t[2] + 1;
        }
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, n[0] ) ) {
                foreach( int k in Range( 0, n[0] ).Where( x => a[j][i] + a[i][x] < a[j][x] ) ) {
                    a[j][k] = a[j][i] + a[i][k];
                    p[j][k] = p[i][k];
                }
            }
        }
        if( a[n[2] - 1][n[3] - 1] == 999 ) {
            WriteLine( 999 );
        } else {
            int pre = n[3];
            var pth = new System.Collections.Generic.List<int>() { n[3] };

            while( true ) {
                pre = p[n[2] - 1][pre - 1];
                pth.Add( pre );
                if( pre == n[2] ) {
                    break;
                }
            }
            pth.Reverse();
            WriteLine( a[n[2] - 1][n[3] - 1] );
            WriteLine( string.Join( " ", pth ) );
        }
        return;
    }
}
