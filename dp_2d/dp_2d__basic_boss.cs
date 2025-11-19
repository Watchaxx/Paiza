// 実行時間 600ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[][] p = new int[n + 1][];
        sbyte[] d = Func( ReadLine() );
        sbyte[] t = Func( ReadLine() );

        foreach( int i in Range( 0, n + 1 ) ) {
            p[i] = Repeat( int.MaxValue, 10 ).ToArray();
        }
        foreach( int i in Range( 0, 10 ) ) {
            p[1][i] = Min( ( i - d[0] + 10 ) % 10, ( d[0] - i + 10 ) % 10 );
        }
        foreach( int i in Range( 2, n - 1 ) ) {
            foreach( int j in Range( 0, 10 ) ) {
                foreach( int k in Range( -9, 19 ).Where( x => ( j + x + 10 ) % 10 == t[i - 2] ) ) {
                    p[i][( d[i - 1] + k + 10 ) % 10]
                        = Min( p[i][( d[i - 1] + k + 10 ) % 10], p[i - 1][j] + Abs( k ) );
                }
            }
        }
        WriteLine( p[n][t.Last()] );
        return;
    }

    static sbyte[] Func( string s )
    {
        sbyte[] a = new sbyte[s.Length];

        foreach( int i in Range( 0, s.Length ) ) {
            a[i] = sbyte.Parse( $"{s[i]}" );
        }
        return a;
    }
}
