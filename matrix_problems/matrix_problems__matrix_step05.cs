// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[,] g = { { 1, 0, 0, 0, 0, 1, 1 },
            { 0, 1, 0, 0, 1, 0, 1 },
            { 0, 0, 1, 0, 1, 1, 0 },
            { 0, 0, 0, 1, 1, 1, 1 } };
        int[][] c = new int[1][];
        int[][] u = new int[1][];

        c[0] = new int[7];
        u[0] = ReadLine().Split().Select( int.Parse ).ToArray();
        foreach( int i in Range( 0, u.GetLength( 0 ) ) ) {
            foreach( int j in Range( 0, 7 ) ) {
                int s = 0;

                foreach( int k in Range( 0, u[0].Length ) ) {
                    s += u[i][k] * g[k, j];
                }
                c[i][j] = s % 2;
            }
        }
        WriteLine( string.Join( System.Environment.NewLine,
            Range( 0, c.GetLength( 0 ) ).Select( x => string.Join( " ", c[x] ) ) ) );
        return;
    }
}
