// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    const int lenH = 3;

    static void Main()
    {
        int[,] h = { { 1, 0, 0 },
            { 0, 1, 0 },
            { 1, 1, 0 },
            { 0, 0, 1 },
            { 1, 0, 1 },
            { 0, 1, 1 },
            { 1, 1, 1 } };
        int[][] c = new int[1][];
        int[][] w = new int[1][];

        w[0] = ReadLine().Split().Select( int.Parse ).ToArray();
        c = Func( w, h );
        WriteLine( string.Join( " ", c[0] ) );
        if( c[0].All( x => x == 0 ) ) {
            WriteLine( -1 );
            return;
        }
        foreach( int i in Range( 0, 7 ) ) {
            int[][] e = new int[1][];

            e[0] = new int[7];
            e[0][i] = 1;
            if( Func( e, h )[0].SequenceEqual( c[0] ) == true ) {
                WriteLine( i + 1 );
                return;
            }
        }
        return;
    }

    static int[][] Func( int[][] a, int[,] b )
    {
        int[][] c = new int[1][];

        foreach( int i in Range( 0, a.GetLength( 0 ) ) ) {
            c[i] = new int[lenH];
            foreach( int j in Range( 0, lenH ) ) {
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
