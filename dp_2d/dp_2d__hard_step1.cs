// 実行時間 530ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        long[] a = ReadLine().Split().Select( long.Parse ).ToArray();
        long[] b = ReadLine().Split().Select( long.Parse ).ToArray();
        long[][] d = new long[n[0] + 1][];

        d[0] = new long[n[1] + 1];
        foreach( int i in Range( 1, n[0] ) ) {
            d[i] = new long[n[1] + 1];
            foreach( int j in Range( 0, n[1] + 1 ) ) {
                foreach( int k in Range( 0, n[1] - j + 1 ) ) {
                    d[i][j + k] = new[] { d[i][j + k],
                        d[i - 1][j] + a[i - 1] * ( k / 2 + 1 ) + b[i - 1] * ( ( k + 1 ) / 2 ) }.Max();
                }
            }
        }
        WriteLine( d[n[0]].Max() );
        return;
    }
}
