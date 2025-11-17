// 実行時間 150ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] b = ReadLine().Split().Select( int.Parse ).ToArray();
        long o = 0L;
        long[,] d = new long[n[0] + 1, n[1]];

        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, n[1] ) ) {
                foreach( int k in Range( 0, 1000 ).Where( x => x * a[i] + j < n[1] ) ) {
                    d[i + 1, k * a[i] + j] = Max( d[i + 1, k * a[i] + j], k * b[i] + d[i, j] );
                }
            }
        }
        foreach( int i in Range( 0, n[1] ) ) {
            o = Max( o, d[n[0], i] );
        }
        WriteLine( n[2] <= o ? "Yes" : "No" );
        return;
    }
}
