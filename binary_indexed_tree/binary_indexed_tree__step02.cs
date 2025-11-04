// 実行時間 670ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[][] g = new int[n][];

        foreach( int i in Range( 0, n ) ) {
            g[i] = new int[n];
        }
        foreach( int _ in Range( 0, n - 1 ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[t[0]][t[1]] = 1;
            g[t[1]][t[0]] = 1;
        }
        WriteLine( string.Join( System.Environment.NewLine,
            Range( 0, n ).Select( x => string.Join( " ", g[x] ) ) ) );
        return;
    }
}
