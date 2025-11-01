// 実行時間 1270ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nxl = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] a = new int[nxl[0]][];
        int[][] b = new int[nxl[0]][];

        foreach( int i in Range( 0, nxl[0] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            a[i] = new int[nxl[0]];
            t.CopyTo( a[i], 0 );
            b[i] = new int[nxl[0]];
            t.CopyTo( b[i], 0 );
        }
        foreach( int _ in Range( 1, nxl[2] - 1 ) ) {
            b = Func( b, a );
        }
        WriteLine( b[0][nxl[1] - 1] );
        return;
    }

    static int[][] Func( int[][] a, int[][] b )
    {
        int ah = a.GetLength( 0 );
        int aw = a[0].Length;
        int bw = b[0].Length;
        int[][] c = new int[ah][];

        foreach( int i in Range( 0, ah ) ) {
            c[i] = new int[bw];
            foreach( int j in Range( 0, bw ) ) {
                int s = 0;

                foreach( int k in Range( 0, aw ) ) {
                    s = ( s + a[i][k] * b[k][j] ) % 1000;
                }
                c[i][j] = s;
            }
        }
        return c;
    }
}
