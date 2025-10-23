// 実行時間 70ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).OrderBy( x => x ).ToArray();
        int[][] d = new int[n[0] + 1][];

        foreach( int i in Range( 0, n[0] + 1 ) ) {
            d[i] = Repeat( int.MaxValue, n[1] + 1 ).ToArray();
        }
        d[0][0] = 0;
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, n[1] + 1 ) ) {
                if( d[i][j] == int.MaxValue ) {
                    continue;
                }
                d[i + 1][j] = Min( d[i + 1][j], d[i][j] );
                if( a[i] + j <= n[1] ) {
                    d[i + 1][a[i] + j] = Min( d[i + 1][a[i] + j], d[i][j] + 1 );
                }
            }
        }
        if( d[n[0]][n[1]] == int.MaxValue ) {
            WriteLine( -1 );
            return;
        }

        var l = new System.Collections.Generic.List<int>();

        foreach( int i in Range( 1, n[0] ).Reverse() ) {
            if( n[1] - a[i - 1] < 0 ) {
                continue;
            }
            if( d[i - 1][n[1] - a[i - 1]] == d[i][n[1]] - 1 ) {
                l.Add( a[i - 1] );
                n[1] -= a[i - 1];
            }
            if( n[1] == 0 ) {
                break;
            }
        }
        WriteLine( l.Count );
        WriteLine( string.Join( " ", l ) );
        return;
    }
}
