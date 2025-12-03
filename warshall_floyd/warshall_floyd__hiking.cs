// 実行時間 40ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int m = 0;
        int q = 0;
        int r = 0;
        int s = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] a = new int[n[0]][];
        int[][] p = new int[n[0]][];
        var l = new System.Collections.Generic.List<int>();

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
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, n[0] ).Where( x => m < a[i][x] && a[i][x] < 999 ) ) {
                m = a[i][j];
                r = i + 1;
                s = j + 1;
            }
        }
        q = s;
        l.Add( s );
        while( true ) {
            q = p[r - 1][q - 1];
            l.Add( q );
            if( q == r ) {
                break;
            }
        }
        l.Reverse();
        WriteLine( m );
        WriteLine( string.Join( " ", l ) );
        return;
    }
}
