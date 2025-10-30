// 実行時間 60ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] hwn = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] a = new int[64][];
        string[] s = new string[hwn[0]];

        foreach( int i in Range( 0, hwn[0] ) ) {
            s[i] = ReadLine();
        }
        a[0] = new int[hwn[0] * hwn[1]];
        foreach( int i in Range( 0, hwn[0] ) ) {
            foreach( int j in Range( 0, hwn[1] ) ) {
                switch( s[i][j] ) {
                case 'U':
                    a[0][i * hwn[1] + j] = ( i + hwn[0] - 1 ) % hwn[0] * hwn[1] + j;
                    break;
                case 'D':
                    a[0][i * hwn[1] + j] = ( i + 1 ) % hwn[0] * hwn[1] + j;
                    break;
                case 'L':
                    a[0][i * hwn[1] + j] = i * hwn[1] + ( j + hwn[1] - 1 ) % hwn[1];
                    break;
                case 'R':
                    a[0][i * hwn[1] + j] = i * hwn[1] + ( j + 1 ) % hwn[1];
                    break;
                }
            }
        }
        foreach( int i in Range( 1, 63 ) ) {
            a[i] = NextRow( hwn[0] * hwn[1], a[i - 1] );
        }
        foreach( int _ in Range( 0, hwn[2] ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();
            int d = Move( t[0] * hwn[1] + t[1], t[2] + 1, a );

            WriteLine( $"{d / hwn[1] + 1} {d % hwn[1] + 1}" );
        }
        return;
    }

    static int Move( int s, int k, int[][] a )
    {
        foreach( int i in Range( 0, 64 ).Where( x => ( k & ( 1L << x ) ) != 0 ) ) {
            s = a[i][s];
        }
        return s;
    }

    static int[] NextRow( int n, int[] a )
    {
        int[] r = new int[n];

        foreach( int i in Range( 0, n ) ) {
            r[i] = a[a[i]];
        }
        return r;
    }
}
