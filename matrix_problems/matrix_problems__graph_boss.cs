// 実行時間 50ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 0;
        int[][] a = new int[n][];
        int[][] b = new int[n][];

        foreach( int i in Range( 0, n ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            a[i] = new int[n];
            t.CopyTo( a[i], 0 );
            b[i] = new int[n];
            t.CopyTo( b[i], 0 );
        }
        b = Func( b, a );
        b = Func( b, a );
        foreach( int i in Range( 0, n ) ) {
            o += b[i][i];
        }
        WriteLine( o / 6 );
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
                    s += a[i][k] * b[k][j];
                }
                c[i][j] = s;
            }
        }
        return c;
    }
}
