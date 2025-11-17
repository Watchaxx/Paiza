// 実行時間 40ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        const int mod = 1000000000;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        long[,] d = new long[n[0] + 1, n[1] + 1];

        d[0, 0] = 1;
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, n[1] + 1 ) ) {
                d[i + 1, j] += d[i, j];
                d[i + 1, j] %= mod;
                if( j + a[i] <= n[1] ) {
                    d[i + 1, j + a[i]] += d[i, j];
                    d[i + 1, j + a[i]] %= mod;
                }
            }
        }
        WriteLine( d[n[0], n[1]] );
        return;
    }
}
