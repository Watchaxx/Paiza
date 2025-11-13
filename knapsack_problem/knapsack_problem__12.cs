// 実行時間 110ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] v = new int[n[0]];
        int[] w = new int[n[0]];
        int[,] d = new int[n[0] + 1, n[1] + 1];

        foreach( int i in Range( 0, n[0] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            w[i] = t[0];
            v[i] = t[1];
        }
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, n[1] + 1 ) ) {
                d[i + 1, j] = System.Math.Max( d[i + 1, j], d[i, j] );
                if( j + w[i] <= n[1] ) {
                    d[i + 1, j + w[i]] = System.Math.Max( d[i, j + w[i]], d[i, j] + v[i] );
                }
            }
        }
        WriteLine( d[n[0], n[1]] );
        return;
    }
}
