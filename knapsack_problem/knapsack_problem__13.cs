// 実行時間 50ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] v = new int[n[0]];
        int[] w = new int[n[0]];
        int[,] d = new int[n[0] + 1, 100 * n[0] + 1];

        foreach( int i in Range( 0, n[0] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            w[i] = t[0];
            v[i] = t[1];
            foreach( int j in Range( 0, 100 * n[0] + 1 ) ) {
                d[i, j] = int.MaxValue / 2;
            }
        }
        foreach( int j in Range( 0, 100 * n[0] + 1 ) ) {
            d[n[0], j] = int.MaxValue / 2;
        }
        d[0, 0] = 0;
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, 100 * n[0] ) ) {
                d[i + 1, j] = d[i, j];
                if( v[i] <= j ) {
                    d[i + 1, j] = System.Math.Min( d[i + 1, j], d[i, j - v[i]] + w[i] );
                }
            }
        }
        foreach( int i in Range( 0, 100 * n[0] ).Where( x => d[n[0], x] <= n[1] ) ) {
            o = i;
        }
        WriteLine( o );
        return;
    }
}
