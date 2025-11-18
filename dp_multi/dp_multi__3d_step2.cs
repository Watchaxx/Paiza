// 実行時間 200ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        const long mod = 1000000000L;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        long o = 0L;
        long[,,] d = new long[n[0] + 1, 301, 301];

        d[0, 0, 0] = 1L;
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, n[1] + 1 ) ) {
                foreach( int k in Range( 0, n[1] + 1 ) ) {
                    d[i + 1, j, k] += d[i, j, k];
                    d[i + 1, j, k] %= mod;
                    if( a[i] + j + k <= n[1] ) {
                        d[i + 1, k, a[i]] += d[i, j, k];
                        d[i + 1, k, a[i]] %= mod;
                    }
                }
            }
        }
        foreach( int i in Range( 0, n[1] + 1 ) ) {
            foreach( int j in Range( 0, n[1] + 1 ).Where( x => i + x <= n[1] ) ) {
                o += d[n[0], i, j];
                o %= mod;
            }
        }
        WriteLine( o );
        return;
    }
}
