// 実行時間 950ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] x = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] d = new int[n[1] + 1][];

        foreach( int i in Range( 0, n[1] + 1 ) ) {
            d[i] = Repeat( int.MinValue, n[0] + 1 ).ToArray();
        }
        d[0][1] = 0;
        foreach( int i in Range( 1, n[1] ) ) {
            foreach( int j in Range( 1, n[0] ) ) {
                d[i][j] = new[] { d[i - 1][j], d[i - 1][j - 1] }.Max();
                if( j == x[i - 1] ) {
                    d[i][j]++;
                }
            }
        }
        WriteLine( d[n[1]].Max() );
        return;
    }
}
