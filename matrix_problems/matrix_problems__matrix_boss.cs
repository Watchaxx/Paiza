// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    const int hh = 7;
    const int hw = 3;

    static void Main()
    {
        int r = -1;
        int[,] h = { { 1, 0, 0 },
            { 0, 1, 0 },
            { 1, 1, 0 },
            { 0, 0, 1 },
            { 1, 0, 1 },
            { 0, 1, 1 },
            { 1, 1, 1 } };
        int[][] s = new int[1][];
        int[][] w = new int[1][];

        w[0] = ReadLine().Split().Select( int.Parse ).ToArray();
        s = Func( w, h );
        if( s[0].All( x => x == 0 ) != true ) {
            foreach( int i in Range( 0, hh ) ) {
                int[][] e = new int[1][];

                e[0] = new int[hh];
                e[0][i] = 1;
                if( s[0].SequenceEqual( Func( e, h )[0] ) == true ) {
                    r = i;
                    break;
                }
            }
        }
        if( r != -1 ) {
            w[0][r] = ( w[0][r] + 1 ) % 2;
        }
        WriteLine( string.Join( " ", w[0] ) );
        return;
    }

    static int[][] Func( int[][] a, int[,] b )
    {
        int[][] c = new int[1][];

        foreach( int i in Range( 0, a.GetLength( 0 ) ) ) {
            c[i] = new int[hw];
            foreach( int j in Range( 0, hw ) ) {
                int s = 0;

                foreach( int k in Range( 0, a[0].Length ) ) {
                    s += a[i][k] * b[k, j];
                }
                c[i][j] = s % 2;
            }
        }
        return c;
    }
}
