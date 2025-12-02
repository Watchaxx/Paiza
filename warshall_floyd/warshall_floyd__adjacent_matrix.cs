// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] o = new int[n[0]][];

        foreach( int i in Range( 0, n[0] ) ) {
            o[i] = Repeat( 999, n[0] ).ToArray();
            o[i][i] = 0;
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            o[t[0]][t[1]] = t[2] + 1;
        }
        WriteLine( string.Join( System.Environment.NewLine, o.Select( x => string.Join( " ", x ) ) ) );
        return;
    }
}
