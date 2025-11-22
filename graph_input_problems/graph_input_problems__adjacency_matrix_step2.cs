// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] m = new int[n[0]][];

        foreach( int i in Range( 0, n[0] ) ) {
            m[i] = new int[n[0]];
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            m[t[0]][t[1]] = 1;
        }
        WriteLine( string.Join(
            System.Environment.NewLine, Range( 0, n[0] ).Select( x => string.Join( " ", m[x] ) ) ) );
        return;
    }
}
