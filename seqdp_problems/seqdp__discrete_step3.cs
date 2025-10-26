// 実行時間 900ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        long[][] d = new long[n[0] + 1][];
        long o = 0L;

        foreach( int i in Range( 0, n[0] + 1 ) ) {
            d[i] = new long[1 << n[1]];
        }
        d[0][0] = 1;
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, 1 << n[1] ) ) {
                d[i + 1][j] += d[i][j];
                foreach( int k in Range( 0, n[1] ).Where( x => ( j & ( 1 << x ) ) == 0 ) ) {
                    if( i + a[k] <= n[0] ) {
                        d[i + a[k]][j | ( 1 << k )] += d[i][j];
                    }
                }
            }
        }
        foreach( long l in d[n[0]] ) {
            o += l;
        }
        WriteLine( o );
        return;
    }
}
